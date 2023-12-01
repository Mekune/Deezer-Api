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

    public partial class FrmPlaylist : Form
    {
        #region champs
        private Artist selectedArtist = new Artist();
        private Album selectedAlbum = new Album();
        private Track selectedList = new Track();
        private Track selectedTrack = new Track();
        Artist selectedArtistDetails = new Artist();
        private const string MESSAGE_SAISIE_ALBUM = "Veuillez saisir un album à rechercher";

        #endregion
        public FrmPlaylist()
        {
            InitializeComponent();
            btnVersDroiteUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersDroiteTous.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheTous.Click += new System.EventHandler(boutonsTransfert_Click);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstGauche.SelectedIndex = 0;
        }

        enum ModeTransfert
        {
            Un,
            Tous,
            Certains
        }
        private void transfert(ListBox lstSource, ListBox lstDestination, ModeTransfert mode)
        {

            switch (mode) 
            {
                case ModeTransfert.Un:
                    lstDestination.Items.Add(lstSource.SelectedItem);
                    lstSource.Items.Remove(lstSource.SelectedItem);
                    break;
                case ModeTransfert.Tous:
                    foreach (object element in lstSource.Items)
                    {
                        lstDestination.Items.Add(element);
                    }
                    lstSource.Items.Clear();
                    break;
                case ModeTransfert.Certains:
                    break;
            }

            if (lstDestination.Items.Count > 0)
            {
                lstDestination.SelectedIndex = lstDestination.Items.Count-1;
            }
            if (lstSource.Items.Count > 0)
            {
                lstSource.SelectedIndex = lstSource.Items.Count - 1;
            }
        }

        private void boutonsTransfert_Click(object sender, EventArgs e)
        {
            Button boutonDeclencheur = (Button)(sender);                              

            switch (boutonDeclencheur.Name)
            {
                case "btnVersDroiteUn":
                    transfert(lstGauche, lstDroite, ModeTransfert.Un);
                     break;
                case "btnVersDroiteTous":
                    transfert(lstGauche, lstDroite, ModeTransfert.Tous);
                    break;
                case "btnVersGaucheUn":
                    transfert(lstDroite, lstGauche, ModeTransfert.Un);
                    break;
                case "btnVersGaucheTous":
                    transfert(lstDroite, lstGauche, ModeTransfert.Tous);
                    break;

            }
        }

        private void lstGauche_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;
            btnVersDroiteUn.Enabled = true;
            btnVersDroiteTous.Enabled = true;

            if (lstDroite.Items.Count > 0)
            {
                btnVersGaucheTous.Enabled = true;
            }
        }

        private void lstDroite_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersDroiteUn.Enabled = false;
            btnVersDroiteTous.Enabled = false;
            btnVersGaucheUn.Enabled = true;
            btnVersGaucheTous.Enabled = true;

            if (lstGauche.Items.Count > 0)
            {
                btnVersDroiteTous.Enabled = true;
            }
        }

        private void btnJouerExtraits_Click(object sender, EventArgs e)
        {
            if (lstDroite.Items.Count == 0)
            {
                MessageBox.Show("Aucun titres dans la playlist");
            }
            else
            {
                FrmLecteurMutlimedia formulaire = new FrmLecteurMutlimedia();
                foreach (Track unTrack in lstDroite.Items)
                {
                    //On lit chaque titre de chaque Album de l'artiste
                    WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                    formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                }
                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }
    }
}