namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmProfesseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.txtEmailP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecialiteP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelephoneP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenomP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSupprimerP = new System.Windows.Forms.Button();
            this.btnAjouterP = new System.Windows.Forms.Button();
            this.btnModifierP = new System.Windows.Forms.Button();
            this.dgProfesseur = new System.Windows.Forms.DataGridView();
            this.btnSelectionnerP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomP
            // 
            this.txtNomP.Location = new System.Drawing.Point(44, 94);
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(274, 26);
            this.txtNomP.TabIndex = 1;
            this.txtNomP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEmailP
            // 
            this.txtEmailP.Location = new System.Drawing.Point(44, 278);
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.Size = new System.Drawing.Size(274, 26);
            this.txtEmailP.TabIndex = 3;
            this.txtEmailP.TextChanged += new System.EventHandler(this.txtEmailP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spécialité";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSpecialiteP
            // 
            this.txtSpecialiteP.Location = new System.Drawing.Point(44, 462);
            this.txtSpecialiteP.Name = "txtSpecialiteP";
            this.txtSpecialiteP.Size = new System.Drawing.Size(274, 26);
            this.txtSpecialiteP.TabIndex = 5;
            this.txtSpecialiteP.TextChanged += new System.EventHandler(this.txtSpecialiteP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(44, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTelephoneP
            // 
            this.txtTelephoneP.Location = new System.Drawing.Point(44, 370);
            this.txtTelephoneP.Name = "txtTelephoneP";
            this.txtTelephoneP.Size = new System.Drawing.Size(274, 26);
            this.txtTelephoneP.TabIndex = 4;
            this.txtTelephoneP.TextChanged += new System.EventHandler(this.txtTelephoneP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrenomP
            // 
            this.txtPrenomP.Location = new System.Drawing.Point(44, 186);
            this.txtPrenomP.Name = "txtPrenomP";
            this.txtPrenomP.Size = new System.Drawing.Size(274, 26);
            this.txtPrenomP.TabIndex = 2;
            this.txtPrenomP.TextChanged += new System.EventHandler(this.txtPrenomP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(44, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prenom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSupprimerP
            // 
            this.btnSupprimerP.Location = new System.Drawing.Point(383, 411);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(137, 44);
            this.btnSupprimerP.TabIndex = 8;
            this.btnSupprimerP.Text = "&Supprimer";
            this.btnSupprimerP.UseVisualStyleBackColor = true;
            this.btnSupprimerP.Click += new System.EventHandler(this.btnSupprimerP_Click);
            // 
            // btnAjouterP
            // 
            this.btnAjouterP.Location = new System.Drawing.Point(383, 251);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(137, 44);
            this.btnAjouterP.TabIndex = 6;
            this.btnAjouterP.Text = "&Ajouter";
            this.btnAjouterP.UseVisualStyleBackColor = true;
            this.btnAjouterP.Click += new System.EventHandler(this.btnAjouterP_Click);
            // 
            // btnModifierP
            // 
            this.btnModifierP.Location = new System.Drawing.Point(383, 331);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(137, 44);
            this.btnModifierP.TabIndex = 7;
            this.btnModifierP.Text = "&Modifier";
            this.btnModifierP.UseVisualStyleBackColor = true;
            this.btnModifierP.Click += new System.EventHandler(this.btnModifierP_Click);
            // 
            // dgProfesseur
            // 
            this.dgProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesseur.Location = new System.Drawing.Point(561, 30);
            this.dgProfesseur.Name = "dgProfesseur";
            this.dgProfesseur.RowHeadersWidth = 62;
            this.dgProfesseur.RowTemplate.Height = 28;
            this.dgProfesseur.Size = new System.Drawing.Size(598, 527);
            this.dgProfesseur.TabIndex = 13;
            this.dgProfesseur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSelectionnerP
            // 
            this.btnSelectionnerP.Location = new System.Drawing.Point(383, 163);
            this.btnSelectionnerP.Name = "btnSelectionnerP";
            this.btnSelectionnerP.Size = new System.Drawing.Size(134, 42);
            this.btnSelectionnerP.TabIndex = 14;
            this.btnSelectionnerP.Text = "&Selectionner";
            this.btnSelectionnerP.UseVisualStyleBackColor = true;
            this.btnSelectionnerP.Click += new System.EventHandler(this.btnSelectionnerP_Click);
            // 
            // frmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1171, 595);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectionnerP);
            this.Controls.Add(this.dgProfesseur);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterP);
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.txtPrenomP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelephoneP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecialiteP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProfesseur";
            this.Text = "Professeur";
            this.Load += new System.EventHandler(this.frmProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomP;
        private System.Windows.Forms.TextBox txtEmailP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecialiteP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelephoneP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenomP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSupprimerP;
        private System.Windows.Forms.Button btnAjouterP;
        private System.Windows.Forms.Button btnModifierP;
        private System.Windows.Forms.DataGridView dgProfesseur;
        private System.Windows.Forms.Button btnSelectionnerP;
    }
}