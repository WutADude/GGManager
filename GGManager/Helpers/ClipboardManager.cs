using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGManager.Helpers
{
    public class ClipboardManager
    {
        public MainForm _MForm;
        string SeenString = ""; // Строка, которую уже видел, чтобы не вызывать повторное срабатывание

        List<string> _URLPatterns = new List<string>() // Список паттернов ссылок файлообменников (Регулярки также для лохов [RequestsControll 20-23 строки: Видимо я лох (9((9])
        {
            "https://mega.nz/file/", "https://www.mediafire.com/file/"
        };

        public async Task ClipBoardMonitor() //  (WinApi для лохов, такая реализация - это для гениев!)
        {
            while (true)
            {
                string CText = Clipboard.GetText();
                if (CText != SeenString)
                {
                    SeenString = CText;
                    if (IsFShareLink(CText))
                    {
                        await _MForm._Requests.URLS_update();
                        ManageForm NewManageForm = new ManageForm() {_MForm = _MForm};
                        NewManageForm.UrlUPDStatusLabel.Text = CText;
                        foreach (var Link in _MForm._Requests._Links)
                            NewManageForm.UrlsGridView.Rows.Add(Link.LinkID, Link.ShortedURL, Link.CountOfTransitions);
                        NewManageForm.Show();
                    }
                }
                else
                    await Task.Delay(700);
            }
        }

        private bool IsFShareLink(string Text)
        {
            foreach (string URL in _URLPatterns)
                if (Text.StartsWith(URL))
                    return true;
            return false;
        }
    }
}
