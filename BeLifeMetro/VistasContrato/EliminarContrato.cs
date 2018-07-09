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
    public partial class EliminarContrato : UserControl
    {
        Contrato contrato;

        public EliminarContrato(Contrato contrato)
        {
            InitializeComponent();
            this.contrato = contrato;
            lblNumCon.Text = contrato.GetNumero();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            UserControl ucContrato = new BeLifeMetro.VentanaContrato();
            this.panel1.Controls.Clear();
            ucContrato.BringToFront();

            this.panel1.Controls.Add(ucContrato);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            UserControl ucContrato = new BeLifeMetro.VentanaContrato();
            this.panel1.Controls.Clear();
            ucContrato.BringToFront();

            this.panel1.Controls.Add(ucContrato);
        }

        private void btnTerminarContrato_Click(object sender, EventArgs e)
        {
            DAOBeLife.DAO.Terminar_contrato(this.contrato.GetNumero());
            MessageBox.Show("El contrato se ha terminado exitosamente");
            UserControl ucContrato = new BeLifeMetro.VentanaContrato();
            this.panel1.Controls.Clear();
            ucContrato.BringToFront();

            this.panel1.Controls.Add(ucContrato);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
