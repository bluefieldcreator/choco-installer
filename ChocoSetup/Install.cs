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
    public partial class Install : UserControl
    {
        public Install()
        {
            InitializeComponent();
        }

        public Form1 mainform;
        private void Install_Load(object sender, EventArgs e)
        {
            mainform = new Form1();
            this.Visible = false;
            mainform = new Form1();
            mainform.ShowTerms();
        }
    }
}
