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
    public partial class FrmRechercheAlbums : Form
    {
        #region champs
        private Artist selectedArtist = new Artist();
        private Album selectedAlbum = new Album();
        private Track selectedTrack = new Track();
        Artist selectedArtistDetails = new Artist();
        private const string MESSAGE_SAISIE_ALBUM = "Veuillez saisir un album à rechercher";
        #endregion
        public FrmRechercheAlbums()
        {
            InitializeComponent();
        }

        private void FrmRechercheAlbums_Load(object sender, EventArgs e)
        {

        }

        private void txtAlbumRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (txtAlbumRecherche.Text == string.Empty)
            {
                erp.SetError(txtAlbumRecherche, MESSAGE_SAISIE_ALBUM);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = "Recherche en cours, veuillez patienter...";
                lblMessage.Refresh();
                rechercherArtistes();
            }
        }

        private void rechercherArtistes()
        {
            #region connecté

            List<Album> lesAlbums = new List<Album>();
            List<Track> lesTracks = new List<Track>();
            string recherche = txtAlbumRecherche.Text;
            lesAlbums = DeezerApi.getAllAlbumsByName(recherche);

            if (lesAlbums.Count == 0)
            {
                erp.SetError(txtAlbumRecherche, string.Empty);
                txtAlbumRecherche.Text = string.Empty;
                lblMessage.Text = "Désolé, l'album '" + recherche + "' est inconnu sur Deezer ...";
            }
            else
            {
                groupBox1.Visible = true;
                erp.SetError(txtAlbumRecherche, string.Empty);
                txtAlbumRecherche.Text = string.Empty;
                lblMessage.Text = string.Empty;
                lstAlbums.DataSource = lesAlbums;
                lstAlbums.DisplayMember = "Album";
            }
            #endregion
        }

        private void lstAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {      
                selectedAlbum = (Album)lstAlbums.SelectedItem;
                selectedAlbum = DeezerApi.getDetailsAlbumById(selectedAlbum.id);
                lstTitres.DataSource = DeezerApi.getAllTracksByAlbum(selectedAlbum);
                lstTitres.DisplayMember = "name";
                selectedArtist = selectedAlbum.theArtist;


                //Affichage des informations dans les contrôles associés
                lblArtisteNom.Text = selectedArtist.name;
                lblAlbumNom.Text = selectedAlbum.title;
                lklDeezerLien.Text = selectedAlbum.link;

                // picture
                picArtisteAlbum.ImageLocation = selectedAlbum.cover;
                picArtiste.ImageLocation = selectedArtist.picture;
            }
            catch
            {

            }
        }

        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {
            Artist selectedArtistDetails = new Artist();
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);
            if (selectedArtistDetails.nbAlbums == 0)
            {
                lblMessage.Text = "Désolé, les extraits pour '" + selectedArtist.name + "' ne sont pas " +
                "disponibles...";
                erp.SetError(btnEcouterExtraits, " ");
            }
            else
            {
                lblMessage.Text = string.Empty;
                FrmLecteurMutlimedia formulaire = new FrmLecteurMutlimedia();

                List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();

                foreach (Album unAlbum in lesAlbums)
                {
                    List<Track> lesTracks = unAlbum.getLesTracks();

                    foreach (Track unTrack in lesTracks)
                    {
                        //On lit chaque titre de chaque Album de l'artiste
                        WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                    }
                }

                formulaire.Show();

                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }

        private void lstTitres_Click(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstTitres.SelectedItem;
            wmpLecteur2.URL = selectedTrack.preview;
        }
    }
}