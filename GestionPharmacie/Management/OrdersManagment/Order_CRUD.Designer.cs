namespace GestionPharmacie.Management.OrdersManagment
{
    partial class Order_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MedsGrid = new System.Windows.Forms.DataGridView();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTherapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.DeadLineTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.UrgentCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtraInfo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProviderCB = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedsGrid
            // 
            this.MedsGrid.AllowUserToAddRows = false;
            this.MedsGrid.AutoGenerateColumns = false;
            this.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.classTherapDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn,
            this.laboDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.Remove});
            this.MedsGrid.DataSource = this.medicamentBindingSource;
            this.MedsGrid.Location = new System.Drawing.Point(107, 229);
            this.MedsGrid.Name = "MedsGrid";
            this.MedsGrid.Size = new System.Drawing.Size(945, 293);
            this.MedsGrid.TabIndex = 15;
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "MedID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "MedID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            this.medIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // formDataGridViewTextBoxColumn
            // 
            this.formDataGridViewTextBoxColumn.DataPropertyName = "Form";
            this.formDataGridViewTextBoxColumn.HeaderText = "Form";
            this.formDataGridViewTextBoxColumn.Name = "formDataGridViewTextBoxColumn";
            // 
            // classTherapDataGridViewTextBoxColumn
            // 
            this.classTherapDataGridViewTextBoxColumn.DataPropertyName = "ClassTherap";
            this.classTherapDataGridViewTextBoxColumn.HeaderText = "ClassTherap";
            this.classTherapDataGridViewTextBoxColumn.Name = "classTherapDataGridViewTextBoxColumn";
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
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = global::GestionPharmacie.Properties.Resources.remove_icon_32_32;
            this.Remove.Name = "Remove";
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataSource = typeof(GestionPharmacie.Entities.Medicament);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::GestionPharmacie.Properties.Resources.Edit_icon_32_32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Remove";
            this.dataGridViewImageColumn2.Image = global::GestionPharmacie.Properties.Resources.remove_icon_32_32;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::GestionPharmacie.Properties.Resources.add_icon_32_32;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(941, 540);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Order Date : ";
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(182, 28);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(200, 20);
            this.OrderDate.TabIndex = 18;
            // 
            // DeadLineTime
            // 
            this.DeadLineTime.Location = new System.Drawing.Point(182, 85);
            this.DeadLineTime.Name = "DeadLineTime";
            this.DeadLineTime.Size = new System.Drawing.Size(200, 20);
            this.DeadLineTime.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "DeadLine :";
            // 
            // UrgentCheck
            // 
            this.UrgentCheck.AutoSize = true;
            this.UrgentCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrgentCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.UrgentCheck.Location = new System.Drawing.Point(754, 27);
            this.UrgentCheck.Name = "UrgentCheck";
            this.UrgentCheck.Size = new System.Drawing.Size(74, 23);
            this.UrgentCheck.TabIndex = 21;
            this.UrgentCheck.Text = "Urgent";
            this.UrgentCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(655, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Extra Info :";
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.Location = new System.Drawing.Point(754, 88);
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.Size = new System.Drawing.Size(298, 96);
            this.ExtraInfo.TabIndex = 23;
            this.ExtraInfo.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(60, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Provider :";
            // 
            // ProviderCB
            // 
            this.ProviderCB.DataSource = this.providerBindingSource;
            this.ProviderCB.DisplayMember = "Name";
            this.ProviderCB.FormattingEnabled = true;
            this.ProviderCB.Location = new System.Drawing.Point(182, 138);
            this.ProviderCB.Name = "ProviderCB";
            this.ProviderCB.Size = new System.Drawing.Size(121, 21);
            this.ProviderCB.TabIndex = 25;
            this.ProviderCB.ValueMember = "ProviderID";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(GestionPharmacie.Entities.Provider);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(60, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price :";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.Control;
            this.Price.Location = new System.Drawing.Point(178, 190);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(45, 19);
            this.Price.TabIndex = 27;
            this.Price.Text = "0 DH";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnnuler.Location = new System.Drawing.Point(339, 579);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(240, 50);
            this.btnAnnuler.TabIndex = 29;
            this.btnAnnuler.Text = "Cancel";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(12, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 50);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Order_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1101, 641);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProviderCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExtraInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UrgentCheck);
            this.Controls.Add(this.DeadLineTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.MedsGrid);
            this.Name = "Order_CRUD";
            this.Text = "Order_CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.MedsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView MedsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTherapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker OrderDate;
        private System.Windows.Forms.DateTimePicker DeadLineTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UrgentCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ExtraInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProviderCB;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSave;
    }
}