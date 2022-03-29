using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GGManager.Helpers
{
    public class RequestsControl
    {
        public MainForm _MForm;

        public CookieContainer _Cookies = new CookieContainer();
        public HttpClient _ControlClient;

        public List<Link> _Links = new List<Link>();

        string _UrlIDSearchPattern = "eid=\"(\\d+)"; // Паттерн ID коротких ссылок
        string _ShortUrlSearchPattern = "value=\"([\\w]+://gg.gg/\\w+)"; // Паттерн коротких ссылок
        string _CounterOfUrlsPattern = @"\>(\d+)<"; // Паттерн счётчика переходов

        public async Task LoginOnGG(string login, string password)
        {
            await CreateAndSetClient();
            _MForm.StatusLabel.Text = "Выполняю вход...";
            var LoginResponse = await _ControlClient.PostAsync("http://gg.gg/auth/login", new FormUrlEncodedContent(DataForm(login, password)));
            if (LoginResponse.IsSuccessStatusCode)
            {
                var GetLinksNumResponse = await (_ControlClient.GetAsync("http://gg.gg"));
                var HtmlContent = await GetLinksNumResponse.Content.ReadAsStringAsync();
                if (GetLinksNumResponse.IsSuccessStatusCode && HtmlContent.Contains("Logout"))
                {
                    await SaveLogPass(login, password);
                    await URLS_update();
                    _MForm.StatusLabel.Text = $"[ВОШЁЛ] Всего ссылок на аккаунте: " + _Links.Count;
                    await Task.Delay(2700);
                    BeginMonitoring();
                }
                else
                    _MForm.StatusLabel.Text = "Введённые данные некорректны!";
            }
        }

        private void BeginMonitoring()
        {
            _MForm._Clipboard.ClipBoardMonitor(); // Запускаю асинхронную проверку буфера обмена
            _MForm.MainGB.Enabled = false;
            _MForm.StatusLabel.Text = "Мониторю буфера обмена...";
            _MForm.FormTitleUPD(); // Запускаю асинхронное обновление заголовка окна главной формы (почему бы и нет)
        }

        public async Task CreateAndSetClient()
        {
            if (_ControlClient == null)
            {
                HttpClientHandler ClientHandler = new HttpClientHandler() { UseCookies = true, CookieContainer = _Cookies, AllowAutoRedirect = true };
                _ControlClient = new HttpClient(ClientHandler);
            }
        }

        public async Task<bool> UpdateUrl(string URL_ID, string NewURL, string Path)
        {
            var UPDLinkResponse = await _ControlClient.PostAsync("http://gg.gg/update", new FormUrlEncodedContent(UpdDataForm(URL_ID, NewURL, Path)));
            return UPDLinkResponse.IsSuccessStatusCode;
        }

        public async Task URLS_update()
        {
            if (_Links.Count > 0)
                _Links.Clear();
            var UPDResponse = await _ControlClient.GetAsync("http://gg.gg/links");
            var HtmlContent = await UPDResponse.Content.ReadAsStringAsync();
            if (UPDResponse.IsSuccessStatusCode && HtmlContent.Contains("Logout"))
            {
                MatchCollection ShortUrlMatches = new Regex(_ShortUrlSearchPattern).Matches(HtmlContent);
                MatchCollection IDUrlMatches = new Regex(_UrlIDSearchPattern).Matches(HtmlContent);
                MatchCollection CountersMatches = new Regex(_CounterOfUrlsPattern).Matches(HtmlContent);
                for (int i = 0; i < ShortUrlMatches.Count; i++)
                {
                    _Links.Add(new Link()
                    {
                        ShortedURL = ShortUrlMatches[i].Groups[1].Value,
                        LinkID = Convert.ToInt32(IDUrlMatches[i].Groups[1].Value),
                        CountOfTransitions = Convert.ToInt32(CountersMatches[i].Groups[1].Value)
                    });
                }
            }
        }

        private Dictionary<string, string> DataForm(string login, string password)
        {
            return new Dictionary<string, string>()
            {
                {"identity", login},
                {"password", password },
                {"submit", "Login" }
            };
        }

        private Dictionary<string, string> UpdDataForm(string URL_ID, string NewURL, string Path)
        {
            return new Dictionary<string, string>()
            {
                {"custom_path", Path },
                {"long_url", NewURL },
                {"link_id", URL_ID }
            };
        }

        private async Task SaveLogPass(string login, string pass)
        {
            Properties.Settings.Default.UserLogin = login;
            Properties.Settings.Default.UserPassword = pass;
            Properties.Settings.Default.Save();
        }
    }
}
