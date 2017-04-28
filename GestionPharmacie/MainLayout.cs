using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionPharmacie.Management;
using GestionPharmacie.Management.MedicamentsManagement;
using GestionPharmacie.Management.OrdersManagment;
using GestionPharmacie.Management.LaboratoriesManagement;
using GestionPharmacie.Management.ProviderManagment;

namespace GestionPharmacie
{
    public partial class MainLayout : Form
    {
        //Initialiwation the object to share across the programme
        Model_GestionPharmacie Db_Homme = new Model_GestionPharmacie();
        Parameters Parameters { get; set; }
        


        public MainLayout()
        {
            InitializeComponent();
            
            this.Visible = false;
            //Fullscrean & no border
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new Point(0, 0);
            this.Size = SystemInformation.PrimaryMonitorSize;
            //Initialise Login Form and send it to MainForm
            Parameters = new Parameters(this);
            Login form2 = new Login() {
                Parameters = Parameters,
                Db = Db_Homme,
            };
            this.PageLoad(form2);
            Parameters.MainForm = this;

        }


        public void PageLoad(Form form)
        {

            MainPanel.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = false;
            MainPanel.Controls.Add(form);
            form.Show();
            int Form_x = (Parameters.ScreenSize_Width - form.Bounds.Width) / 2;
            int Form_y = (Parameters.ScreenSize_Height - form.Bounds.Height) / 2;
            form.Location = new Point(Form_x, Form_y);

            MainPanel.Dock = DockStyle.Fill;
            WindowState = FormWindowState.Normal;

            //this.flowLayoutPanel1.Visible = true;

            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_Meds_Click(object sender, EventArgs e) {
            Medicaments_GRID form = new Medicaments_GRID {
                Parameters = Parameters
            };
            PageLoad(form);
        }

        private void bt_Orders_Click(object sender, EventArgs e) {
            Orders form = new Orders();
            PageLoad(form);
        }

        private void bt_Provider_Click(object sender, EventArgs e) {
            Providers_GRID form = new Providers_GRID();
            PageLoad(form);
        }

        private void bt_Labo_Click(object sender, EventArgs e) {
            Labos_GRID form = new Labos_GRID();
            PageLoad(form);
        }
    }
}
