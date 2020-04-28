namespace Mokkivaraus
{
    partial class Aloitussivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aloitussivu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnToimipisteet = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnLaskutus = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Freestyle Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(164, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 94);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Village People Oy \r\nMökkivarausjärjestelmä";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToimipisteet
            // 
            this.btnToimipisteet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToimipisteet.BackColor = System.Drawing.Color.Firebrick;
            this.btnToimipisteet.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnToimipisteet.FlatAppearance.BorderSize = 3;
            this.btnToimipisteet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnToimipisteet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToimipisteet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToimipisteet.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToimipisteet.ForeColor = System.Drawing.Color.White;
            this.btnToimipisteet.Location = new System.Drawing.Point(181, 240);
            this.btnToimipisteet.Name = "btnToimipisteet";
            this.btnToimipisteet.Size = new System.Drawing.Size(230, 45);
            this.btnToimipisteet.TabIndex = 1;
            this.btnToimipisteet.Text = "Toimipistehallinta";
            this.btnToimipisteet.UseVisualStyleBackColor = false;
            this.btnToimipisteet.Click += new System.EventHandler(this.btnToimipiste_Click);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVaraukset.BackColor = System.Drawing.Color.Firebrick;
            this.btnVaraukset.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnVaraukset.FlatAppearance.BorderSize = 3;
            this.btnVaraukset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVaraukset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaraukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaraukset.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraukset.ForeColor = System.Drawing.Color.White;
            this.btnVaraukset.Location = new System.Drawing.Point(181, 342);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(230, 45);
            this.btnVaraukset.TabIndex = 1;
            this.btnVaraukset.Text = "Varaushallinta";
            this.btnVaraukset.UseVisualStyleBackColor = false;
            this.btnVaraukset.Click += new System.EventHandler(this.btnToimipiste_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsiakkaat.BackColor = System.Drawing.Color.Firebrick;
            this.btnAsiakkaat.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAsiakkaat.FlatAppearance.BorderSize = 3;
            this.btnAsiakkaat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAsiakkaat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsiakkaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiakkaat.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.ForeColor = System.Drawing.Color.White;
            this.btnAsiakkaat.Location = new System.Drawing.Point(181, 291);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(230, 45);
            this.btnAsiakkaat.TabIndex = 1;
            this.btnAsiakkaat.Text = "Asiakashallinta";
            this.btnAsiakkaat.UseVisualStyleBackColor = false;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnToimipiste_Click);
            // 
            // btnLaskutus
            // 
            this.btnLaskutus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLaskutus.BackColor = System.Drawing.Color.Firebrick;
            this.btnLaskutus.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnLaskutus.FlatAppearance.BorderSize = 3;
            this.btnLaskutus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLaskutus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaskutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaskutus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskutus.ForeColor = System.Drawing.Color.White;
            this.btnLaskutus.Location = new System.Drawing.Point(181, 393);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Size = new System.Drawing.Size(230, 45);
            this.btnLaskutus.TabIndex = 1;
            this.btnLaskutus.Text = "Laskutus";
            this.btnLaskutus.UseVisualStyleBackColor = false;
            this.btnLaskutus.Click += new System.EventHandler(this.btnToimipiste_Click);
            // 
            // pboxLogo
            // 
            this.pboxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxLogo.Image = global::Mokkivaraus.Properties.Resources.logo;
            this.pboxLogo.Location = new System.Drawing.Point(228, 106);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(135, 128);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            // 
            // Aloitussivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.btnLaskutus);
            this.Controls.Add(this.btnAsiakkaat);
            this.Controls.Add(this.btnVaraukset);
            this.Controls.Add(this.btnToimipisteet);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Aloitussivu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village People Oy Mökkivarausjärjestelmä";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnToimipisteet;
        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnLaskutus;
        private System.Windows.Forms.PictureBox pboxLogo;
    }
}

