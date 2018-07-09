using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeLifeMetro
{
    public partial class BeLife : Form
    {
        public BeLife()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void ventanaContrato1_Load(object sender, EventArgs e)
        {
         
        }


        private void panMenu_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panPrincipal_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panPrincipal_Load(object sender, EventArgs e)
        {
      
        }

        private void principal1_Load(object sender, EventArgs e)
        {

        }

        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            this.panPrincipal.Controls.Clear();
            UserControl ucCliente = new BeLifeMetro.VentanaCliente();

            //ucCliente.Location = new Point(0, 0);
            ucCliente.BringToFront();

            this.panPrincipal.Controls.Add(ucCliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl ucContrato = new BeLifeMetro.VentanaContrato();
            this.panPrincipal.Controls.Clear();

            //ucContrato.Location = new Point(120, 0);
            ucContrato.BringToFront();


            this.panPrincipal.Controls.Add(ucContrato);
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            this.panPrincipal.Controls.Clear();
            UserControl VentanaContrato = new BeLifeMetro.VentanaContrato();

            //ucCliente.Location = new Point(0, 0);
            VentanaContrato.BringToFront();

            this.panPrincipal.Controls.Add(VentanaContrato);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panPrincipal.Controls.Clear();
            UserControl ucCliente = new BeLifeMetro.VentanaCliente();


            ucCliente.BringToFront();

            this.panPrincipal.Controls.Add(ucCliente);
        }
    }
}
