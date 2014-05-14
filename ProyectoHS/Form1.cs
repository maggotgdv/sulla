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
    public partial class Form1 : Form
    {
        MonitorUsuario Form_MU;
        private Subject objSub;
        private Subject objSub2;
        private Subject objSub3;
        public Form1()
        {
            InitializeComponent();
            objSub = new Subject();
            objSub2 = new Subject();
            objSub3 = new Subject();
        }
        int[] seg ={1,1,1};
        int[] min ={0,0,0};
        //Label[] arraylbl_timer = new Label();
        ServiceReference1.InterfazHSClient clientevideos = new ServiceReference1.InterfazHSClient(); 
        private string cronometrar(int i){
            string minu="", segu="";
            if (seg[i] <= 9) {
                segu = "0"+seg[i].ToString();
            }
            else
                segu = seg[i].ToString();
            if (min[i] <= 9)
            {
                minu = "0" + min[i].ToString();
            }
            else
                minu = min[i].ToString();
            seg[i]++;
            if(seg[i] >59){
                min[i]++;
                seg[i] = 0;
            }
            return minu +":"+ segu;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer1.Text= cronometrar(0);     
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbltimer3.Text = cronometrar(1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltimer2.Text = cronometrar(2);
        }
        private void ReiniciarTimer1(){
            timer1.Stop();
            
            min[0] = 0;
            seg[0] = 1;
        }
        private void ReiniciarTimer2()
        {
            timer2.Stop();
            min[1] = 0;
            seg[1] = 1;
        }
        private void ReiniciarTimer3()
        {       
            timer3.Stop();
            min[2] = 0;
            seg[2] = 1;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                timer1.Start();
                lbl1_1.Visible = true;
                lbl1_2.Visible = true;
                lbltimer1.Visible = true;
                btnatender1.Visible = true;
                objSub.UpdateClient("cama1");
            }
            if (e.KeyCode == Keys.A)
            {
                ReiniciarTimer1();
                lbl1_1.Visible = false;
                lbl1_2.Visible = false;
                lbltimer1.Visible = false;
                btnatender1.Visible = false;
                objSub.UpdateClient("v1");
                
            }
            if (e.KeyCode == Keys.W)
            {
                timer2.Start();
                lbl2_1.Visible = true;
                lbl2_2.Visible = true;
                lbltimer2.Visible = true;
                btnatender2.Visible = true;
                objSub2.UpdateClient("cama2");
            }
            if (e.KeyCode == Keys.S)
            {
                lbl2_1.Visible = false;
                lbl2_2.Visible = false;
                lbltimer2.Visible = false;
                btnatender2.Visible = false;
                ReiniciarTimer2();
                objSub2.UpdateClient("v2");
            }
            if (e.KeyCode == Keys.E)
            {
                timer3.Start();
                lbl3_1.Visible = true;
                lbl3_2.Visible = true;
                lbltimer3.Visible = true;
                btnatender3.Visible = true;
                objSub3.UpdateClient("cama3");
            }
            if (e.KeyCode == Keys.D)
            {
                ReiniciarTimer3();
                lbl3_1.Visible = false;
                lbl3_2.Visible = false;
                lbltimer3.Visible = false;
                btnatender3.Visible = false;
                objSub3.UpdateClient("v3");
            }
        }

        private void asignarEnfermeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cama="", enfermera="";
            AsigEnfermera a = new AsigEnfermera(cama,enfermera);
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtenfermera1.Visible = true;
            ReiniciarTimer1();
            timer1.Start();
            lbl1_2.Text = "Tiempo atendiendo:";
            btnatender1.Visible = false;
            btnfin1.Visible = true;
        }

        private void btnfin1_Click(object sender, EventArgs e)
        {
            clientevideos.GuardarDatos(namec1.Text,lbltimer1.Text, txtenfermera1.Text,"1");
            //Guardar bd
            ReiniciarTimer1();  
        }

        private void btnatender2_Click(object sender, EventArgs e)
        {
            txtenfermera2.Visible = true;
            ReiniciarTimer2();
            timer2.Start();
            lbl2_2.Text = "Tiempo atendiendo:";
            btnatender2.Visible = false;
            btnfin2.Visible = true;
        }

        private void btnfin2_Click(object sender, EventArgs e)
        {
            clientevideos.GuardarDatos(namec2.Text, lbltimer2.Text, txtenfermera2.Text, "2");
            ReiniciarTimer2();
        }

        private void btnatender3_Click(object sender, EventArgs e)
        {
            txtenfermera3.Visible = true;
            ReiniciarTimer3();
            timer3.Start();
            lbl3_2.Text = "Tiempo atendiendo:";
            btnatender3.Visible = false;
            btnfin3.Visible = true;
        }

        private void btnfin3_Click(object sender, EventArgs e)
        {
            clientevideos.GuardarDatos(namec3.Text, lbltimer3.Text, txtenfermera3.Text, "3");
            ReiniciarTimer3();
        }

        private void namec2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monitoriar(object sender, EventArgs e)
        {
            Form_MU = new MonitorUsuario(objSub,objSub2,objSub3);
            Form_MU.Show();
        }

    }
}
