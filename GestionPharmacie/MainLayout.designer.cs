namespace GestionPharmacie
{
    partial class MainLayout
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LayoutLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Stock = new System.Windows.Forms.Button();
            this.bt_Meds = new System.Windows.Forms.Button();
            this.bt_Orders = new System.Windows.Forms.Button();
            this.bt_Provider = new System.Windows.Forms.Button();
            this.bt_Labo = new System.Windows.Forms.Button();
            this.LayoutNav = new System.Windows.Forms.FlowLayoutPanel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.LayoutNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1093, 533);
            this.MainPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.flowLayoutPanel1.Controls.Add(this.LayoutLogo);
            this.flowLayoutPanel1.Controls.Add(this.bt_Stock);
            this.flowLayoutPanel1.Controls.Add(this.bt_Meds);
            this.flowLayoutPanel1.Controls.Add(this.bt_Orders);
            this.flowLayoutPanel1.Controls.Add(this.bt_Provider);
            this.flowLayoutPanel1.Controls.Add(this.bt_Labo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 533);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Visible = false;
            // 
            // LayoutLogo
            // 
            this.LayoutLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutLogo.Location = new System.Drawing.Point(0, 0);
            this.LayoutLogo.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutLogo.Name = "LayoutLogo";
            this.LayoutLogo.Size = new System.Drawing.Size(152, 85);
            this.LayoutLogo.TabIndex = 0;
            // 
            // bt_Stock
            // 
            this.bt_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Stock.FlatAppearance.BorderSize = 0;
            this.bt_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Stock.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stock.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Stock.Location = new System.Drawing.Point(0, 85);
            this.bt_Stock.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Stock.Name = "bt_Stock";
            this.bt_Stock.Size = new System.Drawing.Size(152, 40);
            this.bt_Stock.TabIndex = 1;
            this.bt_Stock.Text = "Stock";
            this.bt_Stock.UseVisualStyleBackColor = true;
            // 
            // bt_Meds
            // 
            this.bt_Meds.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Meds.FlatAppearance.BorderSize = 0;
            this.bt_Meds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Meds.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Meds.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Meds.Location = new System.Drawing.Point(0, 125);
            this.bt_Meds.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Meds.Name = "bt_Meds";
            this.bt_Meds.Size = new System.Drawing.Size(152, 40);
            this.bt_Meds.TabIndex = 2;
            this.bt_Meds.Text = "Medicament";
            this.bt_Meds.UseVisualStyleBackColor = true;
            this.bt_Meds.Click += new System.EventHandler(this.bt_Meds_Click);
            // 
            // bt_Orders
            // 
            this.bt_Orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Orders.FlatAppearance.BorderSize = 0;
            this.bt_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Orders.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Orders.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Orders.Location = new System.Drawing.Point(0, 165);
            this.bt_Orders.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Orders.Name = "bt_Orders";
            this.bt_Orders.Size = new System.Drawing.Size(152, 40);
            this.bt_Orders.TabIndex = 3;
            this.bt_Orders.Text = "Orders";
            this.bt_Orders.UseVisualStyleBackColor = true;
            this.bt_Orders.Click += new System.EventHandler(this.bt_Orders_Click);
            // 
            // bt_Provider
            // 
            this.bt_Provider.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Provider.FlatAppearance.BorderSize = 0;
            this.bt_Provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Provider.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Provider.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Provider.Location = new System.Drawing.Point(0, 205);
            this.bt_Provider.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Provider.Name = "bt_Provider";
            this.bt_Provider.Size = new System.Drawing.Size(152, 40);
            this.bt_Provider.TabIndex = 4;
            this.bt_Provider.Text = "Provider";
            this.bt_Provider.UseVisualStyleBackColor = true;
            this.bt_Provider.Click += new System.EventHandler(this.bt_Provider_Click);
            // 
            // bt_Labo
            // 
            this.bt_Labo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Labo.FlatAppearance.BorderSize = 0;
            this.bt_Labo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Labo.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Labo.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_Labo.Location = new System.Drawing.Point(0, 245);
            this.bt_Labo.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Labo.Name = "bt_Labo";
            this.bt_Labo.Size = new System.Drawing.Size(152, 40);
            this.bt_Labo.TabIndex = 5;
            this.bt_Labo.Text = "Labos";
            this.bt_Labo.UseVisualStyleBackColor = true;
            this.bt_Labo.Click += new System.EventHandler(this.bt_Labo_Click);
            // 
            // LayoutNav
            // 
            this.LayoutNav.Controls.Add(this.Close);
            this.LayoutNav.Controls.Add(this.Minimize);
            this.LayoutNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutNav.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.LayoutNav.Location = new System.Drawing.Point(152, 0);
            this.LayoutNav.Name = "LayoutNav";
            this.LayoutNav.Size = new System.Drawing.Size(941, 40);
            this.LayoutNav.TabIndex = 2;
            // 
            // Close
            // 
            this.Close.Image = global::GestionPharmacie.Properties.Resources._492459_error_32x32;
            this.Close.Location = new System.Drawing.Point(883, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(55, 37);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Image = global::GestionPharmacie.Properties.Resources.minimize_window_xxl;
            this.Minimize.Location = new System.Drawing.Point(831, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(46, 50);
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 533);
            this.Controls.Add(this.LayoutNav);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainLayout";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.LayoutNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel LayoutNav;
        private System.Windows.Forms.FlowLayoutPanel LayoutLogo;
        private System.Windows.Forms.Button bt_Stock;
        private System.Windows.Forms.Button bt_Meds;
        private System.Windows.Forms.Button bt_Orders;
        private System.Windows.Forms.Button bt_Provider;
        private System.Windows.Forms.Button bt_Labo;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
    }
}

