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
    public partial class Orders : Form
    {
        public OrdersServices os = new OrdersServices();
        public MedsServices Meds = new MedsServices();
        public Orders() {
            InitializeComponent();
            this.Refrech();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            Medicament med = (Medicament)medicamentBindingSource.Current;
            var query = from o in os.OrdersList()
                        where o.Meds.Contains(med)
                        select o;
            OrdersGrid.DataSource = query.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Order_CRUD form = new Order_CRUD();
            form.ShowDialog();
            this.Refrech();
        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Delete
            int id = Convert.ToInt32(OrdersGrid.Rows[e.RowIndex].Cells["numCmdDataGridViewTextBoxColumn"].Value);
            Order O = os.FindExisted(id);
            if (e.ColumnIndex == OrdersGrid.Columns["Remove"].Index && e.RowIndex > 0) {
                if (DialogResult.Yes == MessageBox.Show("Are You sure..!", "Deleting Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {

                    os.Delete(O.NumCmd);
                    this.Refrech();
                }

            }
            //Edite
            if (e.ColumnIndex == OrdersGrid.Columns["Edit"].Index && e.RowIndex > 0) {

                this.Refrech();
            }
        }

        private void Refrech() {
            OrdersGrid.DataSource = os.OrdersList();
            var query = from o in os.OrdersList()
                        from med in o.Meds
                        select med;
            MedsCB.DataSource = query.ToList();
            MedsCB.SelectedIndex = -1;
        }
    }
}
