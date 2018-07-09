using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeLifeMetro
{
    public partial class Principal : UserControl
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserControl ucContrato = new BeLifeMetro.VentanaContrato();
            this.panel1.Controls.Clear();
            //ucContrato.Location = new Point(120, 0);
            ucContrato.BringToFront();
           

            this.panel1.Controls.Add(ucContrato);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*this.panel1.Controls.Clear();
            UserControl ucCliente = new BeLifeMetro.VentanaCliente();

            //ucCliente.Location = new Point(0, 0);
            ucCliente.BringToFront();
          
            this.panel1.Controls.Add(ucCliente);*/

        }

      
    }
}
