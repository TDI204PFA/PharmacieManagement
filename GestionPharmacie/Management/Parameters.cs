using GestionPharmacie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie.Management
{
    public class Parameters
    {

        public MainLayout MainForm { get; set; }
        FlowLayoutPanel sidePanel { get; set; }
        public int ScreenSize_Width { get; }
        public int ScreenSize_Height { get; }
        public List<Medicament> LM { get; set; }
        public Parameters(MainLayout form) {
            MainForm = form;
            ScreenSize_Height = MainForm.MainPanel.Bounds.Size.Height;
            ScreenSize_Width = MainForm.MainPanel.Bounds.Size.Width;
        }

    }
}
