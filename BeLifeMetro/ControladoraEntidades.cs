
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BeLifeMetro
{
    public class ControladoraEntidades
    {
        List<Cliente> clientes;
        List<Contrato> contratos;

        public ControladoraEntidades()
        {

        }


        /* Lista de campos es una funcion que recorre todos los controles
         * de interfaz de un panel y obtiene los String asociados al Texto
         * del control.
         * 
         * Cada String de Texto se agrega luego a una lista de Strings
         * Esta función resulta util para obtener todos los campos de un formulario
         * 
         * Se debe tener cuidado de manejar el orden en el cual se guardan
         * los Atributos Texto de los Controles en la Lista
         */
       public List <String> Lista_campos (System.Windows.Forms.Panel mi_panel )
        {
            List<String> campos = new List<string>();
            foreach (System.Windows.Forms.Control mi_control in mi_panel.Controls)
            {

                //Segun el tipo del control se obtiene el texto.
                if (mi_control is TextBox)
                    campos.Add(mi_control.Text);
                if (mi_control is DateTimePicker)
                    campos.Add(mi_control.Text);
                if (mi_control is RadioButton && ((RadioButton)mi_control).Checked) {
                    campos.Add(mi_control.Text);
                     
                }
                if (mi_control is CheckBox && ((CheckBox)mi_control).Checked)
                {
                    campos.Add(mi_control.Text);

                }
                if (mi_control is ComboBox)
                {
                    campos.Add(mi_control.Text);

                }
            }
            return campos;
        }


        //Se realiza la consulta en la base de datos y se obtienen los parametros
        //de cada cliente. Se instancia un objeto cliente seteando sus parametros
        //con el constructor que recibe una lista de parametros como String
        //Este objeto luego se agrega a una lista de clientes y se retorna.
        public List<Cliente> Lista_clientes()
        {
            List<Cliente> clientes = new List<Cliente>();
  
            foreach (List<String> datos_cliente in DAOBeLife.DAO.Obtener_clientes())
                clientes.Add(new Cliente(datos_cliente));
            this.clientes = clientes;
            return clientes;
        }

        //Se realiza la consulta en la base de datos y se obtienen los parametros
        //de cada CONTRATO. Se instancia un objeto CONTRATO seteando sus parametros
        //con el constructor que recibe una lista de parametros como String
        //Este objeto luego se agrega a una lista de CONTRATO y se retorna.
        public List<Contrato> Lista_contratos()
        {
            List<Contrato> contratos = new List<Contrato>();

            try
            {
                foreach (List<String> datos_contrato in DAOBeLife.DAO.Obtener_contratos())
                    contratos.Add(new Contrato(datos_contrato));
            }
            catch (SqlException e) { throw; }
            this.contratos = contratos;
            return contratos;
        }

        //Se busca un contrato en la lista de contratos
        //que tiene la controladora.
        //Se recibe el numero del contrato por parametro
        //Se busca una coincidencia del numero de contrato de cada
        //contrato en la lista con el numero de contrato que se recibió
        //por parametro. Luego se retorna el contrato que presente
        //la coincidencia.
        //Si ningun contrato presenta la coincidencia entonces se retorna nulo.
        public Contrato BuscarContrato(String numero)
        {
            
            foreach (Contrato contrato in contratos)
            {
                if (contrato.GetNumero().CompareTo(numero) == 0)
                    return contrato;

            }
            return null;


        }

        //Se busca un CLIENTE en la lista de CLIENTE
        //que tiene la controladora.
        //Se recibe el RUT del CLIENTE por parametro
        //Se busca una coincidencia del RUT de CLIENTE de cada
        //CLIENTE en la lista con el RUT del CLIENTE que se recibió
        //por parametro. Luego se retorna el CLIENTE que presente
        //la coincidencia.
        //Si ningun CLIENTE presenta la coincidencia entonces se retorna nulo.
        public Cliente BuscarCliente(String rut)
        {

            foreach (Cliente cliente in clientes)
            {
                if (cliente.GetRut().CompareTo(rut) == 0)
                    return cliente;

            }
            return null;


        }

        /*
         De la lista de contratos y clientes que tiene la controladora, que se obtuvo previamente
         utilizando el DAO o la libreria que se encarga de realizar las consultas
         a la base de datos, se obtienen los clientes y contratos que cumplan con el filtro.
             */

            
        public List<Contrato> FiltrarContratos(String filtro_num, String filtro_rut, String filtro_poliza)
        {

            List <Contrato> contratos_filtrados = new List<Contrato>();
            
            //Primero se obtienen todos los contratos.
            //Por cada contrato se revisa si el numero del contrato
            //comienza con el numero del filtro.
            //Si no hay filtro por numero entonces la lista de contratos filtrados
            //es igual a la lista de contratos sin filtrar.
                foreach (Contrato contrato in this.contratos)
                {
                    try
                    {
                        if (contrato.GetNumero().StartsWith(filtro_num))
                        {
                            contratos_filtrados.Add(contrato);
                        }
                    }
                    catch (ArgumentNullException e)
                    {
                        contratos_filtrados = this.contratos;
                        break;
                    }
                }
            
            
                //Despues de filtrar por numero se filtra por
                //el rut del titular de la misma manera.
            foreach (Contrato contrato in this.contratos)
            {
                try
                {
                    if (!contrato.GetTitular().StartsWith(filtro_rut))
                    {
                        if (contratos_filtrados.Contains(contrato))
                            contratos_filtrados.Remove(contrato);

                    }
                }
                catch (ArgumentNullException e)
                {                
                    break;
                }
            }
            //Despues de filtrar por numero se filtra por
            //el codigo de Poliza de la misma manera.
            foreach (Contrato contrato in this.contratos)
            {
                try
                {
                    if (!contrato.GetPoliza().StartsWith(filtro_poliza))
                    {
                        if (contratos_filtrados.Contains(contrato))
                            contratos_filtrados.Remove(contrato);

                    }
                }
                catch (ArgumentNullException e)
                {
                    break;
                }
            }


            return contratos_filtrados;
        }

        /*
         De la lista de contratos y clientes que tiene la controladora, que se obtuvo previamente
         utilizando el DAO o la libreria que se encarga de realizar las consultas
         a la base de datos, se obtienen los clientes y contratos que cumplan con el filtro.
             */

        public List<Cliente> FiltrarClientes(String filtro_rut, int? filtro_sexo, int? filtro_estado)
        {

            List<Cliente> clientes_filtrados = new List<Cliente>();

            foreach (Cliente cliente in this.clientes)
            {
                try
                {
                    //El filtro se hace de forma más directa con los clientes.
                    //Si ve cuales clientes comienzan con el mismo rut recibido
                    //Si el filtro de sexo no es nulo se compara, de forma contraria se ignora el filtro
                    //Si el filtro del estado civil NO es nulo se compara, de forma contraria se ignora ese filtro.
                    if (cliente.GetRut().StartsWith(filtro_rut)
                        && ( cliente.GetSexo()==filtro_sexo || filtro_sexo==null)
                        && ( cliente.GetEstado() == filtro_estado || filtro_estado==0))
                    {
                        clientes_filtrados.Add(cliente);
                    }
                }
                catch (ArgumentNullException e)
                {
                    clientes_filtrados = this.clientes;
                    break;
                }
            }
            return clientes_filtrados;

        }


            
        

    }
}


