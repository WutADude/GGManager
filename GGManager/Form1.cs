using GGManager.Helpers;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGManager
{
    public partial class MainForm : Form
    {
        public RequestsControl _Requests = new RequestsControl();
        public ClipboardManager _Clipboard = new ClipboardManager();


        public MainForm()
        {
            InitializeComponent();
            _Requests._MForm = this;
            _Clipboard._MForm = this;
            LoginTB.Text = Properties.Settings.Default.UserLogin;
            PassTB.Text = Properties.Settings.Default.UserPassword;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _Requests.LoginOnGG(LoginTB.Text, PassTB.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://lolz.guru/wdude/");
        }

        public async Task FormTitleUPD()
        {
            while (true)
            {
                foreach (string AniChar in new string[] { "—", @"\", "|", "/" })
                {
                    this.Text = $"GGManager {AniChar}";
                    await Task.Delay(110);
                }
            }
        }

        public async Task DoSomeAnimation()
        {
            new Thread(delegate ()
            {
                while (MainGB.Height != 10)
                {
                    MainGB.Height--;
                    Thread.Sleep(1);
                }
                MainGB.Visible = false;
            }).Start();
            new Thread(delegate ()
            {
                while (this.Height != 73)
                {
                    this.Height--;
                    Thread.Sleep(10);
                }
            }).Start();
        }
    }
}
