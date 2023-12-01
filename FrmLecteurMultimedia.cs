using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using System.Diagnostics;
using Btssio.Tools;

namespace ApplicationWindowsForm
{
    public partial class FrmLecteurMutlimedia : Form
    {
        public FrmLecteurMutlimedia()
        {
            InitializeComponent();
        }

        public object wmplecteur { get; internal set; }

        private void btnChoisirFichier_Click(object sender, EventArgs e)
        {
            diaMultimedia.ShowDialog();
            wmpLecteur.URL = diaMultimedia.FileName;
        }

        private void FrmLecteurMutlimedia_Load(object sender, EventArgs e)
        {

        }
    }
}
