namespace GestionPharmacie.Management.LaboratoriesManagement
{
    partial class CRUD_Labo
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
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phonenumberLabel;
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phonenumberTextBox = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            adressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phonenumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adressLabel.ForeColor = System.Drawing.SystemColors.Control;
            adressLabel.Location = new System.Drawing.Point(277, 114);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(50, 15);
            adressLabel.TabIndex = 1;
            adressLabel.Text = "Adress:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(370, 109);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(170, 20);
            this.adressTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            emailLabel.Location = new System.Drawing.Point(277, 140);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 15);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(370, 135);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(170, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(277, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(42, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(370, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // phonenumberLabel
            // 
            phonenumberLabel.AutoSize = true;
            phonenumberLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phonenumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            phonenumberLabel.Location = new System.Drawing.Point(277, 166);
            phonenumberLabel.Name = "phonenumberLabel";
            phonenumberLabel.Size = new System.Drawing.Size(87, 15);
            phonenumberLabel.TabIndex = 9;
            phonenumberLabel.Text = "Phonenumber:";
            // 
            // phonenumberTextBox
            // 
            this.phonenumberTextBox.Location = new System.Drawing.Point(370, 161);
            this.phonenumberTextBox.Name = "phonenumberTextBox";
            this.phonenumberTextBox.Size = new System.Drawing.Size(170, 20);
            this.phonenumberTextBox.TabIndex = 10;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(30, 62);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(190, 139);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(87, 207);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 12;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnnuler.Location = new System.Drawing.Point(301, 402);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(318, 50);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Cancel";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btSave
            // 
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSave.Location = new System.Drawing.Point(-3, 402);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(318, 50);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // CRUD_Labo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(621, 455);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.logo);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phonenumberLabel);
            this.Controls.Add(this.phonenumberTextBox);
            this.Name = "CRUD_Labo";
            this.Text = "CRUD_Labo";
            this.Load += new System.EventHandler(this.CRUD_Labo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phonenumberTextBox;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btSave;
    }
}