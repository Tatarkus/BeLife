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
    public partial class ActualizarCliente : UserControl
    {
        /*
         ActualizarCliente es un UserControl que recibe una instancia
         de la clase cliente. Toma los valores de esta clase y los despliega
         en los distintos campos para poder modificarlos.
         Todos los campos pueden ser modificados excepto el RUT
             */

        public ActualizarCliente(Cliente cliente)
        {
            //Inicializar los componentes de la ventana
            InitializeComponent();

            //El cliente debe tener al menos 18 años
            dateFechaNacimiento.MaxDate = System.DateTime.Now.AddYears(-18);

            //Se usan accesadores para mostrar los datos asociados al objeto
            //en los campos del formulario.
            txtRut.Text = cliente.GetRut();
            txtNombres.Text = cliente.GetNom();
            txtApellidos.Text = cliente.getApe();
            dateFechaNacimiento.Value = cliente.GetFec();

            //Se traduce la IDSexo al estado Check de los RadioButtons
            //Si el IDSexo es 1 entonces se Checkea el RadioButton
            //de Sexo Masculino. Siempre va a haber 1 y solo 1 radio
            //button checkeado.
            if (cliente.GetSexo() == 1)
                rbMasculino.Checked = true;
            else
                rbFemenino.Checked = true;
            cbEstadoCivil.SelectedIndex = cliente.GetEstado()-1;

        }

        //Al hacer click en el boton de Actualizar
        //Se inicia una consulta con la base de datos para actualizar los
        //datos de un cliente existente.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se verifica que los campos  de Texto no esten vaciós.
            //El resto de los campos tambien es obligatorio llenarlos.
            if (txtRut.Text.Length > 0 && txtNombres.Text.Length > 0 && txtApellidos.Text.Length > 0)
            {
                //Se crea una instancia de ClienteMetodos
                //Clase controladora entre la interfaz grafica y las entidades.
                ControladoraEntidades cm = new ControladoraEntidades();

                //DatosClientes es una lista de los datos asociados al Cliente
                //Cada elemento de la lista 'datos_clientes' corresponde a un campo
                //del formulario.
                List<String> datos_cliente = new List<String>();

                datos_cliente.Add(txtRut.Text);
                datos_cliente.Add(txtNombres.Text);
                datos_cliente.Add(txtApellidos.Text);
                datos_cliente.Add(dateFechaNacimiento.Text);

                //Se obtiene el estado del RadioButton que determina el Sexo del cliente
                if(rbMasculino.Checked)
                datos_cliente.Add("masculino");
                else
                datos_cliente.Add("femenino");
                datos_cliente.Add(cbEstadoCivil.Text);

                //Se usa la libreria DAOBeLife que se encarga de hacer las
                //consultas a la base de datos.
                try
                {
                    DAOBeLife.DAO.Actualizar_cliente(datos_cliente);
                    //Si el try no arroja excepción se muestra un mensaje de exito.
                    MessageBox.Show("Cliente actualizado con Exito!");
                }
                //La excepción puede ser de 2 tipos
                //ArgumentOutOfRangeException quiere decir que no se llenaron todos
                //los campos. Ya que el procedimiento almacenado esperaba un cierto
                //numero de parametros y recibió una cantidad menor.
                //Si el Error es de otro tipo se muestra el error por pantalla.
                
                catch (Exception error)
                {
                    if (error is ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("ERROR: Todos los campos son obligatorios");
                    }
                    else
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
                MessageBox.Show("ERROR: Todos los campos son obligatorios");
        }

        //Cuando se hace click al boton volver se vacía el contenedor actual
        //llamado panel1 y se le carga el Controlador de Usuario correspondiente
        //al manejo de clientes. Que serìa el panel que va antes de este.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            UserControl ucCliente = new BeLifeMetro.VentanaCliente();
            this.panel1.Controls.Clear();
            ucCliente.BringToFront();

            this.panel1.Controls.Add(ucCliente);
        }
    }
}
