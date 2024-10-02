using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoSetup
{
    public partial class InstallForm : Form
    {
        public InstallForm()
        {
            InitializeComponent();
        }

        private void InstallForm_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Hide();

        }

        private void InstallForm_Shown(object sender, EventArgs e)
        {
            //quality programming bro.
            Thread.Sleep(1000);
            progressBar1.Value = 10;
            WebClient wc = new WebClient();
            progressBar1.Value = 30;
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            progressBar1.Value = 50;
            string downloadLink = wc.DownloadString("https://pastebin.com/raw/uY7QgFDd");
            progressBar1.Value = 70;
            wc.DownloadFile(downloadLink, appData + "\\Brick Hill\\Player.exe");
            progressBar1.Value = 100;
            MessageBox.Show("Choco Client has succesfully been installed!", "Installation completed!");
            Application.Exit();
        }
    }
}
