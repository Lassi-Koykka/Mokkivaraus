namespace Mokkivaraus
{
    partial class LisaaPalveluitaForm
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
            this.dgVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
            this.lblLisaaPalveluita = new System.Windows.Forms.Label();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPalveluLkm = new System.Windows.Forms.TextBox();
            this.lblPalveluLkm = new System.Windows.Forms.Label();
            this.lblVarauksenPalvelu = new System.Windows.Forms.Label();
            this.cbVarausPalvelu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVarauksenPalvelut)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVarauksenPalvelut
            // 
            this.dgVarauksenPalvelut.AllowUserToAddRows = false;
            this.dgVarauksenPalvelut.AllowUserToDeleteRows = false;
            this.dgVarauksenPalvelut.AllowUserToResizeColumns = false;
            this.dgVarauksenPalvelut.AllowUserToResizeRows = false;
            this.dgVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVarauksenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVarauksenPalvelut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgVarauksenPalvelut.Location = new System.Drawing.Point(329, 28);
            this.dgVarauksenPalvelut.Margin = new System.Windows.Forms.Padding(4);
            this.dgVarauksenPalvelut.MultiSelect = false;
            this.dgVarauksenPalvelut.Name = "dgVarauksenPalvelut";
            this.dgVarauksenPalvelut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgVarauksenPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVarauksenPalvelut.Size = new System.Drawing.Size(458, 337);
            this.dgVarauksenPalvelut.TabIndex = 19;
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(13, 285);
            this.btnLisaaPalvelu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(297, 36);
            this.btnLisaaPalvelu.TabIndex = 35;
            this.btnLisaaPalvelu.Text = "Lisää palvelu";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelu.Click += new System.EventHandler(this.btnLisaaPalvelu_Click);
            // 
            // lblLisaaPalveluita
            // 
            this.lblLisaaPalveluita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLisaaPalveluita.Location = new System.Drawing.Point(7, 28);
            this.lblLisaaPalveluita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLisaaPalveluita.Name = "lblLisaaPalveluita";
            this.lblLisaaPalveluita.Size = new System.Drawing.Size(295, 76);
            this.lblLisaaPalveluita.TabIndex = 36;
            this.lblLisaaPalveluita.Text = "Lisää palveluita ";
            this.lblLisaaPalveluita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(13, 329);
            this.btnPoistaPalvelu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(297, 36);
            this.btnPoistaPalvelu.TabIndex = 37;
            this.btnPoistaPalvelu.Text = "Poista palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtPalveluLkm);
            this.panel1.Controls.Add(this.lblPalveluLkm);
            this.panel1.Controls.Add(this.lblVarauksenPalvelu);
            this.panel1.Controls.Add(this.cbVarausPalvelu);
            this.panel1.Location = new System.Drawing.Point(4, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 148);
            this.panel1.TabIndex = 39;
            // 
            // txtPalveluLkm
            // 
            this.txtPalveluLkm.Location = new System.Drawing.Point(9, 86);
            this.txtPalveluLkm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalveluLkm.Name = "txtPalveluLkm";
            this.txtPalveluLkm.Size = new System.Drawing.Size(289, 22);
            this.txtPalveluLkm.TabIndex = 5;
            this.txtPalveluLkm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostinroAs_KeyPress);
            // 
            // lblPalveluLkm
            // 
            this.lblPalveluLkm.AutoSize = true;
            this.lblPalveluLkm.Location = new System.Drawing.Point(15, 66);
            this.lblPalveluLkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalveluLkm.Name = "lblPalveluLkm";
            this.lblPalveluLkm.Size = new System.Drawing.Size(126, 16);
            this.lblPalveluLkm.TabIndex = 4;
            this.lblPalveluLkm.Text = "Palvelun lukumäärä";
            // 
            // lblVarauksenPalvelu
            // 
            this.lblVarauksenPalvelu.AutoSize = true;
            this.lblVarauksenPalvelu.Location = new System.Drawing.Point(15, 17);
            this.lblVarauksenPalvelu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVarauksenPalvelu.Name = "lblVarauksenPalvelu";
            this.lblVarauksenPalvelu.Size = new System.Drawing.Size(53, 16);
            this.lblVarauksenPalvelu.TabIndex = 3;
            this.lblVarauksenPalvelu.Text = "Palvelu";
            // 
            // cbVarausPalvelu
            // 
            this.cbVarausPalvelu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarausPalvelu.FormattingEnabled = true;
            this.cbVarausPalvelu.Location = new System.Drawing.Point(12, 37);
            this.cbVarausPalvelu.Margin = new System.Windows.Forms.Padding(4);
            this.cbVarausPalvelu.Name = "cbVarausPalvelu";
            this.cbVarausPalvelu.Size = new System.Drawing.Size(286, 24);
            this.cbVarausPalvelu.Sorted = true;
            this.cbVarausPalvelu.TabIndex = 1;
            // 
            // LisaaPalveluitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPoistaPalvelu);
            this.Controls.Add(this.lblLisaaPalveluita);
            this.Controls.Add(this.btnLisaaPalvelu);
            this.Controls.Add(this.dgVarauksenPalvelut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LisaaPalveluitaForm";
            this.Text = "LisaaPalveluitaForm";
            this.Load += new System.EventHandler(this.LisaaPalveluitaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVarauksenPalvelut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVarauksenPalvelut;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPalveluLkm;
        private System.Windows.Forms.Label lblVarauksenPalvelu;
        private System.Windows.Forms.ComboBox cbVarausPalvelu;
        private System.Windows.Forms.TextBox txtPalveluLkm;
        public System.Windows.Forms.Label lblLisaaPalveluita;
    }
}