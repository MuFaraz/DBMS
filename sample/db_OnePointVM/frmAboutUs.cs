using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_OnePointVM
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
            this.ActiveControl = btnOK;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
