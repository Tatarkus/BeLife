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
    public partial class VentanaContrato : UserControl
    {
        /*
         * VentanaContrato es un Control de Usuario que muestra una lista
         * de los contratos que existen en la base de datos.
         * Tambien se pueden acceder a las opciones para agregar contrato, borrar uno, o modificarlo
         * **/
        ControladoraEntidades cm = new ControladoraEntidades();

        public VentanaContrato()
        {
            
            InitializeComponent();
            try
            {
                //Por cada contrato que se encuentre se agrega un item en la listView
                foreach (Contrato con in cm.Lista_contratos())
                {
                    //Los items se agregan tomando los atributos de cada contrato encontrado
                    listListaContratos.Items.Add(new ListViewItem(new String[] { con.GetTitular(), con.GetNumero(), con.GetVigente().ToString(), con.GetCreacion().ToString(), con.GetPoliza() }));
                }

            }
            catch (SqlException e)
            {
                //La excepción SQL esperada en este contexto corresponde a problemas con la
                //conexión a la base de datos.
                MessageBox.Show("ERROR: No se pudo conectar con el servidor.");
                // break;
            }

            //Se obtienen las polizas de la base de datos
            //Esta lista de polizas se ocupa para realizar filtros en la lista
            //de contratos que se muestra en esta ventana.
            List <String> polizas = DAOBeLife.DAO.Obtener_polizas();
            foreach (String poliza_actual in polizas)
            {
                //Por cada poliza encontrada se agrega una opción al comboBox
                cbPoliza.Items.Add(poliza_actual);
            }

        }



        

        //El filtro de CONTRATOS se hace automaticamente.
        //Se toman los valores del textBox del NUMERO CONTRATO
        //Se toman los valores del textBox del RUT del TITULAR
        //Y el valor del texto asociado al comboBox del PLAN.
        private void filtrar_contratos()
        {

            //Se limpia la ListView de los clientes.

            listListaContratos.Items.Clear();

            //Se crea una nueva lista de contratos donde se guardan solo los contratos
            //que cumplen con el filtro.
            List< Contrato > contratos_filtrados = new List<Contrato>();

            //La funcion FiltrarContratos retorna una lista de los contratos que cumplen con
            //el criterio del filtro.
            contratos_filtrados = cm.FiltrarContratos(txtFiltrarContrato.Text, txtFiltrarRut.Text, cbPoliza.Text);

            //Por cada contrato en la lista que se retorna se extraen sus datos
            //para que sean mostrados en la ListView de la Ventana Actual
            foreach (Contrato con in contratos_filtrados)
            {

                listListaContratos.Items.Add(new ListViewItem(new String[] { con.GetTitular(), con.GetNumero(), con.GetVigente().ToString(), con.GetCreacion().ToString(), con.GetPoliza() }));
            }
            
        }


        //Si se cambia el txtBox asociado al filtro por NUMERO CONTRATO se realiza el filtro
        //inmediatamente.
        private void txtFiltrarContrato_TextChanged(object sender, EventArgs e)
        {
            filtrar_contratos();
           
        }


        //Si se cambia el txtBox asociado al filtro por RUT se realiza el filtro
        //inmediatamente.
        private void txtFiltrarRut_TextChanged(object sender, EventArgs e)
        {
            filtrar_contratos();
        }

        //Si se cambia el comboBox asociado al filtro por Poliza se realiza el filtro
        //inmediatamente.
        private void cbPoliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar_contratos();
        }

        //Se limpian todos los campos relacionados al filtro cuando se hace
        //click en el boton limpiar.
        private void btnClr_Click(object sender, EventArgs e)
        {
            cbPoliza.SelectedItem = null;
            txtFiltrarRut.ResetText();
            txtFiltrarContrato.ResetText();
            filtrar_contratos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            //Si se hace click en agregar contrato se muestra la ventana
            //con el formulario para agregar un nuevo contrato.
            this.panel1.Controls.Clear();
            UserControl AddContrato = new BeLifeMetro.AddContrato();


            AddContrato.BringToFront();
            this.panel1.Controls.Add(AddContrato);
        }

        //Para eliminar un contrato primero se pide que se seleccione uno de la lista
        private void Button1_Click(object sender, EventArgs e)
        {
            if (listListaContratos.SelectedItems.Count != 0)
            {
                //Se obtiene el numero del contrato seleccionado
                String numero_contrato = (listListaContratos.SelectedItems[0].SubItems[1].Text);

                //Se obtiene la información del contrato y se crea un objeto contrato
                //con esa información
                Contrato contrato_finalizar = cm.BuscarContrato(numero_contrato);

                //Si el contrato está vigente no se puede eliminar.
                if (!contrato_finalizar.GetVigente())
                {
                    //Si no está vigente se muestra una ventana donde se pide confirmar
                    //que se desea eliminar un contrato.
                    UserControl EliminarContrato = new BeLifeMetro.EliminarContrato(contrato_finalizar);

                    this.panel1.Controls.Clear();
                    EliminarContrato.BringToFront();
                    this.panel1.Controls.Add(EliminarContrato);
                }
                else
                {
                    MessageBox.Show("El contrato está Vigente. Debe terminarlo para borrarlo.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contrato de la lista");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Si existe un elemento seleccionado de la lista
            //y se presiona el boton de actualizar contrato se muestra la ventana
            //con el formulario con los datos del contrato seleccionado de la lista.
            if (listListaContratos.SelectedItems.Count != 0)
            {
                //Se obtiene el numero del contrato de la lista.
                String numero_contrato = (listListaContratos.SelectedItems[0].SubItems[1].Text);

                //Se busca en la base de datos el contrato con el numero seleccionado
                //y creamos un contrato con todos los atributos.
                Contrato contrato_actualizar = cm.BuscarContrato(numero_contrato);

                //Se muestra el formulario para actualizar el contratrato.
                //Al control de usuario se le pasa el contrato.
                //De esta forma se puede mostrar en la ventana de actualizar contrato
                //el valor de los atributos que actualmente tiene el contrato.
                UserControl ActualizarContrato = new BeLifeMetro.ActualizarContrato(contrato_actualizar);
                this.panel1.Controls.Clear();
                ActualizarContrato.BringToFront();
                this.panel1.Controls.Add(ActualizarContrato);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contrato para actualizar.");
            }
        }
    }
    }
