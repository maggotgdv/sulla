using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHS
{
    public partial class AsigEnfermera : Form
    {
        string cama, enfermera;
        public AsigEnfermera(string cam,string enf)
        {
            InitializeComponent();
            cama=cam;
            enfermera=enf;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
