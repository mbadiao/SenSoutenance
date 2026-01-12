namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmSession
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
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtTexte = new System.Windows.Forms.Label();
            this.cbxAnneeAcademique = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSession
            // 
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Location = new System.Drawing.Point(352, 145);
            this.dgSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSession.Name = "dgSession";
            this.dgSession.RowHeadersWidth = 62;
            this.dgSession.Size = new System.Drawing.Size(708, 511);
            this.dgSession.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(156, 609);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(156, 531);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 452);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(174, 18);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(144, 35);
            this.BtnSelect.TabIndex = 10;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.AutoSize = true;
            this.txtValeur.Location = new System.Drawing.Point(20, 222);
            this.txtValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(149, 20);
            this.txtValeur.TabIndex = 14;
            this.txtValeur.Text = "Annee Academique";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(24, 134);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(292, 26);
            this.txtSession.TabIndex = 16;
            this.txtSession.TextChanged += new System.EventHandler(this.txtSession_TextChanged);
            // 
            // txtTexte
            // 
            this.txtTexte.AutoSize = true;
            this.txtTexte.Location = new System.Drawing.Point(20, 89);
            this.txtTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTexte.Name = "txtTexte";
            this.txtTexte.Size = new System.Drawing.Size(66, 20);
            this.txtTexte.TabIndex = 13;
            this.txtTexte.Text = "Session";
            // 
            // cbxAnneeAcademique
            // 
            this.cbxAnneeAcademique.FormattingEnabled = true;
            this.cbxAnneeAcademique.ItemHeight = 20;
            this.cbxAnneeAcademique.Location = new System.Drawing.Point(20, 265);
            this.cbxAnneeAcademique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAnneeAcademique.Name = "cbxAnneeAcademique";
            this.cbxAnneeAcademique.Size = new System.Drawing.Size(296, 28);
            this.cbxAnneeAcademique.TabIndex = 15;
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 692);
            this.ControlBox = false;
            this.Controls.Add(this.cbxAnneeAcademique);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.txtTexte);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgSession);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSession";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label txtValeur;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label txtTexte;
        private System.Windows.Forms.ComboBox cbxAnneeAcademique;
    }
}