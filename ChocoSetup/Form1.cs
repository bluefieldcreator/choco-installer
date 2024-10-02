using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // terms1.Hide();
           // install1.Hide();
            welcome1.Show();
            welcome1.BringToFront();
        }
        public void ShowTerms()
        {
            welcome1.Visible = false;
            terms1.Show();
            terms1.BringToFront();
            
        }
        //bullshit programming because ive never worked with usercontrols before k?
        public void ShowInstall()
        {
            terms1.Visible = false;
            install1.Show();
            install1.BringToFront();
        }

        private void welcome1_Load(object sender, EventArgs e)
        {

        }
    }
}
