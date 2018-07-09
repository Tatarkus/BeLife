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
    public partial class ClientesMetro : UserControl
    {
        String cliente_rut="123";
        AddContrato padre;
        public ClientesMetro(AddContrato padre)
        {
            int contador = 0;
            int pos = 0;

            ControladoraEntidades cm = new ControladoraEntidades();
            List<CuadroCliente> cuadros = new List<CuadroCliente>();
            InitializeComponent();
            if (cm.Lista_clientes().Count == 0) { 
                MessageBox.Show("No existen clientes en la base de datos.");
                UserControl ucContrato = new BeLifeMetro.VentanaContrato();
                this.Controls.Clear();
                ucContrato.BringToFront();

                this.Controls.Add(ucContrato);
            }
            foreach (Cliente cli in cm.Lista_clientes())
            {
                pos = ((contador+1)*5 + 224 * contador);
                //CuadroCliente mi_cuadro = new CuadroCliente(new Point(pos, pos), cli.getApe(), cli.GetNom());
                this.flowPanel.Controls.Add(new CuadroCliente(new Point(pos, pos), cli.getApe(), cli.GetNom(),cli.GetRut(),this));
                this.padre = padre;


            }

            
        }

        public void ObtenerCliente(String rut)
        {
            this.cliente_rut = rut; ;
            padre.rut_seleccionado(this.cliente_rut);
        }

        private void cuadroCliente1_Load(object sender, EventArgs e)
        {

        }

        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void flowPanel_VisibleChanged(object sender, EventArgs e)
        {
            
                this.Hide();
                
                padre.Show();
            MessageBox.Show("asds");
            
            
        }
    }
}
