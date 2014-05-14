namespace ProyectoHS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.namec1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfin1 = new System.Windows.Forms.Button();
            this.btnatender1 = new System.Windows.Forms.Button();
            this.lbltimer1 = new System.Windows.Forms.Label();
            this.txtenfermera1 = new System.Windows.Forms.TextBox();
            this.lbl1_2 = new System.Windows.Forms.Label();
            this.lbl1_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnfin2 = new System.Windows.Forms.Button();
            this.btnatender2 = new System.Windows.Forms.Button();
            this.namec2 = new System.Windows.Forms.Label();
            this.lbltimer2 = new System.Windows.Forms.Label();
            this.txtenfermera2 = new System.Windows.Forms.TextBox();
            this.lbl2_2 = new System.Windows.Forms.Label();
            this.lbl2_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnfin3 = new System.Windows.Forms.Button();
            this.btnatender3 = new System.Windows.Forms.Button();
            this.lbltimer3 = new System.Windows.Forms.Label();
            this.txtenfermera3 = new System.Windows.Forms.TextBox();
            this.lbl3_2 = new System.Windows.Forms.Label();
            this.lbl3_1 = new System.Windows.Forms.Label();
            this.namec3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCamasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEnfermeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namec1
            // 
            this.namec1.AutoSize = true;
            this.namec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namec1.Location = new System.Drawing.Point(59, 20);
            this.namec1.Name = "namec1";
            this.namec1.Size = new System.Drawing.Size(180, 25);
            this.namec1.TabIndex = 0;
            this.namec1.Text = "Juan Perez Gomez";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnfin1);
            this.panel1.Controls.Add(this.btnatender1);
            this.panel1.Controls.Add(this.lbltimer1);
            this.panel1.Controls.Add(this.txtenfermera1);
            this.panel1.Controls.Add(this.lbl1_2);
            this.panel1.Controls.Add(this.lbl1_1);
            this.panel1.Controls.Add(this.namec1);
            this.panel1.Location = new System.Drawing.Point(21, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 194);
            this.panel1.TabIndex = 1;
            // 
            // btnfin1
            // 
            this.btnfin1.Location = new System.Drawing.Point(152, 160);
            this.btnfin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfin1.Name = "btnfin1";
            this.btnfin1.Size = new System.Drawing.Size(75, 23);
            this.btnfin1.TabIndex = 6;
            this.btnfin1.Text = "Finalizar";
            this.btnfin1.UseVisualStyleBackColor = true;
            this.btnfin1.Visible = false;
            this.btnfin1.Click += new System.EventHandler(this.btnfin1_Click);
            // 
            // btnatender1
            // 
            this.btnatender1.Location = new System.Drawing.Point(71, 160);
            this.btnatender1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnatender1.Name = "btnatender1";
            this.btnatender1.Size = new System.Drawing.Size(75, 23);
            this.btnatender1.TabIndex = 5;
            this.btnatender1.Text = "Atender";
            this.btnatender1.UseVisualStyleBackColor = true;
            this.btnatender1.Visible = false;
            this.btnatender1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltimer1
            // 
            this.lbltimer1.AutoSize = true;
            this.lbltimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer1.Location = new System.Drawing.Point(184, 124);
            this.lbltimer1.Name = "lbltimer1";
            this.lbltimer1.Size = new System.Drawing.Size(49, 18);
            this.lbltimer1.TabIndex = 4;
            this.lbltimer1.Text = "00:00";
            this.lbltimer1.Visible = false;
            // 
            // txtenfermera1
            // 
            this.txtenfermera1.Location = new System.Drawing.Point(35, 89);
            this.txtenfermera1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtenfermera1.Name = "txtenfermera1";
            this.txtenfermera1.Size = new System.Drawing.Size(205, 22);
            this.txtenfermera1.TabIndex = 3;
            this.txtenfermera1.Visible = false;
            // 
            // lbl1_2
            // 
            this.lbl1_2.AutoSize = true;
            this.lbl1_2.Location = new System.Drawing.Point(33, 124);
            this.lbl1_2.Name = "lbl1_2";
            this.lbl1_2.Size = new System.Drawing.Size(127, 17);
            this.lbl1_2.TabIndex = 2;
            this.lbl1_2.Text = "Tiempo en espera:";
            this.lbl1_2.Visible = false;
            // 
            // lbl1_1
            // 
            this.lbl1_1.AutoSize = true;
            this.lbl1_1.Location = new System.Drawing.Point(31, 68);
            this.lbl1_1.Name = "lbl1_1";
            this.lbl1_1.Size = new System.Drawing.Size(83, 17);
            this.lbl1_1.TabIndex = 1;
            this.lbl1_1.Text = "Asignado a:";
            this.lbl1_1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnfin2);
            this.panel2.Controls.Add(this.btnatender2);
            this.panel2.Controls.Add(this.namec2);
            this.panel2.Controls.Add(this.lbltimer2);
            this.panel2.Controls.Add(this.txtenfermera2);
            this.panel2.Controls.Add(this.lbl2_2);
            this.panel2.Controls.Add(this.lbl2_1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(411, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 194);
            this.panel2.TabIndex = 5;
            // 
            // btnfin2
            // 
            this.btnfin2.Location = new System.Drawing.Point(157, 160);
            this.btnfin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfin2.Name = "btnfin2";
            this.btnfin2.Size = new System.Drawing.Size(75, 23);
            this.btnfin2.TabIndex = 8;
            this.btnfin2.Text = "Finalizar";
            this.btnfin2.UseVisualStyleBackColor = true;
            this.btnfin2.Visible = false;
            this.btnfin2.Click += new System.EventHandler(this.btnfin2_Click);
            // 
            // btnatender2
            // 
            this.btnatender2.Location = new System.Drawing.Point(77, 160);
            this.btnatender2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnatender2.Name = "btnatender2";
            this.btnatender2.Size = new System.Drawing.Size(75, 23);
            this.btnatender2.TabIndex = 7;
            this.btnatender2.Text = "Atender";
            this.btnatender2.UseVisualStyleBackColor = true;
            this.btnatender2.Visible = false;
            this.btnatender2.Click += new System.EventHandler(this.btnatender2_Click);
            // 
            // namec2
            // 
            this.namec2.AutoSize = true;
            this.namec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namec2.Location = new System.Drawing.Point(51, 20);
            this.namec2.Name = "namec2";
            this.namec2.Size = new System.Drawing.Size(189, 25);
            this.namec2.TabIndex = 5;
            this.namec2.Text = "Ernesto Calderon C.";
            this.namec2.Click += new System.EventHandler(this.namec2_Click);
            // 
            // lbltimer2
            // 
            this.lbltimer2.AutoSize = true;
            this.lbltimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer2.Location = new System.Drawing.Point(184, 124);
            this.lbltimer2.Name = "lbltimer2";
            this.lbltimer2.Size = new System.Drawing.Size(49, 18);
            this.lbltimer2.TabIndex = 4;
            this.lbltimer2.Text = "00:00";
            this.lbltimer2.Visible = false;
            // 
            // txtenfermera2
            // 
            this.txtenfermera2.Location = new System.Drawing.Point(35, 89);
            this.txtenfermera2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtenfermera2.Name = "txtenfermera2";
            this.txtenfermera2.Size = new System.Drawing.Size(205, 22);
            this.txtenfermera2.TabIndex = 3;
            this.txtenfermera2.Visible = false;
            // 
            // lbl2_2
            // 
            this.lbl2_2.AutoSize = true;
            this.lbl2_2.Location = new System.Drawing.Point(33, 124);
            this.lbl2_2.Name = "lbl2_2";
            this.lbl2_2.Size = new System.Drawing.Size(127, 17);
            this.lbl2_2.TabIndex = 2;
            this.lbl2_2.Text = "Tiempo en espera:";
            this.lbl2_2.Visible = false;
            // 
            // lbl2_1
            // 
            this.lbl2_1.AutoSize = true;
            this.lbl2_1.Location = new System.Drawing.Point(31, 68);
            this.lbl2_1.Name = "lbl2_1";
            this.lbl2_1.Size = new System.Drawing.Size(83, 17);
            this.lbl2_1.TabIndex = 1;
            this.lbl2_1.Text = "Asignado a:";
            this.lbl2_1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-611, -110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Javier Ramirez Gomez";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnfin3);
            this.panel3.Controls.Add(this.btnatender3);
            this.panel3.Controls.Add(this.lbltimer3);
            this.panel3.Controls.Add(this.txtenfermera3);
            this.panel3.Controls.Add(this.lbl3_2);
            this.panel3.Controls.Add(this.lbl3_1);
            this.panel3.Controls.Add(this.namec3);
            this.panel3.Location = new System.Drawing.Point(809, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 194);
            this.panel3.TabIndex = 5;
            // 
            // btnfin3
            // 
            this.btnfin3.Location = new System.Drawing.Point(157, 160);
            this.btnfin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfin3.Name = "btnfin3";
            this.btnfin3.Size = new System.Drawing.Size(75, 23);
            this.btnfin3.TabIndex = 10;
            this.btnfin3.Text = "Finalizar";
            this.btnfin3.UseVisualStyleBackColor = true;
            this.btnfin3.Visible = false;
            this.btnfin3.Click += new System.EventHandler(this.btnfin3_Click);
            // 
            // btnatender3
            // 
            this.btnatender3.Location = new System.Drawing.Point(77, 160);
            this.btnatender3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnatender3.Name = "btnatender3";
            this.btnatender3.Size = new System.Drawing.Size(75, 23);
            this.btnatender3.TabIndex = 9;
            this.btnatender3.Text = "Atender";
            this.btnatender3.UseVisualStyleBackColor = true;
            this.btnatender3.Visible = false;
            this.btnatender3.Click += new System.EventHandler(this.btnatender3_Click);
            // 
            // lbltimer3
            // 
            this.lbltimer3.AutoSize = true;
            this.lbltimer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer3.Location = new System.Drawing.Point(184, 124);
            this.lbltimer3.Name = "lbltimer3";
            this.lbltimer3.Size = new System.Drawing.Size(49, 18);
            this.lbltimer3.TabIndex = 4;
            this.lbltimer3.Text = "00:00";
            this.lbltimer3.Visible = false;
            // 
            // txtenfermera3
            // 
            this.txtenfermera3.Location = new System.Drawing.Point(35, 89);
            this.txtenfermera3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtenfermera3.Name = "txtenfermera3";
            this.txtenfermera3.Size = new System.Drawing.Size(205, 22);
            this.txtenfermera3.TabIndex = 3;
            this.txtenfermera3.Visible = false;
            // 
            // lbl3_2
            // 
            this.lbl3_2.AutoSize = true;
            this.lbl3_2.Location = new System.Drawing.Point(33, 124);
            this.lbl3_2.Name = "lbl3_2";
            this.lbl3_2.Size = new System.Drawing.Size(127, 17);
            this.lbl3_2.TabIndex = 2;
            this.lbl3_2.Text = "Tiempo en espera:";
            this.lbl3_2.Visible = false;
            // 
            // lbl3_1
            // 
            this.lbl3_1.AutoSize = true;
            this.lbl3_1.Location = new System.Drawing.Point(31, 68);
            this.lbl3_1.Name = "lbl3_1";
            this.lbl3_1.Size = new System.Drawing.Size(83, 17);
            this.lbl3_1.TabIndex = 1;
            this.lbl3_1.Text = "Asignado a:";
            this.lbl3_1.Visible = false;
            // 
            // namec3
            // 
            this.namec3.AutoSize = true;
            this.namec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namec3.Location = new System.Drawing.Point(59, 20);
            this.namec3.Name = "namec3";
            this.namec3.Size = new System.Drawing.Size(182, 25);
            this.namec3.TabIndex = 0;
            this.namec3.Text = "Alejandro Aguirre K";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCamasToolStripMenuItem,
            this.asignarEnfermeraToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // editarCamasToolStripMenuItem
            // 
            this.editarCamasToolStripMenuItem.Name = "editarCamasToolStripMenuItem";
            this.editarCamasToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.editarCamasToolStripMenuItem.Text = "Editar Camas";
            // 
            // asignarEnfermeraToolStripMenuItem
            // 
            this.asignarEnfermeraToolStripMenuItem.Name = "asignarEnfermeraToolStripMenuItem";
            this.asignarEnfermeraToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.asignarEnfermeraToolStripMenuItem.Text = "Asignar Enfermera";
            this.asignarEnfermeraToolStripMenuItem.Click += new System.EventHandler(this.asignarEnfermeraToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Monitor de Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.monitoriar);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namec1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltimer1;
        private System.Windows.Forms.TextBox txtenfermera1;
        private System.Windows.Forms.Label lbl1_2;
        private System.Windows.Forms.Label lbl1_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltimer2;
        private System.Windows.Forms.TextBox txtenfermera2;
        private System.Windows.Forms.Label lbl2_2;
        private System.Windows.Forms.Label lbl2_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltimer3;
        private System.Windows.Forms.TextBox txtenfermera3;
        private System.Windows.Forms.Label lbl3_2;
        private System.Windows.Forms.Label lbl3_1;
        private System.Windows.Forms.Label namec3;
        private System.Windows.Forms.Label namec2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCamasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarEnfermeraToolStripMenuItem;
        private System.Windows.Forms.Button btnfin1;
        private System.Windows.Forms.Button btnatender1;
        private System.Windows.Forms.Button btnfin2;
        private System.Windows.Forms.Button btnatender2;
        private System.Windows.Forms.Button btnfin3;
        private System.Windows.Forms.Button btnatender3;
        private System.Windows.Forms.Button button1;
    }
}

