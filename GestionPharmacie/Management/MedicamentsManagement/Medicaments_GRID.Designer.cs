namespace GestionPharmacie.Management.MedicamentsManagement
{
    partial class Medicaments_GRID
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
            this.MedsGrid = new System.Windows.Forms.DataGridView();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnaddorder = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MedsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedsGrid
            // 
            this.MedsGrid.AllowUserToAddRows = false;
            this.MedsGrid.AutoGenerateColumns = false;
            this.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.descriptionDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn,
            this.laboDataGridViewTextBoxColumn,
            this.MedID,
            this.Remove});
            this.MedsGrid.DataSource = this.medicamentBindingSource;
            this.MedsGrid.Location = new System.Drawing.Point(50, 90);
            this.MedsGrid.Name = "MedsGrid";
            this.MedsGrid.Size = new System.Drawing.Size(744, 293);
            this.MedsGrid.TabIndex = 3;
            this.MedsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedsGrid_CellContentClick);
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataSource = typeof(GestionPharmacie.Entities.Medicament);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::GestionPharmacie.Properties.Resources.add_icon_32_32;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(617, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnaddorder
            // 
            this.btnaddorder.FlatAppearance.BorderSize = 0;
            this.btnaddorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddorder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddorder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaddorder.Location = new System.Drawing.Point(124, 414);
            this.btnaddorder.Name = "btnaddorder";
            this.btnaddorder.Size = new System.Drawing.Size(134, 64);
            this.btnaddorder.TabIndex = 7;
            this.btnaddorder.Text = "Ajouter Commande";
            this.btnaddorder.UseVisualStyleBackColor = true;
            this.btnaddorder.Visible = false;
            this.btnaddorder.Click += new System.EventHandler(this.btnaddorder_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(113, 52);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(163, 20);
            this.txtRecherche.TabIndex = 8;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::GestionPharmacie.Properties.Resources.Edit_icon_32_32;
            this.Edit.Name = "Edit";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // formDataGridViewTextBoxColumn
            // 
            this.formDataGridViewTextBoxColumn.DataPropertyName = "Form";
            this.formDataGridViewTextBoxColumn.HeaderText = "Form";
            this.formDataGridViewTextBoxColumn.Name = "formDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            // 
            // laboDataGridViewTextBoxColumn
            // 
            this.laboDataGridViewTextBoxColumn.DataPropertyName = "Labo";
            this.laboDataGridViewTextBoxColumn.HeaderText = "Labo";
            this.laboDataGridViewTextBoxColumn.Name = "laboDataGridViewTextBoxColumn";
            // 
            // MedID
            // 
            this.MedID.DataPropertyName = "MedID";
            this.MedID.HeaderText = "Column1";
            this.MedID.Name = "MedID";
            this.MedID.Visible = false;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = global::GestionPharmacie.Properties.Resources.remove_icon_32_32;
            this.Remove.Name = "Remove";
            // 
            // Medicaments_GRID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(909, 506);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnaddorder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.MedsGrid);
            this.Name = "Medicaments_GRID";
            this.Text = "Formmedicament";
            ((System.ComponentModel.ISupportInitialize)(this.MedsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MedsGrid;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnaddorder;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedID;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
    }
}