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
    public partial class CRUD_Provider : Form {
        public int ProviderId { get; set; }
        public bool IsUpdate = false;
        public ProviderServices Providers = new ProviderServices();
        public CRUD_Provider() {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Provider Provider = new Provider() {
                Name = nameTextBox.Text,
                Adress = adressTextBox.Text,
                Phonenumber = phonenumberTextBox.Text,
                Email = emailTextBox.Text
            };

            if (IsUpdate) {
                Provider.ProviderID = ProviderId;
                if (Providers.Update(Provider)) {
                    MessageBox.Show($"the Provider {Provider.Name} Has been updated with succes");
                } else
                    MessageBox.Show("Some thing is Wrong!!");
            } else {
                if (Providers.Add(Provider)) {
                    MessageBox.Show("Provider has been added with succes");
                    IsUpdate = true;
                } else
                    MessageBox.Show("Some thing is Wrong!!");
            }
        }

        public void Current(Provider provider) {
            ProviderId = provider.ProviderID;
            nameTextBox.Text = provider.Name;
            adressTextBox.Text = provider.Adress;
            phonenumberTextBox.Text = provider.Phonenumber;
            emailTextBox.Text = provider.Email;
            
        }
    }
}
