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
    public partial class RegistrarCliente : UserControl
    {

        /*
         * El Control de Usuario RegistrarCliente
         * Presenta el formulario con los campos necesarios para ingresar
         * un nuevo cliente a la base de datos
         */

            //La clase RUTHandler contiene los metos de validaciòn
            //del input relacionado al RUT
        RUTHandler rh = new RUTHandler();

        public RegistrarCliente()
        {
            InitializeComponent();
            //El cliente debe tener al menos 18 años

            dateFechaNacimiento.MaxDate = System.DateTime.Now.AddYears(-18);
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
                try
                {
                    //Lista_campos retorna una lista de todas las String
                    //asociadas a los campos del formulario.
                    //La libreria DAOBeLife toma todos los campos para
                    //realizar el INSERT en la base de datos de un nuevo cliente.
                    //Siempre y cuando no se produzca una excepcion
                
                    DAOBeLife.DAO.Insertar_cliente(cm.Lista_campos(this.panel1));
                    MessageBox.Show("Cliente agregado con Exito!");

                    //Se carga la ventana de clientes donde debería mostrarse el
                    //cliente nuevo.
                    UserControl ucCliente = new BeLifeMetro.VentanaCliente();
                    this.panel1.Controls.Clear();
                    ucCliente.BringToFront();

                    this.panel1.Controls.Add(ucCliente);
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

        //Cada vez que se presiona la una tecla y el valor del textbox
        //del rut cambia se valida para que tenga el formato correcto.
        private void txtRut_KeyPressed(object sender, KeyPressEventArgs e)
        {
            txtRut.Text = rh.ValidarInput(txtRut.Text, e);
            txtRut.SelectionStart = txtRut.Text.Length;
        }

    }
}
