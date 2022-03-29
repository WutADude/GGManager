using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGManager
{
    public partial class ManageForm : Form
    {
        public MainForm _MForm;
        public ManageForm()
        {
            InitializeComponent();
        }

        private async void UrlsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (UrlsGridView.SelectedRows.Count > 0)
            {
                string ShortUrl = UrlsGridView.CurrentRow.Cells[1].Value.ToString();
                if (await _MForm._Requests.UpdateUrl(UrlsGridView.CurrentRow.Cells[0].Value.ToString(), Clipboard.GetText(), ShortUrl.Replace("http://gg.gg/", "")))
                {
                    UrlUPDStatusLabel.Text = $"{ShortUrl} - обновлена!";
                    await Task.Delay(2400);
                    this.Close();
                }
                else
                    UrlUPDStatusLabel.Text = $"Не удалось обновить ссылку: {ShortUrl}";
            }
            else
                MessageBox.Show("Выберите хотябы 1 строку!");
            GC.Collect();
        }
    }
}
