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
    public partial class CuadroCliente : UserControl
    {
        ClientesMetro padre;
        public CuadroCliente(Point pos, String ape, String nom, String rut, ClientesMetro mi_panel)
        {
           
            InitializeComponent();
            //this.Location = pos;
            lblApe.Text = ape;
            lblNom.Text = nom;
            lblRut.Text = rut;
            padre = mi_panel;
        }

        public CuadroCliente()
        {

            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            padre.Hide();
            padre.ObtenerCliente(this.lblRut.Text);
            
        }
    }
}
