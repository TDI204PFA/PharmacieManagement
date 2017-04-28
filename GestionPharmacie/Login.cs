using GestionPharmacie.Management;
using GestionPharmacie.Management.MedicamentsManagement;
using GestionPharmacie.Management.OrdersManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class Login : Form
    {
        public OrdersServices os { get; set; }
        public MedsServices Meds { get; set; }
        public Parameters Parameters { get; set; }
        public Model_GestionPharmacie Db { get; set; }
        public Login()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var user = from u in Db.Users where (u.UserName == Username.Text && u.PassWord == Password.Text) select u;
            if (user != null)
            {
                Orders form = new Orders() {
                    Meds=Meds,
                    os=os
                };
                Parameters.MainForm.PageLoad(form);
                Parameters.MainForm.flowLayoutPanel1.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
            
        }
    }
}
