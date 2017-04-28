namespace GestionPharmacie.Management.OrdersManagment
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.MedsCB = new System.Windows.Forms.ComboBox();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersDate = new System.Windows.Forms.DateTimePicker();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.numCmdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.Arrived = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MedsCB
            // 
            this.MedsCB.DataSource = this.medicamentBindingSource;
            this.MedsCB.DisplayMember = "Description";
            this.MedsCB.FormattingEnabled = true;
            this.MedsCB.Location = new System.Drawing.Point(299, 25);
            this.MedsCB.Name = "MedsCB";
            this.MedsCB.Size = new System.Drawing.Size(121, 21);
            this.MedsCB.TabIndex = 6;
            this.MedsCB.ValueMember = "MedID";
            this.MedsCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataSource = typeof(GestionPharmacie.Entities.Medicament);
            // 
            // OrdersDate
            // 
            this.OrdersDate.Location = new System.Drawing.Point(24, 25);
            this.OrdersDate.Name = "OrdersDate";
            this.OrdersDate.Size = new System.Drawing.Size(200, 20);
            this.OrdersDate.TabIndex = 7;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(GestionPharmacie.Entities.Order);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::GestionPharmacie.Properties.Resources.add_icon_32_32;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(859, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AllowUserToAddRows = false;
            this.OrdersGrid.AutoGenerateColumns = false;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.numCmdDataGridViewTextBoxColumn,
            this.extraInfoDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.paymentDeadlineDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.urgentDataGridViewCheckBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.Remove,
            this.Arrived});
            this.OrdersGrid.DataSource = this.orderBindingSource;
            this.OrdersGrid.Location = new System.Drawing.Point(24, 79);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(1045, 425);
            this.OrdersGrid.TabIndex = 15;
            this.OrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::GestionPharmacie.Properties.Resources.Edit_icon_32_32;
            this.Edit.Name = "Edit";
            // 
            // numCmdDataGridViewTextBoxColumn
            // 
            this.numCmdDataGridViewTextBoxColumn.DataPropertyName = "NumCmd";
            this.numCmdDataGridViewTextBoxColumn.HeaderText = "NumCmd";
            this.numCmdDataGridViewTextBoxColumn.Name = "numCmdDataGridViewTextBoxColumn";
            this.numCmdDataGridViewTextBoxColumn.Visible = false;
            // 
            // extraInfoDataGridViewTextBoxColumn
            // 
            this.extraInfoDataGridViewTextBoxColumn.DataPropertyName = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.HeaderText = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.Name = "extraInfoDataGridViewTextBoxColumn";
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // paymentDeadlineDataGridViewTextBoxColumn
            // 
            this.paymentDeadlineDataGridViewTextBoxColumn.DataPropertyName = "PaymentDeadline";
            this.paymentDeadlineDataGridViewTextBoxColumn.HeaderText = "PaymentDeadline";
            this.paymentDeadlineDataGridViewTextBoxColumn.Name = "paymentDeadlineDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // urgentDataGridViewCheckBoxColumn
            // 
            this.urgentDataGridViewCheckBoxColumn.DataPropertyName = "Urgent";
            this.urgentDataGridViewCheckBoxColumn.HeaderText = "Urgent";
            this.urgentDataGridViewCheckBoxColumn.Name = "urgentDataGridViewCheckBoxColumn";
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = global::GestionPharmacie.Properties.Resources.remove_icon_32_32;
            this.Remove.Name = "Remove";
            // 
            // Arrived
            // 
            this.Arrived.HeaderText = "Arrived";
            this.Arrived.Image = global::GestionPharmacie.Properties.Resources.data_arrived1600;
            this.Arrived.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Arrived.Name = "Arrived";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1091, 552);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.OrdersDate);
            this.Controls.Add(this.MedsCB);
            this.Name = "Orders";
            this.Text = resources.GetString("$this.Text");
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox MedsCB;
        private System.Windows.Forms.DateTimePicker OrdersDate;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCmdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.DataGridViewImageColumn Arrived;
    }
}