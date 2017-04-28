namespace GestionPharmacie.Management.MedicamentsManagement
{
    partial class CRUD_Medicament
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
            System.Windows.Forms.Label classTherapLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label familyLabel;
            System.Windows.Forms.Label formLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label qteLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.Qte = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.Classtherap = new System.Windows.Forms.ComboBox();
            this.Form = new System.Windows.Forms.ComboBox();
            this.Family = new System.Windows.Forms.ComboBox();
            this.Labo = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Provider = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            classTherapLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            familyLabel = new System.Windows.Forms.Label();
            formLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            qteLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classTherapLabel
            // 
            classTherapLabel.AutoSize = true;
            classTherapLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            classTherapLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            classTherapLabel.Location = new System.Drawing.Point(126, 73);
            classTherapLabel.Name = "classTherapLabel";
            classTherapLabel.Size = new System.Drawing.Size(118, 23);
            classTherapLabel.TabIndex = 1;
            classTherapLabel.Text = "Class Therap:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            descriptionLabel.Location = new System.Drawing.Point(126, 99);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(103, 23);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            familyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            familyLabel.Location = new System.Drawing.Point(126, 125);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new System.Drawing.Size(65, 23);
            familyLabel.TabIndex = 5;
            familyLabel.Text = "Family:";
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            formLabel.Location = new System.Drawing.Point(126, 151);
            formLabel.Name = "formLabel";
            formLabel.Size = new System.Drawing.Size(55, 23);
            formLabel.TabIndex = 7;
            formLabel.Text = "Form:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            priceLabel.Location = new System.Drawing.Point(126, 177);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(55, 23);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // qteLabel
            // 
            qteLabel.AutoSize = true;
            qteLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            qteLabel.Location = new System.Drawing.Point(126, 203);
            qteLabel.Name = "qteLabel";
            qteLabel.Size = new System.Drawing.Size(48, 23);
            qteLabel.TabIndex = 13;
            qteLabel.Text = "Qte:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(133, 261);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 23);
            label1.TabIndex = 22;
            label1.Text = "Provider:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(126, 229);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 23);
            label2.TabIndex = 23;
            label2.Text = "Laboratory:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(249, 96);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(180, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(249, 174);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(180, 20);
            this.priceTextBox.TabIndex = 12;
            // 
            // Qte
            // 
            this.Qte.Location = new System.Drawing.Point(249, 201);
            this.Qte.Name = "Qte";
            this.Qte.Size = new System.Drawing.Size(133, 20);
            this.Qte.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(-1, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(318, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnnuler.Location = new System.Drawing.Point(321, 365);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(318, 50);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Cancel";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Classtherap
            // 
            this.Classtherap.FormattingEnabled = true;
            this.Classtherap.Items.AddRange(new object[] {
            "Nedded",
            "Not Nedded"});
            this.Classtherap.Location = new System.Drawing.Point(250, 69);
            this.Classtherap.Name = "Classtherap";
            this.Classtherap.Size = new System.Drawing.Size(179, 21);
            this.Classtherap.TabIndex = 17;
            // 
            // Form
            // 
            this.Form.FormattingEnabled = true;
            this.Form.Items.AddRange(new object[] {
            "Pills",
            "Sirop",
            "Comprime"});
            this.Form.Location = new System.Drawing.Point(250, 147);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(179, 21);
            this.Form.TabIndex = 18;
            // 
            // Family
            // 
            this.Family.FormattingEnabled = true;
            this.Family.Items.AddRange(new object[] {
            "Macrolide",
            "Antalgiques opioïdes",
            "Antiulcéreux"});
            this.Family.Location = new System.Drawing.Point(249, 121);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(180, 21);
            this.Family.TabIndex = 19;
            // 
            // Labo
            // 
            this.Labo.DataSource = this.providerBindingSource;
            this.Labo.DisplayMember = "Name";
            this.Labo.FormattingEnabled = true;
            this.Labo.Location = new System.Drawing.Point(249, 229);
            this.Labo.Name = "Labo";
            this.Labo.Size = new System.Drawing.Size(179, 21);
            this.Labo.TabIndex = 20;
            this.Labo.ValueMember = "ProviderID";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(GestionPharmacie.Entities.Provider);
            // 
            // Provider
            // 
            this.Provider.DataSource = this.providerBindingSource;
            this.Provider.DisplayMember = "Name";
            this.Provider.FormattingEnabled = true;
            this.Provider.Location = new System.Drawing.Point(249, 261);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(179, 21);
            this.Provider.TabIndex = 21;
            this.Provider.ValueMember = "ProviderID";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(GestionPharmacie.Entities.User);
            // 
            // laboratoryBindingSource
            // 
            this.laboratoryBindingSource.DataSource = typeof(GestionPharmacie.Entities.Laboratory);
            // 
            // CRUD_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(638, 414);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.Provider);
            this.Controls.Add(this.Labo);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.Classtherap);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Qte);
            this.Controls.Add(classTherapLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(familyLabel);
            this.Controls.Add(formLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(qteLabel);
            this.Name = "CRUD_Medicament";
            this.Text = "CRUD_Medicament";
            this.Load += new System.EventHandler(this.CRUD_Medicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.NumericUpDown Qte;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox Classtherap;
        private System.Windows.Forms.ComboBox Form;
        private System.Windows.Forms.ComboBox Family;
        private System.Windows.Forms.ComboBox Labo;
        private System.Windows.Forms.ComboBox Provider;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource laboratoryBindingSource;
    }
}