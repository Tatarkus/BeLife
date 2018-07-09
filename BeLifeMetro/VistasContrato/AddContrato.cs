using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace BeLifeMetro
{

    /*
    *AddContrato es un UserControl que muestra el formulario
    * que contiene los campos necesarios para llenar la información
    * que se requiere para ingresar un nuevo Contrato a la base de datos
    * 
         */
    public partial class AddContrato : UserControl
    {
        public AddContrato()
        {
            List<String> planes = new List<String>();
            List<String> polizas = new List<String>();
            InitializeComponent();
            //Se obtienen los planes de la base de datos para mantener consistencia

            planes = DAOBeLife.DAO.Obtener_planes();

            //Por cada plan que se encuentre se agrega una opción al ComboBox
            //de seleccion de Planes.
            foreach (String nombre_plan in planes)
            { 
            cbPlan.Items.Add(nombre_plan);
            }
            //Se obtienen las polizas de la base de datos para mantener consistencia

            polizas = DAOBeLife.DAO.Obtener_polizas();

            //Por cada poliza que se encuentre se agrega una opción al ComboBox
            //de seleccion de Polizas. Aunque las polizas no se pueden escoger manualmente
            //ya que una poliza se encuentra vinculada a un plan.
            foreach (String poliza_actual in polizas)
            {
                cbPoliza.Items.Add(poliza_actual);
            }
        }




        //Cuando se hace click en el boton Volver se carga la ventana
        //de contratos y se abandona la actual.
        private void button3_Click(object sender, EventArgs e)
        {

            UserControl ucContrato = new BeLifeMetro.VentanaContrato();
            this.panel1.Controls.Clear();
            ucContrato.BringToFront();

            this.panel1.Controls.Add(ucContrato);
        }


        //Como los planes y las polizas se encuentran relacionados
        //Cada vez que se seleccione una poliza se selecciona automaticamente
        //en el combo box de los planes el plan asociado a la poliza.
        //La asociación esta presente en el programa por medio de los Indices 
        //de los ComboBox. Es decir: El plan de indice 0 le corresponde la poliza
        //del mismo indice.
        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPoliza.SelectedIndex = cbPlan.SelectedIndex;
        }


        public void rut_seleccionado(String rut) {
            txtrut.Text = rut;
        }

        //Cuando se hace click en el de clientes
        //se muestran los clientes en la base de datos
        //para seleccionar uno y asociarle el contrato a ese cliente.
        //Tambien se puede ingresar un RUT manualmente.
        private void button1_Click(object sender, EventArgs e)
        {
            UserControl ucClientesMetro = new BeLifeMetro.ClientesMetro(this);
            this.panel1.Controls.Add(ucClientesMetro);
            ucClientesMetro.BringToFront();
        }

        //Al hacer click en el boton para agregar contrato
        //Se envìa la lista de los campos del formulario
        //Al la clase que se encarga de las consultas de la base de datos.
        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            ControladoraEntidades cm = new ControladoraEntidades();
            try
            {
                //La funcion Lista_campos obtiene una lista de todos los
                //textBox, comboBox y radioButtons del formulario.
                //Esta lista es entregada al DAO para que realice la inserciòn
                //de un nuevo cliente.
                DAOBeLife.DAO.Insertar_contrato(cm.Lista_campos(this.panel1));
                MessageBox.Show("Contrato agregado con exito!");

                //Se carga la ventana de contratos donde debería aparecer
                //el Contrato agregado.
                UserControl ucContrato = new BeLifeMetro.VentanaContrato();
                this.panel1.Controls.Clear();
                ucContrato.BringToFront();

                this.panel1.Controls.Add(ucContrato);
            }
            catch (Exception error)
            {
                //La excepción puede ser de 2 tipos
                //ArgumentOutOfRangeException quiere decir que no se llenaron todos
                //los campos. Ya que el procedimiento almacenado esperaba un cierto
                //numero de parametros y recibió una cantidad menor.
                //Si el Error es de otro tipo se muestra el error por pantalla.
                if (error is ArgumentOutOfRangeException)
                {
                    MessageBox.Show("ERROR: Todos los campos son obligatorios");
                }
                else
                {
                    MessageBox.Show(error.Message);
                }
                //MessageBox.Show(error.GetType().ToString()+"\n "+error.Message);
            }
        }
    }
}
