
namespace ApplicationWindowsForm
{
    partial class FrmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoverFlow));
            this.iC3DAlbums = new CDI.IndexCard3D.IC3D();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iC3DAlbums
            // 
            this.iC3DAlbums.DisplayCards = 8;
            this.iC3DAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iC3DAlbums.Location = new System.Drawing.Point(0, -100);
            this.iC3DAlbums.Name = "iC3DAlbums";
            this.iC3DAlbums.Size = new System.Drawing.Size(587, 390);
            this.iC3DAlbums.TabIndex = 0;
            this.iC3DAlbums.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.iC3DAlbums_RenderText);
            this.iC3DAlbums.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.iC3DAlbums_IndexCardChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 297);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(33, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Location = new System.Drawing.Point(530, 297);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(41, 13);
            this.lblXsurY.TabIndex = 2;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.MouseHover += new System.EventHandler(this.lblXsurY_MouseHover);
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(0, 318);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(590, 45);
            this.wmpLecteur.TabIndex = 3;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(15, 17);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(109, 251);
            this.lstTitres.TabIndex = 4;
            this.lstTitres.Click += new System.EventHandler(this.lstTitres_Click);
            this.lstTitres.MouseLeave += new System.EventHandler(this.lstTitres_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titres de l\'Album";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTitres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(448, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 292);
            this.panel1.TabIndex = 6;
            // 
            // FrmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.iC3DAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoverFlow";
            this.Text = "ZiK\'nCo : Affichage \"Cover Flow\"";
            this.Load += new System.EventHandler(this.FrmCoverFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDI.IndexCard3D.IC3D iC3DAlbums;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblXsurY;
        public AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}