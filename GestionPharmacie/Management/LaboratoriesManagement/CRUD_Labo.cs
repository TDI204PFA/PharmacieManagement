using GestionPharmacie.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie.Management.LaboratoriesManagement
{
    public partial class CRUD_Labo : Form
    {
        public int LaboId { get; set; }
        public bool IsUpdate = false;
        public LaboratoriesManagement.LabosServices Labos { get; set; }
        public CRUD_Labo()
        {
            InitializeComponent();
        }

        private void CRUD_Labo_Load(object sender, EventArgs e)
        {

        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select an Image.  
            OpenFileDialog imageFile = new OpenFileDialog() {
                Filter = "Picture|*.jpg",
                Title = "Select an image File"
            };

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .JPG file was selected, open it.  
            if (imageFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the Image in the Stream to the Form's PictureBox property.  
                this.logo.Image = new Bitmap(imageFile.FileName);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Laboratory Labo = new Laboratory()
            {
                Name = nameTextBox.Text,
                Adress = adressTextBox.Text,
                Phonenumber = phonenumberTextBox.Text,
                Email = emailTextBox.Text,
                Pic = imageToByteArray(this.logo.Image)
            };

            if (IsUpdate)
            {
                Labo.LabID = LaboId;
                if (Labos.Update(Labo))
                {
                    MessageBox.Show($"Laboratory {Labo.Name} Has been updated with succes");
                }
                else
                    MessageBox.Show("Some thing is Wrong!!");
            }
            else
            {
                if (Labos.Add(Labo))
                {
                    MessageBox.Show("Laboratory has been added with succes");
                    IsUpdate = true;
                }
                else
                    MessageBox.Show("Some thing is Wrong!!");
            }
        }


        private byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void Current(Laboratory labo) {
            LaboId = labo.LabID;
            nameTextBox.Text = labo.Name;
            adressTextBox.Text = labo.Adress;
            phonenumberTextBox.Text = labo.Phonenumber;
            emailTextBox.Text = labo.Email;
            logo.Image = byteArrayToImage(labo.Pic);
        }

        private void btnAnnuler_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
