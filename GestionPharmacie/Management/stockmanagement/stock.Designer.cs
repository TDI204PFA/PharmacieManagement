namespace GestionPharmacie.Management.stockmanagement
{
    partial class stock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ordersNotArrived = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MedsEmpty = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NotInStock = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StockInformation = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ordersNotArrived);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders not arrived Yet";
            // 
            // ordersNotArrived
            // 
            this.ordersNotArrived.FormattingEnabled = true;
            this.ordersNotArrived.ItemHeight = 16;
            this.ordersNotArrived.Location = new System.Drawing.Point(6, 21);
            this.ordersNotArrived.Name = "ordersNotArrived";
            this.ordersNotArrived.Size = new System.Drawing.Size(266, 116);
            this.ordersNotArrived.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MedsEmpty);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicament insufficient";
            // 
            // MedsEmpty
            // 
            this.MedsEmpty.FormattingEnabled = true;
            this.MedsEmpty.ItemHeight = 16;
            this.MedsEmpty.Location = new System.Drawing.Point(6, 21);
            this.MedsEmpty.Name = "MedsEmpty";
            this.MedsEmpty.Size = new System.Drawing.Size(315, 116);
            this.MedsEmpty.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NotInStock);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not In Stock";
            // 
            // NotInStock
            // 
            this.NotInStock.FormattingEnabled = true;
            this.NotInStock.ItemHeight = 16;
            this.NotInStock.Location = new System.Drawing.Point(6, 19);
            this.NotInStock.Name = "NotInStock";
            this.NotInStock.Size = new System.Drawing.Size(278, 84);
            this.NotInStock.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StockInformation);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(452, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "stock information:";
            // 
            // StockInformation
            // 
            this.StockInformation.FormattingEnabled = true;
            this.StockInformation.ItemHeight = 16;
            this.StockInformation.Location = new System.Drawing.Point(12, 21);
            this.StockInformation.Name = "StockInformation";
            this.StockInformation.Size = new System.Drawing.Size(315, 84);
            this.StockInformation.TabIndex = 0;
            this.StockInformation.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(802, 421);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "stock";
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ordersNotArrived;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox MedsEmpty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox NotInStock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox StockInformation;
    }
}