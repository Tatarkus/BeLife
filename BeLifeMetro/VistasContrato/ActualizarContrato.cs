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
    public partial class ActualizarContrato : UserControl
    {
        /*
         * ActualizarContrato es un Control de Usuario que muestra un formulario
         * con los datos a un Contrato que se recibe al momento de instanciar
         * la clase.
         * Esta clase debe obtener de la base de datos la lista de planes y polizas
         * para que siempre exista consistencia entre los planes y polizas que existen
         * en la base de datos y los planes y polizas que se dan como opciòn en el
         * programa.
         */
        public ActualizarContrato(Contrato contrato)
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

            //Del contrato que se recibe al momento de crear la clase
            //se obtienen por medio de los accesadores los parametros que
            //identifican al contrato. Estos parametros se van agregando
            //a los respectivos campos del Formulario para Actualizar el Contrato
            cbPoliza.Text = contrato.GetPoliza();
            cbPlan.SelectedIndex = cbPoliza.SelectedIndex;

            //Con el RUT Asociado al Contrato se hace una consulta en la base de datos
            //para obtener el Nombre del Cliente al cual pertenece el contrato.
            txtTitular.Text = DAOBeLife.DAO.Obtener_cliente(contrato.GetTitular());

            //Por defecto no presenta Salud, pero si se encuentra se cambia el estado
            //del radio button mas abajo.
            rbNo.Checked = true;

            //Se continua tomando los atributos de la clase e insertandolos en el
            //Formulario
            txtObs.Text = contrato.GetObs();
            txtPrimaA.Text = contrato.GetPrimaAnual().ToString();
            txtPrimaM.Text = contrato.GetPrimaMensual().ToString();
            txtRut.Text = contrato.GetTitular();
            cbVigencia.Text = contrato.GetVigente().ToString();
            dtFechaC.Text = contrato.GetCreacion().ToString();
            dtFin.Text = contrato.GetFinVigencia().ToString();
            dtInicio.Text = contrato.GetInicioVigencia().ToString();

            //So se encuentra Salud entonces el radiobutton asociado a la opciòn
            //de que existe Certificado de Salud se checkea.
            if (contrato.GetSalud())
                rbSi.Checked = true;
            txtNumeroContrato.Text = contrato.GetNumero();
        }


        //Se habilita autoscroll para que si existen datos en la parte inferior la
        //ventana se ajuste automaticamente
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.panel1.AutoScroll = true;
        }

        //Cuando se hace click en el boton Volver se carga la ventana
        //de contratos y se abandona la actual.
        private void Button1_Click(object sender, EventArgs e)
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

        //Se calcula la prima Anual en base a la prima mensual ingresada.
        private void txtPrimaM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Si no se escribe valor se arroja una excepción
                //Ya que es imposible aplicar una operación matematica
                //a un valor NULO. En ese caso se maneja la excepción
                //Asignandole el valor de "0" al campo de la prima Anual.
                txtPrimaA.Text = (float.Parse(txtPrimaM.Text) * 12).ToString();
            }
            catch (FormatException)
            {

                txtPrimaA.Text = "0";
            }
        }

        //Si se elige cambiar la fecha de termino de vigencia
        //Se chequea la diferencia con la fecha actual.
        //Si el termino de vigencia es anterior a la fecha actual
        //Se asigna el valor de NO VIGENTE al comboBox de Vigencia
        private void dtFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtFin.Value.CompareTo(System.DateTime.Now) < 0)
                cbVigencia.Text = "NO VIGENTE";
            else
                cbVigencia.Text = "VIGENTE";
        }


        //Al hacer click en el boton de Actualizar
        //Se guardan todas los datos de los campos en una lista de Strings
        //Esta lista de String la recibe la clase encargada de 
        //realizar las consultas a la base de datos.
        private void btnActualizarContrato_Click(object sender, EventArgs e)
        {
            //Lista que guarda todos los valores de los campos del formulario.
            List<String> datos_contrato = new List<String>();

            //Se agregan los valores a la lista
            datos_contrato.Add(txtNumeroContrato.Text);
            datos_contrato.Add(cbPlan.Text);
            datos_contrato.Add(dtInicio.Text);
            datos_contrato.Add(dtFin.Text);

            //Si el ComboBox de vigencia dice "VIGENTE" se pasa el valor de "VERDADERO"
            //en forma de String para que pueda ser manipulado por la clase que
            //realiza consultas a la Base de Datos.
            if (cbVigencia.Text == "VIGENTE")
                datos_contrato.Add(bool.TrueString);
            else
                datos_contrato.Add(bool.FalseString);

            //Se realiza algo semejante al manejo del estado de VIGENCIA
            //Se toma el estado del radioButton de Previciòn de Salud
            //y se agrega a la lista "si" o "no" segun corresponda.
            if (rbSi.Checked)
                datos_contrato.Add("si");
            else
                datos_contrato.Add("no");
            datos_contrato.Add(txtPrimaA.Text);
            datos_contrato.Add(txtPrimaM.Text);
            datos_contrato.Add(txtObs.Text);

            //Como se pueden cambiar los valores del contrato
            //Se verifica que la prima no quede vacìa y sea superior a 0
            if (txtPrimaM.Text.Length > 0 && (float.Parse(txtPrimaM.Text)) > 0)
            {
                //Se llama a la clase con la lista de parametros que está en los campos
                //del formulario.
                DAOBeLife.DAO.Actualizar_contrato(datos_contrato);
                MessageBox.Show("Se ha actualizado el contrato exitosamente!");

                //Se carga la ventana de contratos cuando al operación se realiza
                //correctamente
                UserControl ucContrato = new BeLifeMetro.VentanaContrato();
                this.panel1.Controls.Clear();
                ucContrato.BringToFront();

                this.panel1.Controls.Add(ucContrato);
            }
            else
                MessageBox.Show("Debe llenar todos los campos");
        }

        private void picConf_Click(object sender, EventArgs e)
        {

        }

    }
}
