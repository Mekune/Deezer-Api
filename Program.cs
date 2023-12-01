using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;

namespace ApplicationWindowsForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDemarrage());


            #region exo
            //int i = 0;
            //Artist theArtist = DeezerApi.getFirstArtistByName("stomae");
            //List<Album> premierAlbum = DeezerApi.getAllAlbumsByArtist(theArtist);

            //while (i < 3)
            //{
            //    Album theAlbum = premierAlbum[i];
            //    List<Track> lesTracks = DeezerApi.getAllTracksByAlbum(theAlbum);
            //    Console.WriteLine("Album n° "+ (i+1));
            //    foreach (Track unTrack in lesTracks)
            //    {
            //        Console.WriteLine(unTrack.link);
            //    }
            //    i = i + 1;
            //}



            #endregion

            #region Tests sur le parcours de colelction 
            //List<Artist> lesArtistes = new List<Artist>();
            //DeezerApi.discoComplete = true;
            //lesArtistes = DeezerApi.getAllArtistsByName("bob");
            //int i = 1;

            //foreach (Artist unartiste in lesArtistes)
            //{

            //    Console.WriteLine(i + " " + unartiste.name);
            //    i++;
            //}
            #endregion

            #region divers
            //ou bien


            //int i = 0;

            //while (i <= lesArtistes.Count - 1 )
            //{
            //    Console.WriteLine(lesArtistes[i].name);
            //    i++;
            //}

            // ou bien


            //int i;

            //for (i = 0; i <= lesArtistes.Count - 1;i++)
            //{
            //    Console.WriteLine(lesArtistes[i].name);
            //}
            #endregion

            #region TestDeMethodes

            //if (!NetManager.isConnected())
            //{
            //    #region déconnecté
            //    MessageBox.Show("non connecté");
            //    #endregion
            //}
            //else
            //{
            //    #region connecté
            //    Artist monArtist = new Artist();
            //    string recherche = txtArtisteRecherche.Text;
            //    monArtist = DeezerApi.getFirstArtistByName(recherche);
            //    if (monArtist == null)
            //    {
            //        Console.WriteLine("Désolé, L'artiste ' " + recherche + " ' rechercher n'existe pas", 
            //            "Zik'nCo :  avertissement", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        lblArtisteNom.Text = monArtist.name;
            //    }
            //    #endregion
            //}
            #endregion

        }
    }
}
// f10 = débogage pas à pas
// f5 = débogage normal / arrêt
// f11 = dégogabe pas à pas détaillé