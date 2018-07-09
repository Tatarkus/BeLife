using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeLifeMetro
{
    public partial class VentanaCliente : UserControl
    {
        /*
        * El control de usuario VentanaCliente contiene la lista de Clientes
        * de la base de datos. Al momento de instanciarse se realiza
        * la consulta a la base de datos y se obtiene la lista de clientes
        * Cada cliente tiene a su vez una lista de parametros que lleva sus
        * datos asociados..
        * 
         */

            //ClienteMetodos es la controladora entre la interfaz y las entidades
        ControladoraEntidades cm = new ControladoraEntidades();

        public VentanaCliente()
        {
            InitializeComponent();

            //Si es que la conexión a la base de datos es exitosa se obtiene
            //la lista de clientes.
            try
            {
                //Lista_clientes() obtiene la lista de clientes de la base de datos.
                foreach (Cliente cli in cm.Lista_clientes())
                {
                    //Por cada cliente encontrado se agrega una entrada a la ListView
                    //Estas entradas permiten ver información básica de un cliente
                    //además de poder seleccionarlos para eliminarlos o modificarlos.

                    //Las entradas a la ListView corresponden a una lista o arreglo de 
                    //Strings que contiene algunos atributos de la clase Clientes
                    listClientes.Items.Add(new ListViewItem(new String[] { cli.GetRut(),cli.GetNom(), cli.getApe(), cli.GetSexoString(), cli.GetEstadoString()}));
                }

            }

            //La excepción SQL esperada en este contexto corresponde a problemas con la
            //conexión a la base de datos.
            catch (SqlException e)
            {
                MessageBox.Show("ERROR: No se pudo conectar con el servidor.");
               
            }
        }

        //Si se hace click el cuadro que representa Agregar Cliente
        //Se limpia los contenidos del panel y se agrega el Control de Usuario
        //asociada a la operaciòn de agregar cliente.
        //Ese control de usuario contiene el formulario para ingresar los datos.
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            
            RegistrarCliente RegistrarCliente = new RegistrarCliente();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(RegistrarCliente);


        }

        //El filtro de CLIENTES se hace automaticamente.
        //Se toman los valores del textBox del RUT
        //El estado de los radioButton asociados al Sexo
        //Y el valor del texto asociado al comboBox del estado civil.
        private void filtrar_clientes()
        {
            //Por defecto no hay un filtro de sexo aplicado.
            //Si se checkea uno de los radiobuttons esto cambia.
            int? filtro_sexo = null;
            if (rbMasculino.Checked)
                filtro_sexo = 1;
            if(rbFemenino.Checked)
                filtro_sexo = 2;

            //Se limpia la ListView de los clientes.
            listClientes.Items.Clear();
            //Se crea una nueva lista de clientes donde se guardan solo los clientes
            //que cumplen con el filtro.
            List<Cliente> clientes_filtrados = new List<Cliente>();

            //La funcion FiltrarClientes retorna una lista de los clientes que cumplen con
            //el criterio del filtro.
            clientes_filtrados = cm.FiltrarClientes (txtRut.Text, filtro_sexo , cbEstadoCivil.SelectedIndex+1);

            //Por cada cliente en la lista que se retorna se extraen sus datos
            //para que sean mostrados en la ListView de la Ventana Actual
            foreach (Cliente cli in clientes_filtrados)
            {

                listClientes.Items.Add(new ListViewItem(new String[]  { cli.GetRut(), cli.GetNom(), cli.getApe(), cli.GetSexoString(), cli.GetEstadoString()}));
            }

        }

        //Si se cambia el txtBox asociado al filtro por RUT se realiza el filtro
        //inmediatamente.
        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            filtrar_clientes();
        }

        //Si se cambia uno de los radioButtons asociados al filtro por Sexo se realiza el filtro
        //inmediatamente.
        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            filtrar_clientes();
        }
        //Si se cambia uno de los radioButtons asociados al filtro por Sexo se realiza el filtro
        //inmediatamente.
        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            filtrar_clientes();
        }

        //Si se cambia el valor del comboBox asociado al filtro por EstadoCivil se realiza el filtro
        //inmediatamente.
        private void cbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar_clientes();
        }

        //Al hacer click en el boton asociado a la operación de actualizar cliente
        //se vacia el contenido del panel1 y se carga el control de usuario
        //asociado a la operación de actualizar cliente.
        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            //Se pide que exista un cliente seleccionado de la lista.
            if (listClientes.SelectedItems.Count != 0)
            {
                //Se obtiene el RUT del cliente de la seleccion de la ListView
                String numero_cliente = (listClientes.SelectedItems[0].SubItems[0].Text);
                
                //Se crea un cliente con los datos del cliente que tiene el RUT
               // seleccionado.
                Cliente cliente_actualizar = cm.BuscarCliente(numero_cliente);

                //Se le entrega un objeto cliente en la instanciación del control de usuario
                //de actualizar cliente. Este objeto tiene los datos que se desplegaran
                //en el formulario para ser actualizados. 
                UserControl ActualizarCliente = new BeLifeMetro.ActualizarCliente(cliente_actualizar);
                this.panel1.Controls.Clear();
                ActualizarCliente.BringToFront();
                this.panel1.Controls.Add(ActualizarCliente);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para actualizar.");
            }

        }

        //Se limpian todos los campos relacionados al filtro cuando se hace
        //click en el boton limpiar.
        private void button1_Click(object sender, EventArgs e)
        {
            cbEstadoCivil.SelectedItem = null;
            txtRut.ResetText();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            filtrar_clientes();
        }

        //Si se hace click en eliminar cliente primero se revisa que exista
        //un cliente seleccionado de la lista.
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItems.Count != 0)
            {
                //Se obtiene el RUT del cliente de la ListView
                String numero_cliente = (listClientes.SelectedItems[0].SubItems[0].Text);
                //Se obtiene una lista de contratos vigentes.

                try
                {
                    List<String> contratos_vigentes = DAOBeLife.DAO.Eliminar_cliente(numero_cliente);

                    //Si el cliente posee contratos vigentes entonces no se puede eliminar.
                    //Si no posee contratos vigentes se "BORRA"
                    //Cabe destacar que en realidad no se borra nunca el cliente.
                    //Solo se va a la tabla de clientes historicos en la base de datos.
                    if (contratos_vigentes == null)
                    {
                        MessageBox.Show("Se ha borrado el cliente");
                        //Terminada la operaciòn se carga la lista de clientes nuevamente.
                        UserControl ucCliente = new BeLifeMetro.VentanaCliente();
                        this.panel1.Controls.Clear();
                        ucCliente.BringToFront();

                        this.panel1.Controls.Add(ucCliente);
                    }

                    else
                    {
                        MessageBox.Show("El cliente tiene " + contratos_vigentes.Count + " contratos vigentes. \nTermine los contratos antes de borrar el cliente");

                    }
                }
                catch(Exception error) { MessageBox.Show(error.Message); }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista.");
            }
        }
    }
}
