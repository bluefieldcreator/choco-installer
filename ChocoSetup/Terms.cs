using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoSetup
{
    public partial class Terms : UserControl
    {
        public Terms()
        {
            InitializeComponent();
        }
        public Form1 mainform;
        private void button1_Click(object sender, EventArgs e)
        {
            //Show installation form
            this.Visible = false;
            mainform = new Form1();
            //mainform.ShowInstall();
            InstallForm install = new InstallForm();
            install.Show();
        }

        private void DeclineBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terms of service was declined, Installation aborted.","Installation failed!");
            Application.Exit();
        }
    }
}
