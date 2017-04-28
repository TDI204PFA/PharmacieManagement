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

namespace GestionPharmacie.Management.MedicamentsManagement
{
    public partial class CRUD_Medicament : Form
    {
        public int MedId { get; set; }
        public bool IsUpdate = false;
        public MedsServices Meds = new MedsServices();
        public LaboratoriesManagement.LabosServices Labos = new LaboratoriesManagement.LabosServices();
        public ProviderManagment.ProviderServices Providers = new ProviderManagment.ProviderServices();
        public CRUD_Medicament()
        {
            InitializeComponent();
            this.Labo.DataSource = Labos.LabsList();
            this.Provider.DataSource = Providers.ProvidersList();
        }

        private void CRUD_Medicament_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Medicament Med = new Medicament()
            {
                Description = descriptionTextBox.Text,
                ClassTherap = Classtherap.Text,
                Price = Convert.ToDouble(priceTextBox.Text),
                Family = Family.Text,
                Form = Form.Text,
                Qte = (double)Qte.Value,
                Provider = Providers.FindExisted(Convert.ToInt32(Provider.SelectedValue)),
                Labo = Labos.FindExisted(Convert.ToInt32(Labo.SelectedValue))
            };
            if (IsUpdate)
            {
                Med.MedID = MedId;
                if (Meds.Update(Med))
                {
                    MessageBox.Show($"Medicament {Med.Description} Has been updated with succes");
                }
                else
                    MessageBox.Show("Some thing is Wrong!!");
            }
            else
            {
                if (Meds.Add(Med))
                {
                    MessageBox.Show("Medicament has been added with succes");
                    IsUpdate = true;
                }
                else
                    MessageBox.Show("Some thing is Wrong!!");
            }
        }
        private void ClearChamps()
        {
            descriptionTextBox.Clear();
            Classtherap.SelectedIndex = -1;
            priceTextBox.Clear();
            Family.SelectedIndex = -1;
            Form.SelectedIndex = -1;
            Qte.Value = 0;
            Provider.SelectedIndex = -1;
            Labo.SelectedIndex = -1;
        }

        public void Current(Medicament med)
        {
            MedId = med.MedID;
            descriptionTextBox.Text = med.Description;
            Classtherap.Text = med.ClassTherap;
            priceTextBox.Text = med.Price.ToString();
            Family.Text = med.Family;
            Form.Text = med.Form;
            Qte.Value = (decimal)med.Qte;
            Provider.SelectedItem = med.Provider;
            Labo.SelectedItem = med.Labo;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
