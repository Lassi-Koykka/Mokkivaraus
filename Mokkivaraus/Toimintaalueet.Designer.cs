namespace Mokkivaraus
{
    partial class Toimintaalueet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.lblToimipisteet = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnNayta = new System.Windows.Forms.Button();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.lblToimialueennimi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtToimialueennimi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgToimipisteet
            // 
            this.dgToimipisteet.AllowUserToAddRows = false;
            this.dgToimipisteet.AllowUserToDeleteRows = false;
            this.dgToimipisteet.AllowUserToResizeColumns = false;
            this.dgToimipisteet.AllowUserToResizeRows = false;
            this.dgToimipisteet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgToimipisteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToimipisteet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgToimipisteet.Location = new System.Drawing.Point(270, 12);
            this.dgToimipisteet.MultiSelect = false;
            this.dgToimipisteet.Name = "dgToimipisteet";
            this.dgToimipisteet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgToimipisteet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgToimipisteet.Size = new System.Drawing.Size(518, 426);
            this.dgToimipisteet.TabIndex = 0;
            // 
            // lblToimipisteet
            // 
            this.lblToimipisteet.AutoSize = true;
            this.lblToimipisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToimipisteet.Location = new System.Drawing.Point(13, 69);
            this.lblToimipisteet.Name = "lblToimipisteet";
            this.lblToimipisteet.Size = new System.Drawing.Size(161, 31);
            this.lblToimipisteet.TabIndex = 1;
            this.lblToimipisteet.Text = "Toimipisteet";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(12, 289);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(123, 51);
            this.btnLisaa.TabIndex = 10;
            this.btnLisaa.Text = "Lisää/Päivitä";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnNayta
            // 
            this.btnNayta.Location = new System.Drawing.Point(141, 289);
            this.btnNayta.Name = "btnNayta";
            this.btnNayta.Size = new System.Drawing.Size(123, 51);
            this.btnNayta.TabIndex = 11;
            this.btnNayta.Text = "Näytä kohteet";
            this.btnNayta.UseVisualStyleBackColor = true;
            this.btnNayta.Click += new System.EventHandler(this.btnNayta_Click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(142, 12);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(122, 38);
            this.btnTakaisin.TabIndex = 12;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // lblToimialueennimi
            // 
            this.lblToimialueennimi.AutoSize = true;
            this.lblToimialueennimi.Location = new System.Drawing.Point(3, 0);
            this.lblToimialueennimi.Name = "lblToimialueennimi";
            this.lblToimialueennimi.Size = new System.Drawing.Size(85, 13);
            this.lblToimialueennimi.TabIndex = 3;
            this.lblToimialueennimi.Text = "Toimialueen nimi";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtToimialueennimi);
            this.panel1.Controls.Add(this.lblToimialueennimi);
            this.panel1.Location = new System.Drawing.Point(19, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 166);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(323, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 166);
            this.panel2.TabIndex = 15;
            // 
            // txtToimialueennimi
            // 
            this.txtToimialueennimi.Location = new System.Drawing.Point(6, 17);
            this.txtToimialueennimi.Name = "txtToimialueennimi";
            this.txtToimialueennimi.Size = new System.Drawing.Size(149, 20);
            this.txtToimialueennimi.TabIndex = 4;
            // 
            // Toimintaalueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.btnNayta);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.lblToimipisteet);
            this.Controls.Add(this.dgToimipisteet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Toimintaalueet";
            this.Text = "Toiminta-alue hallinta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Toimipisteet_FormClosed);
            this.Load += new System.EventHandler(this.Toimintaalueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgToimipisteet;
        private System.Windows.Forms.Label lblToimipisteet;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnNayta;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.Label lblToimialueennimi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtToimialueennimi;
    }
}