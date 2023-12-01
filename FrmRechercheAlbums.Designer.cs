
namespace ApplicationWindowsForm
{
    partial class FrmRechercheAlbums
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheAlbums));
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.picArtisteAlbum = new System.Windows.Forms.PictureBox();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.wmpLecteur2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblAlbumNom = new System.Windows.Forms.Label();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.nomAlbum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlbumRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picArtisteAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAlbums
            // 
            this.lstAlbums.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(26, 59);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(236, 147);
            this.lstAlbums.TabIndex = 4;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(26, 236);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(236, 108);
            this.lstTitres.TabIndex = 5;
            this.lstTitres.Click += new System.EventHandler(this.lstTitres_Click);
            // 
            // picArtisteAlbum
            // 
            this.picArtisteAlbum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picArtisteAlbum.Location = new System.Drawing.Point(470, 106);
            this.picArtisteAlbum.Name = "picArtisteAlbum";
            this.picArtisteAlbum.Size = new System.Drawing.Size(92, 91);
            this.picArtisteAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtisteAlbum.TabIndex = 6;
            this.picArtisteAlbum.TabStop = false;
            // 
            // picArtiste
            // 
            this.picArtiste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picArtiste.Location = new System.Drawing.Point(578, 124);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(57, 73);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 7;
            this.picArtiste.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnEcouterExtraits);
            this.groupBox1.Controls.Add(this.wmpLecteur2);
            this.groupBox1.Controls.Add(this.lblAlbumNom);
            this.groupBox1.Controls.Add(this.lklDeezerLien);
            this.groupBox1.Controls.Add(this.lblArtisteNom);
            this.groupBox1.Controls.Add(this.nomAlbum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picArtiste);
            this.groupBox1.Controls.Add(this.lstTitres);
            this.groupBox1.Controls.Add(this.picArtisteAlbum);
            this.groupBox1.Controls.Add(this.lstAlbums);
            this.groupBox1.Location = new System.Drawing.Point(21, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 358);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations DEEZER";
            this.groupBox1.Visible = false;
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEcouterExtraits.Location = new System.Drawing.Point(273, 236);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(462, 23);
            this.btnEcouterExtraits.TabIndex = 15;
            this.btnEcouterExtraits.Text = "&Ecouter tous es extraits musicaux";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // wmpLecteur2
            // 
            this.wmpLecteur2.Enabled = true;
            this.wmpLecteur2.Location = new System.Drawing.Point(273, 265);
            this.wmpLecteur2.Name = "wmpLecteur2";
            this.wmpLecteur2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur2.OcxState")));
            this.wmpLecteur2.Size = new System.Drawing.Size(462, 43);
            this.wmpLecteur2.TabIndex = 14;
            // 
            // lblAlbumNom
            // 
            this.lblAlbumNom.AutoSize = true;
            this.lblAlbumNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumNom.Location = new System.Drawing.Point(467, 84);
            this.lblAlbumNom.Name = "lblAlbumNom";
            this.lblAlbumNom.Size = new System.Drawing.Size(72, 13);
            this.lblAlbumNom.TabIndex = 13;
            this.lblAlbumNom.Text = "NOM ALBUM";
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(470, 200);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(70, 13);
            this.lklDeezerLien.TabIndex = 12;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "lien DEEZER";
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(576, 106);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(32, 13);
            this.lblArtisteNom.TabIndex = 11;
            this.lblArtisteNom.Text = "NOM";
            // 
            // nomAlbum
            // 
            this.nomAlbum.AutoSize = true;
            this.nomAlbum.Location = new System.Drawing.Point(470, 71);
            this.nomAlbum.Name = "nomAlbum";
            this.nomAlbum.Size = new System.Drawing.Size(0, 13);
            this.nomAlbum.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Titres de l\'album :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Albums trouvés :";
            // 
            // txtAlbumRecherche
            // 
            this.txtAlbumRecherche.Location = new System.Drawing.Point(160, 28);
            this.txtAlbumRecherche.Name = "txtAlbumRecherche";
            this.txtAlbumRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtAlbumRecherche.TabIndex = 9;
            this.txtAlbumRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlbumRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(276, 27);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(37, 20);
            this.btnRechercher.TabIndex = 10;
            this.btnRechercher.Text = "Go !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Album recherché";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMessage.Location = new System.Drawing.Point(157, 64);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erp.ContainerControl = this;
            // 
            // FrmRechercheAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtAlbumRecherche);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmRechercheAlbums";
            this.Text = "Recherche d\'Albums";
            this.Load += new System.EventHandler(this.FrmRechercheAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArtisteAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAlbums;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.PictureBox picArtisteAlbum;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlbumRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label nomAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblAlbumNom;
        public AxWMPLib.AxWindowsMediaPlayer wmpLecteur2;
        private System.Windows.Forms.Button btnEcouterExtraits;
    }
}