namespace Mokkivaraus
{
    partial class Toimipisteet
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
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.lblToimipisteet = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblToimipisteenNimi = new System.Windows.Forms.Label();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.lblPtpaikka = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgToimipisteet
            // 
            this.dgToimipisteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToimipisteet.Location = new System.Drawing.Point(328, 69);
            this.dgToimipisteet.Name = "dgToimipisteet";
            this.dgToimipisteet.Size = new System.Drawing.Size(460, 314);
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
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 104);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Toimipiste ID";
            // 
            // lblToimipisteenNimi
            // 
            this.lblToimipisteenNimi.AutoSize = true;
            this.lblToimipisteenNimi.Location = new System.Drawing.Point(19, 144);
            this.lblToimipisteenNimi.Name = "lblToimipisteenNimi";
            this.lblToimipisteenNimi.Size = new System.Drawing.Size(87, 13);
            this.lblToimipisteenNimi.TabIndex = 3;
            this.lblToimipisteenNimi.Text = "Toimipisteen nimi";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(19, 183);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lblLahiosoite.TabIndex = 4;
            this.lblLahiosoite.Text = "Lähiosoite";
            // 
            // lblPtpaikka
            // 
            this.lblPtpaikka.AutoSize = true;
            this.lblPtpaikka.Location = new System.Drawing.Point(19, 222);
            this.lblPtpaikka.Name = "lblPtpaikka";
            this.lblPtpaikka.Size = new System.Drawing.Size(83, 13);
            this.lblPtpaikka.TabIndex = 5;
            this.lblPtpaikka.Text = "Postitoimipaikka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(22, 289);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(123, 51);
            this.btnLisaa.TabIndex = 10;
            this.btnLisaa.Text = "Lisää/Päivitä";
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // Toimipisteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPtpaikka);
            this.Controls.Add(this.lblLahiosoite);
            this.Controls.Add(this.lblToimipisteenNimi);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblToimipisteet);
            this.Controls.Add(this.dgToimipisteet);
            this.Name = "Toimipisteet";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgToimipisteet;
        private System.Windows.Forms.Label lblToimipisteet;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblToimipisteenNimi;
        private System.Windows.Forms.Label lblLahiosoite;
        private System.Windows.Forms.Label lblPtpaikka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnLisaa;
    }
}