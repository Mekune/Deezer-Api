using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWindowsForm
{
    public partial class FrmaPropos : Form
    {
        public FrmaPropos()
        {
            InitializeComponent();
        }

        private void FrmaPropos_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
