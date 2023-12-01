
namespace ApplicationWindowsForm
{
    partial class FrmPlaylist
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
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.btnVersDroiteUn = new System.Windows.Forms.Button();
            this.btnVersDroiteTous = new System.Windows.Forms.Button();
            this.btnVersGaucheUn = new System.Windows.Forms.Button();
            this.btnVersGaucheTous = new System.Windows.Forms.Button();
            this.btnJouerExtraits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(22, 52);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(177, 316);
            this.lstGauche.TabIndex = 0;
            this.lstGauche.SelectedIndexChanged += new System.EventHandler(this.lstGauche_SelectedIndexChanged);
            // 
            // lstDroite
            // 
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(330, 52);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(177, 277);
            this.lstDroite.TabIndex = 1;
            this.lstDroite.SelectedIndexChanged += new System.EventHandler(this.lstDroite_SelectedIndexChanged);
            // 
            // btnVersDroiteUn
            // 
            this.btnVersDroiteUn.Location = new System.Drawing.Point(231, 52);
            this.btnVersDroiteUn.Name = "btnVersDroiteUn";
            this.btnVersDroiteUn.Size = new System.Drawing.Size(75, 23);
            this.btnVersDroiteUn.TabIndex = 2;
            this.btnVersDroiteUn.Text = "> Un";
            this.btnVersDroiteUn.UseVisualStyleBackColor = true;
            // 
            // btnVersDroiteTous
            // 
            this.btnVersDroiteTous.Location = new System.Drawing.Point(231, 94);
            this.btnVersDroiteTous.Name = "btnVersDroiteTous";
            this.btnVersDroiteTous.Size = new System.Drawing.Size(75, 23);
            this.btnVersDroiteTous.TabIndex = 3;
            this.btnVersDroiteTous.Text = ">> Tous";
            this.btnVersDroiteTous.UseVisualStyleBackColor = true;
            // 
            // btnVersGaucheUn
            // 
            this.btnVersGaucheUn.Location = new System.Drawing.Point(231, 237);
            this.btnVersGaucheUn.Name = "btnVersGaucheUn";
            this.btnVersGaucheUn.Size = new System.Drawing.Size(75, 23);
            this.btnVersGaucheUn.TabIndex = 4;
            this.btnVersGaucheUn.Text = "< Un";
            this.btnVersGaucheUn.UseVisualStyleBackColor = true;
            // 
            // btnVersGaucheTous
            // 
            this.btnVersGaucheTous.Location = new System.Drawing.Point(231, 286);
            this.btnVersGaucheTous.Name = "btnVersGaucheTous";
            this.btnVersGaucheTous.Size = new System.Drawing.Size(75, 23);
            this.btnVersGaucheTous.TabIndex = 5;
            this.btnVersGaucheTous.Text = "<< Tous";
            this.btnVersGaucheTous.UseVisualStyleBackColor = true;
            // 
            // btnJouerExtraits
            // 
            this.btnJouerExtraits.Location = new System.Drawing.Point(330, 345);
            this.btnJouerExtraits.Name = "btnJouerExtraits";
            this.btnJouerExtraits.Size = new System.Drawing.Size(177, 23);
            this.btnJouerExtraits.TabIndex = 6;
            this.btnJouerExtraits.Text = "Jouer les extraits...";
            this.btnJouerExtraits.UseVisualStyleBackColor = true;
            this.btnJouerExtraits.Click += new System.EventHandler(this.btnJouerExtraits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Morceaux de l\'album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Morceaux choisis (playlist)";
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJouerExtraits);
            this.Controls.Add(this.btnVersGaucheTous);
            this.Controls.Add(this.btnVersGaucheUn);
            this.Controls.Add(this.btnVersDroiteTous);
            this.Controls.Add(this.btnVersDroiteUn);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Name = "FrmPlaylist";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Button btnVersDroiteUn;
        private System.Windows.Forms.Button btnVersDroiteTous;
        private System.Windows.Forms.Button btnVersGaucheUn;
        private System.Windows.Forms.Button btnVersGaucheTous;
        private System.Windows.Forms.Button btnJouerExtraits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox lstGauche;
    }
}