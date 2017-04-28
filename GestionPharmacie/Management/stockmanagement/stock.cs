using GestionPharmacie.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie.Management.stockmanagement
{
    public partial class stock : Form
    {
        OrdersManagment.OrdersServices Orders = new OrdersManagment.OrdersServices();
        MedicamentsManagement.MedsServices Meds = new MedicamentsManagement.MedsServices();
        public stock()
        {
            InitializeComponent();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stock_Load(object sender, EventArgs e) {
            foreach (Order o in Orders.OrdersList()) {
                if (o.Etat=="NotArrived") {
                    ordersNotArrived.Items.Add(o.NumCmd);
                }
                
            }

            foreach(Medicament med in Meds.MedsList()) {
                if (med.Qte == 0) {
                    NotInStock.Items.Add(med.Description + " Labo: " + med.Labo.Name);
                }
                if (med.Qte<10) {
                    MedsEmpty.Items.Add(med.Description + " Labo: " + med.Labo.Name);
                }
            }
        }
    }
}
