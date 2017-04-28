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

namespace GestionPharmacie.Management.LaboratoriesManagement
{
    public partial class Labos_GRID : Form
    {
        public LabosServices Labos = new LabosServices();
        public Labos_GRID() {
            InitializeComponent();
            this.Refrech();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e) {
            var query = from L in Labos.LabsList() where L.Name.Contains(txtRecherche.Text) select L;
            LabosGrid.Rows.Clear();
            LabosGrid.DataSource = query.ToList();
        }

        private void LabosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //Delete
            int id = Convert.ToInt32(LabosGrid.Rows[e.RowIndex].Cells["labIDDataGridViewTextBoxColumn"].Value);
            Laboratory L = Labos.FindExisted(0);
            if (e.ColumnIndex == LabosGrid.Columns["Remove"].Index && e.RowIndex > 0) {
                if (DialogResult.Yes == MessageBox.Show("Are You sure..!", "Deleting Medicament", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {

                    Labos.Delete(L.LabID);
                    this.Refrech();
                }

            }
            //Edite
            if (e.ColumnIndex == LabosGrid.Columns["Edit"].Index && e.RowIndex > 0) {
                CRUD_Labo form = new CRUD_Labo() {
                    IsUpdate = true,
                    Labos = Labos
                };
                form.Current(L);
                form.ShowDialog();
                this.Refrech();
            }
        }

        private void Refrech() {
            txtRecherche.Clear();
            LabosGrid.DataSource = Labos.LabsList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CRUD_Labo form = new CRUD_Labo();
            form.ShowDialog();
            this.Refrech();
        }
    }
}
