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

namespace GestionPharmacie.Management.MedicamentsManagement
{
    public partial class Medicaments_GRID : Form
    {
       public Model_GestionPharmacie db_Homme { get; set; }
       public MedsServices Meds = new MedsServices();
       public Parameters Parameters { get; set; }
        public Medicaments_GRID()
        {
            
            InitializeComponent();
            this.Refrech();
            
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e) {
            MedsGrid.Rows.Clear();
            var query = from med in Meds.MedsList() where med.Description.Contains(txtRecherche.Text) select med;
            MedsGrid.DataSource = query.ToList();
        }

        private void Refrech() {
            //MedsGrid.Rows.Clear();
            MedsGrid.DataSource = Meds.MedsList();
            txtRecherche.Clear();
        }

        private void MedsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Delete
            int id = Convert.ToInt32(MedsGrid.Rows[e.RowIndex].Cells["MedID"].Value);
            Medicament med = Meds.FindExisted(id);
            if (e.ColumnIndex == MedsGrid.Columns["Remove"].Index && e.RowIndex > 0) {
                if (DialogResult.Yes == MessageBox.Show("Are You sure..!", "Deleting Medicament", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                    
                    Meds.Delete(med.MedID);
                    this.Refrech();
                }

            }
            //Edite
            if (e.ColumnIndex == MedsGrid.Columns["Edit"].Index && e.RowIndex > 0) {
                CRUD_Medicament form = new CRUD_Medicament() {
                    IsUpdate = true,
                    Meds = Meds
                };
                form.Current(med);
                form.ShowDialog();
                this.Refrech();
            }
        }

        private void btnaddorder_Click(object sender, EventArgs e) {
            Parameters.LM.Add((Medicament)medicamentBindingSource.Current);
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CRUD_Medicament form = new CRUD_Medicament() {
                Meds = Meds
            };
            form.ShowDialog();
            this.Refrech();
        }
    }
}
