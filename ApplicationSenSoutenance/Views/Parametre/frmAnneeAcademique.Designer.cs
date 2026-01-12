namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmAnneeAcademique
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
            this.dgAnneeAcademique = new System.Windows.Forms.DataGridView();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.txtTexte = new System.Windows.Forms.Label();
            this.txtLibelleAnneeAcademique = new System.Windows.Forms.TextBox();
            this.txtAnneeAcademiqueVal = new System.Windows.Forms.TextBox();
            this.txtValeur = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAnneeAcademique
            // 
            this.dgAnneeAcademique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnneeAcademique.Location = new System.Drawing.Point(344, 123);
            this.dgAnneeAcademique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgAnneeAcademique.Name = "dgAnneeAcademique";
            this.dgAnneeAcademique.RowHeadersWidth = 62;
            this.dgAnneeAcademique.Size = new System.Drawing.Size(632, 531);
            this.dgAnneeAcademique.TabIndex = 0;
            this.dgAnneeAcademique.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnneeAcademique_CellContentClick);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(260, 20);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(144, 35);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtTexte
            // 
            this.txtTexte.AutoSize = true;
            this.txtTexte.Location = new System.Drawing.Point(32, 77);
            this.txtTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTexte.Name = "txtTexte";
            this.txtTexte.Size = new System.Drawing.Size(48, 20);
            this.txtTexte.TabIndex = 2;
            this.txtTexte.Text = "Texte";
            // 
            // txtLibelleAnneeAcademique
            // 
            this.txtLibelleAnneeAcademique.Location = new System.Drawing.Point(32, 123);
            this.txtLibelleAnneeAcademique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLibelleAnneeAcademique.Name = "txtLibelleAnneeAcademique";
            this.txtLibelleAnneeAcademique.Size = new System.Drawing.Size(244, 26);
            this.txtLibelleAnneeAcademique.TabIndex = 1;
            this.txtLibelleAnneeAcademique.TextChanged += new System.EventHandler(this.txtLibelleAnneeAcademique_TextChanged);
            // 
            // txtAnneeAcademiqueVal
            // 
            this.txtAnneeAcademiqueVal.Location = new System.Drawing.Point(32, 254);
            this.txtAnneeAcademiqueVal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnneeAcademiqueVal.Name = "txtAnneeAcademiqueVal";
            this.txtAnneeAcademiqueVal.Size = new System.Drawing.Size(244, 26);
            this.txtAnneeAcademiqueVal.TabIndex = 2;
            // 
            // txtValeur
            // 
            this.txtValeur.AutoSize = true;
            this.txtValeur.Location = new System.Drawing.Point(32, 208);
            this.txtValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(55, 20);
            this.txtValeur.TabIndex = 4;
            this.txtValeur.Text = "Valeur";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 462);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 540);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(141, 618);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 35);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmAnneeAcademique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 692);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAnneeAcademiqueVal);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.txtLibelleAnneeAcademique);
            this.Controls.Add(this.txtTexte);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.dgAnneeAcademique);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAnneeAcademique";
            this.Text = "AnneeAcademique";
            this.Load += new System.EventHandler(this.frmAnneeAcademique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnneeAcademique;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label txtTexte;
        private System.Windows.Forms.TextBox txtLibelleAnneeAcademique;
        private System.Windows.Forms.TextBox txtAnneeAcademiqueVal;
        private System.Windows.Forms.Label txtValeur;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
    }
}