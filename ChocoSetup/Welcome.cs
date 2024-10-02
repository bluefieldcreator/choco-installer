using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ChocoSetup
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public Form1 mainform;
        private void Welcome_Load(object sender, EventArgs e)
        {
            //Makes a short for the webclient
            WebClient wc = new WebClient();
            //Downloads string from updated changelog
            string changelog = wc.DownloadString("https://pastebin.com/raw/93yw4fBd");
            //Changes the current textbox with the changelog
            changelogbox.Text = changelog;
        }

        private void ContinueBTN1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainform = new Form1();
            mainform.ShowTerms();
        }

        private void ExitBTN1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changelogbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
