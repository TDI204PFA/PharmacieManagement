using GestionPharmacie.Management.MedicamentsManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPharmacie.Entities;

namespace GestionPharmacie.Management.OrdersManagment
{
    public partial class Order_CRUD : Form
    {
        public OrdersServices Orders = new OrdersServices();
        public MedsServices Meds = new MedsServices();
        public Parameters Parameters { get; set; }
        public bool IsUpdate = false;
        public int OrdersId { get; set; }
        public Order_CRUD() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Order O = new Order() {
                ExtraInfo = ExtraInfo.Text,
                CreationDate = DateTime.Now,
                OrderDate = OrderDate.Value,
                PaymentDeadline = DeadLineTime.Value,
                Amount = Convert.ToDouble(Price.Text),
                Etat="Not Arrived"
            };
            if (UrgentCheck.Checked)
                O.Urgent = true;
            foreach(DataGridViewRow Row in MedsGrid.Rows) {
                O.Meds.Add(Meds.FindExisted(Convert.ToInt32(Row.Cells["MedID"].Value)));
            }
            
            

            if (IsUpdate) {
                O.NumCmd = OrdersId;
                if (Orders.Update(O)) {
                    MessageBox.Show($"the Order {O.NumCmd} Has been updated with succes");
                } else
                    MessageBox.Show("Some thing is Wrong!!");
            } else {
                if (Orders.Add(O)) {
                    MessageBox.Show("Order has been added with succes");
                    IsUpdate = true;
                } else
                    MessageBox.Show("Some thing is Wrong!!");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Medicaments_GRID form = new Medicaments_GRID();
            form.btnaddorder.Visible = true;
            form.Parameters = Parameters;
            form.ShowDialog();
           // MedsGrid.DataSource = Parameters.LM;
        }
    }
}
