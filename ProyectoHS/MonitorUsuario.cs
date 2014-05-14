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
    public partial class MonitorUsuario : Form
    {
        private Subject objSub;
        private Observer obs;
        private Subject objSub2;
        private Observer obs2;
        private Subject objSub3;
        private Observer obs3;
        public MonitorUsuario(Subject _objSub, Subject _objSub2, Subject _objSub3)
        {
            InitializeComponent();
            objSub = _objSub;
            obs = new Observer(this.textBox1);
            objSub.RegisterClient(obs);
            objSub2 = _objSub2;
            obs2 = new Observer(this.textBox2);
            objSub2.RegisterClient(obs2);
            objSub3 = _objSub3;
            obs3 = new Observer(this.textBox3);
            objSub3.RegisterClient(obs3);
        }

        private void MonitorUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
