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

namespace GestionPharmacie.Management.ProviderManagment
{
    public partial class Providers_GRID : Form
    {
        public ProviderServices Providers = new ProviderServices();
        public Providers_GRID() {
            InitializeComponent();
            this.Refrech();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e) {
            var query = from P in Providers.ProvidersList() where P.Name.Contains(txtRecherche.Text) select P;
            ProvidersGrid.DataSource = query.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CRUD_Provider form = new CRUD_Provider {
                Providers = Providers
            };
            form.ShowDialog();
            this.Refrech();
        }

        private void Refrech() {
            txtRecherche.Clear();
            ProvidersGrid.DataSource = Providers.ProvidersList();
        }

        private void ProvidersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Delete
            int id = Convert.ToInt32(ProvidersGrid.Rows[e.RowIndex].Cells["providerIDDataGridViewTextBoxColumn"].Value);
            Provider P = Providers.FindExisted(id);
            if (e.ColumnIndex == ProvidersGrid.Columns["Remove"].Index && e.RowIndex > 0) {
                if (DialogResult.Yes == MessageBox.Show("Are You sure..!", "Deleting Medicament", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {

                    Providers.Delete(P.ProviderID);
                    this.Refrech();
                }

            }
            //Edite
            if (e.ColumnIndex == ProvidersGrid.Columns["Edit"].Index && e.RowIndex > 0) {
                CRUD_Provider form = new CRUD_Provider() {
                    IsUpdate = true,
                    Providers = Providers
                };
                form.Current(P);
                form.ShowDialog();
                this.Refrech();
            }
        }
    }
}
