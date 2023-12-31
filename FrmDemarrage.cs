﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NansDiaz.musique;
using Btssio.Deezer;
using System.Diagnostics;
using Btssio.Tools;
using CDI.IndexCard3D;
using System.Net;

namespace CoverFlowDLLPerso
{
    public partial class FrmCoverFlow : Form
    {

        #region champs
        private List<Album> lesAlbums = new List<Album>();
        private List<Track> lesTracks = new List<Track>();
        public Artist selectedArtistDetails = new Artist();

        #endregion

        public FrmCoverFlow()
        {
            InitializeComponent();
        }
        private void chargerTitresSelectedAlbum()
        {
            Album selectedAlbum = lesAlbums.ElementAt(iC3DAlbums.ActiveCard - 1);
            lesTracks = selectedAlbum.getLesTracks();
            wmpLecteur.currentPlaylist.clear();
            int indexTitre = 1;

            foreach (Track unTrack in lesTracks)
            {
                WMPLib.IWMPMedia unMedia = wmpLecteur.newMedia(unTrack.preview);
                wmpLecteur.currentPlaylist.appendItem(unMedia);
                unMedia.setItemInfo("nomTitre", unTrack.title);
                unMedia.setItemInfo("xSurY", indexTitre.ToString());
                indexTitre++;
                lstTitres.DataSource = lesTracks;
            }
            
        }


        private void FrmCoverFlow_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.iC3DAlbums);
            lesAlbums = selectedArtistDetails.getLesAlbums();
            // On utilise un WebClient pour télécharger les images des pochettes d'album
            // (le cover flow ne peut afficher que des images locales)
            // Rmq : La classe WebClient est dans le namespace System.Net (using…)
            WebClient wClient = new WebClient();
            string nomImage;
            int i;
            try
            {
                for (i = 0; i < lesAlbums.Count; i++)
                {
                    nomImage = "image" + i + ".jpg";
                    //Téléchargement de l'image de l'artiste pour affichage dans le cover flow
                    wClient.DownloadFile(lesAlbums[i].cover, nomImage);
                    //Création de la vignette d'album (pochette). Premier paramètre : titre (title)
                    Card c = new Card(lesAlbums[i].title, nomImage);
                    //Ajout au cover flow
                    iC3DAlbums.IndexCards.Add(c);
                }
                iC3DAlbums.IndexCards.LoadTexturesToMemory();
                chargerTitresSelectedAlbum();
            }
            catch
            {
                MessageBox.Show("Pas d'album selectionné");
            }

        }

        private void iC3DAlbums_RenderText(object sender, EventArgs e)
        {
            Font fntNom = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitre = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);
            string titre = iC3DAlbums.IndexCards.ElementAt(iC3DAlbums.ActiveCard - 1).Title;
            // On dessine les textes dans le cover flow (nom de l'artiste et titre de l'album)
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 75, selectedArtistDetails.name,
            IC3D.TextAlignment.Center, fntNom, Color.FloralWhite);
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 45, titre, IC3D.TextAlignment.Center, fntTitre,
            Color.Wheat);

        }

        private void iC3DAlbums_IndexCardChanged(object sender, IndexCardEventArgs e)
        {
            chargerTitresSelectedAlbum();
        }

        private void wmpLecteur_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            lblTitre.Text = wmpLecteur.currentMedia.getItemInfo("nomTitre");
            lblXsurY.Text = (wmpLecteur.currentMedia.getItemInfo("xSurY") + " sur " + lesTracks.Count);
            if (lstTitres.Items.Count > 0)
            {
                lstTitres.SelectedIndex = int.Parse(wmpLecteur.currentMedia.getItemInfo("xSurY"));
            }
        }

        private void lblXsurY_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void lstTitres_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void lstTitres_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia unMedia = wmpLecteur.currentPlaylist.get_Item(lstTitres.SelectedIndex);
            wmpLecteur.Ctlcontrols.playItem(unMedia);
        }
    }
}
