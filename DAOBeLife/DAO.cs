using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAOBeLife
{
    public static class DAO
    {
        //STRING DE CONEXION A LA BASE DE DATOS
        private static String con_string= @"Data Source=.;Initial Catalog=BeLife;Integrated Security=True";

        //OBJETO QUE REPRESENTA LA CONEXION A LA BASE DE DATOS
        private static SqlConnection con = new SqlConnection(con_string);

        //OBJETO QUE REPRESENTA UN COMANDO PARA REALIZAR CONTRA LA BASE DE DATOS
        static SqlCommand comando;

        //GETS AND SETS
        public static SqlConnection Con { get => con; set => con = value; }
        public static SqlCommand Comando { get => comando; set => comando = value; }

        //Insertar un cliente recibe una lista de los atributos necesarios
        //para ingresar un cliente.
        //La lista de atributos debe estar ordenada de la siguiente forma
        //RUT,Nombres,Apellidos,FechaNacimiento,Sexo (string), EstadoCivil (string)

        public static void Insertar_cliente(List<String> parametros_cliente)
        {
            try
            {
               

                //Se abre la conexión
                con.Open();
                //Se usa un procedimiento almacenado que recibe los siguientes
                //parametros.
                comando = new SqlCommand("nuevo_cliente", con);

                //Se pasan los parametros recibidos en la lista de strings
                comando.Parameters.Add("@RutCliente", System.Data.SqlDbType.NVarChar).Value = (parametros_cliente[0]);
                comando.Parameters.Add("@Nombres", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[1];
                comando.Parameters.Add("@Apellidos", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[2];
                comando.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.DateTime).Value = parametros_cliente[3];
                comando.Parameters.Add("@Sexo", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[4];
                comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[5];
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Se realiza el comando.
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                //Se imprime el error por consola
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Number.ToString() + e.Message);

                //Se arroja una excepción con un mensaje para mostrar
                //segun el codigo.
                if (e.Number == 547)
                {

                    throw new Exception("ERROR: El contrato no existe.");
                }
                if (e.Number == 515)
                {
                    throw new Exception("ERROR: Todos los campos son obligatorios.");
                }

                if (e.Number == 2627)
                {
                    throw new Exception("ERROR: El cliente ya existe.");
                }
                

            }
            finally
            {
                //Si ocurre una excepción se debe cerrar la conexión.
                con.Close();
            }
            //Si no ocurre error igualmente se cierra la conexión.
                con.Close();

            }


        public static void Actualizar_cliente(List<String> parametros_cliente)
        {
            try
            {

                con.Open();

                //Se usa un procedimiento almacenado que recibe los siguientes
                //parametros.
                comando = new SqlCommand("actualizar_cliente", con);

                //Se pasan los parametros recibidos en la lista de strings

                comando.Parameters.Add("@Rut", System.Data.SqlDbType.NVarChar).Value = (parametros_cliente[0]);
                comando.Parameters.Add("@Nombres", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[1];
                comando.Parameters.Add("@Apellidos", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[2];
                comando.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.DateTime).Value = parametros_cliente[3];
                comando.Parameters.Add("@Sexo", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[4];
                comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.NVarChar).Value = parametros_cliente[5];
                comando.CommandType = System.Data.CommandType.StoredProcedure;


                comando.ExecuteNonQuery();
            }
            //Se arroja una excepción con un mensaje para mostrar
            //segun el codigo.
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Number.ToString() + e.Message);

                if (e.Number == 547)
                {

                    throw new Exception("ERROR: El contrato no existe.");
                }
                if (e.Number == 515)
                {
                    throw new Exception("ERROR: Todos los campos son obligatorios.");
                }

                if (e.Number == 2627)
                {
                    throw new Exception("ERROR: El cliente ya existe.");
                }


            }
            finally
            {
                con.Close();
            }
            con.Close();

        }

        //Eliminar cliente retorna una lista de string
        //Si la lista de STRINGS es NULA significa que el cliente
        //no tiene contratos vigentes y se puede eliminar.
        //En el caso contraro la lista de String tendrá todos los contratos
        //vigentes.
        public static List<String> Eliminar_cliente(String rut)
        {
            List<String> contratos_vigentes = new List<String>();

            con.Open();
            //Se seleccionan todos los contratos vigentes del cliente
            comando = new SqlCommand("select Numero from Contrato where RutCliente='" + rut + "' AND Vigente=1;", con)
            {
                CommandType = System.Data.CommandType.Text
            };
            SqlDataReader reader = comando.ExecuteReader();

            //Si existen contratos vigentes del cliente.
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //Se guardan los contratos vigentes en la lista
                    contratos_vigentes.Add(String.Format("{0}", reader[0]));
                }
                con.Close();
                return contratos_vigentes;
            }
            else {
                //Si no hay contratos vigentes se cierra el Buffer Reader 
                //y se llama al procedimiento almacenado para borrar un cliente
                //El cliente se guarda en una tabla de cliente historico antes de ser
                //borrado.
                reader.Close();
                SqlCommand comando2 = new SqlCommand("eliminar_cliente", con);
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.Add("@Rut", System.Data.SqlDbType.NVarChar).Value = (rut);
                try
                {
                    comando2.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw new Exception("ERROR: El Cliente tiene contratos asociados.");
                }
                finally { con.Close(); }

            }
            con.Close();
            return null;
            


        }

        //Insertar un cliente recibe una lista de los atributos necesarios
        //para ingresar un cliente.
        //La lista de atributos debe estar ordenada de la siguiente forma
        //RUTTitular,Plan,Apellidos,FechaInicioVigencia,DeclaracionSalid, Observaciones

        //El resto de los atributos se obtienen en el procedimiento almacenado
        //Como el calculo de la prima y el numero del contrato.

        public static void Insertar_contrato(List<String> parametros_contrato)
        {
            try
            {
            con.Open();
            comando = new SqlCommand("nuevo_contrato", con);
            comando.Parameters.Add("@RutCliente", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[0];
            comando.Parameters.Add("@NombrePlan", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[1];
            comando.Parameters.Add("@FechaInicioVigencia", System.Data.SqlDbType.DateTime).Value = parametros_contrato[3];
            comando.Parameters.Add("@DeclaracionSaludOpcion", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[4];
            comando.Parameters.Add("@Observaciones", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[5];
     
                //Se ejecuta el comando asociado al procedimiento almacenado

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            
                comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                //Segun el error se arroja una excepción con un mensaje apropiado para
                //qie este sea mostrado en un messagebox
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Number.ToString() + e.Message);

                if (e.Number == 547)
                {
                    
                throw new Exception("ERROR: El cliente no existe.");
                }
                if (e.Number == 515)
                {
                    throw new Exception("ERROR: Todos los campos son obligatorios.");
                }

            }
            finally {
                con.Close();
            }
            con.Close();

        }

        //Terminar contrato elimina un contrato NO VIGENTE
        //a través de un procedimiento almacenado
        public static void Terminar_contrato(String numero_contrato)
        {
            try
            {
                con.Open();
                comando = new SqlCommand("terminar_contrato", con);
                //Se recibe el numero del contrato.
                comando.Parameters.Add("@NumContrato", System.Data.SqlDbType.NVarChar).Value = numero_contrato;

                comando.CommandType = System.Data.CommandType.StoredProcedure;


                comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                //Segun el error se arroja una excepción con un mensaje apropiado para
                //qie este sea mostrado en un messagebox
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Number.ToString() + e.Message);

                if (e.Number == 547)
                {

                    throw new Exception("ERROR: El cliente no existe.");
                }
                if (e.Number == 515)
                {
                    throw new Exception("ERROR: Todos los campos son obligatorios.");
                }

            }
            finally
            {
                con.Close();
            }
            con.Close();

        }

        //Actualizar_contrato al igual que nuevo_contrato
        //Se realiza a través de un procedimiento almacenado.
        //La diferencia es que actualizar contrato recibe más
        //atributos .


        
        public static void Actualizar_contrato(List<String> parametros_contrato)
        {
            try
            {
                //Se abre la conexión se configura el comando para que sea de tipo
                // procedimiento almacenado. Se le entregan los parametros del contrato
                //en forma de una lista de strings y se le asocian las variables y el tipo.
                con.Open();
                comando = new SqlCommand("actualizar_contrato", con);
                comando.Parameters.Add("@NumContrato", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[0];
                comando.Parameters.Add("@NombrePlan", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[1];
                comando.Parameters.Add("@FechaInicioVigencia", System.Data.SqlDbType.DateTime).Value = parametros_contrato[2];
                comando.Parameters.Add("@FechaTerminoVigencia", System.Data.SqlDbType.DateTime).Value = parametros_contrato[3];
                comando.Parameters.Add("@EstaVigente", System.Data.SqlDbType.Bit).Value = bool.Parse(parametros_contrato[4]);

                comando.Parameters.Add("@DeclaracionSaludOpcion", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[5];
                comando.Parameters.Add("@PrimaAnual", System.Data.SqlDbType.Float).Value = parametros_contrato[6];
                comando.Parameters.Add("@PrimaMensual", System.Data.SqlDbType.Float).Value = parametros_contrato[7];
                comando.Parameters.Add("@Observaciones", System.Data.SqlDbType.NVarChar).Value = parametros_contrato[8];

                comando.CommandType = System.Data.CommandType.StoredProcedure;


                comando.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                //Segun el error se arroja una excepción con un mensaje apropiado para
                //qie este sea mostrado en un messagebox
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Number.ToString() + e.Message);

                if (e.Number == 547)
                {

                    throw new Exception("ERROR: El cliente no existe.");
                }
                if (e.Number == 515)
                {
                    throw new Exception("ERROR: Todos los campos son obligatorios.");
                }

            }
            finally
            {
                con.Close();
            }
            con.Close();

        }

        //Se retorna una lista de strings que contiene la descripción
        //de los planes que se encuentran en la base de datos
        //dentro de la tabla planes
        public static List <String> Obtener_planes()
        {
            List<String> planes = new List<String>();
            con.Open();
            comando = new SqlCommand("SELECT [Nombre] FROM [dbo].[Plan] ORDER BY [IDPlan]", con)
            {
                CommandType = System.Data.CommandType.Text
            };


            try
            {
                //Se van agregando los planes a la lista
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    planes.Add(String.Format("{0}", reader[0]));
                }
                

            }
            //Segun el error se arroja una excepción con un mensaje apropiado para
            //qie este sea mostrado en un messagebox
            catch (SqlException e) {
                System.Diagnostics.Debug.WriteLine("ERROR: "+ e.Message); con.Close();

            }
            con.Close();
            return planes;
        }


        //Se retorna una lista de strings que contiene el  CODIGO
        //de las POLIZAS que se encuentran en la base de datos
        //dentro de la tabla de POLIZAS
        public static List<String> Obtener_polizas()
        {
            List<String> polizas = new List<String>();
            
            con.Open();
            comando = new SqlCommand("SELECT [PolizaActual] FROM [dbo].[Plan] ORDER BY [IDPlan]", con)
            {
                CommandType = System.Data.CommandType.Text
            };


            try
            {
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //Se van agregando las polizas a la lista
                    polizas.Add(String.Format("{0}", reader[0]));
                }


            }
            //Segun el error se arroja una excepción con un mensaje apropiado para
            //que este sea mostrado en un messagebox
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Message);
                con.Close();
            }
            con.Close();
            return polizas;
        }

        //Se obtiene la lista de clientes en la base de datos.
        //Cada cliente tiene a su vez una lista con los atributos que lo identifican.
        public static List<List<String>> Obtener_clientes()
        {
            //Una lista de atributos por cliente. 
           
            List <List<String>> clientes = new List<List <String>>();
            con.Open();

            //Se obtienen TODOS los clientes
            comando = new SqlCommand("SELECT * FROM [dbo].[Cliente] ORDER BY [Apellidos]", con)
            {
                CommandType = System.Data.CommandType.Text
            };


            try
            {
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //Se guardan los datos de las columnas del cliente en la lista
                    //de listas.
                    clientes.Add(new List<String> { String.Format("{0}",reader[0]),
                                                    String.Format("{0}",reader[1]),
                                                    String.Format("{0}",reader[2]),
                                                    String.Format("{0}",reader[3]),
                                                    String.Format("{0}",reader[4]),
                                                    String.Format("{0}",reader[5])});
                }
                

            }
            catch (SqlException e)
            {
                //Se imprimen los errores pro consola.
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Message);
                con.Close();
            }
            con.Close();

            //Se retorna una lista de n clientes con n listas de atributos.
            return clientes;
        }

        //Solo se selecciona un cliente de la base de datos
        //Se recibe el RUT del cliente por parametro.
        public static String Obtener_cliente(String rut)
        {
            String nombre_cliente=null;
            con.Open();

            comando = new SqlCommand("SELECT [Nombres]+' '+[Apellidos] FROM [dbo].[Cliente] WHERE RutCliente ="+rut+";", con)
            {
                CommandType = System.Data.CommandType.Text
            };


            try
            {
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                
                    
                    nombre_cliente = String.Format("{0}", reader[0]);
                                                   
                


            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Message);
                con.Close();
            }
            con.Close();

            return nombre_cliente;
        }

        //Se obtienen los contratos de la base de datos
        public static List<List<String>> Obtener_contratos()
        {
            //Se retorna una lista de atributos por cada contrato.
            //Es decir una lista de listas.
            List<List<String>> contratos = new List<List<String>>();
            try
            {
                con.Open();
                //Se seleccionan los campos relevantes
                comando = new SqlCommand("select RutCliente,Numero,Vigente,FechaCreacion,PolizaActual,FechaCreacion,FechaFinVigencia,CodigoPlan,FechaInicioVigencia,DeclaracionSalud,PrimaAnual,PrimaMensual,Observaciones from Contrato c join dbo.[Plan] p on c.CodigoPlan=p.IdPlan", con)
                {
                CommandType = System.Data.CommandType.Text
                };
            

                /*try
                {*/
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                    //Se agregan los datos del contrato a la sub lista del contrato
                        contratos.Add(new List<String> {String.Format("{0}",reader[0]),
                                                        String.Format("{0}",reader[1]),
                                                        String.Format("{0}",reader[2]),
                                                        String.Format("{0}",reader[3]),
                                                        String.Format("{0}",reader[4]),
                                                        String.Format("{0}",reader[5]),
                                                        String.Format("{0}",reader[6]),
                                                        String.Format("{0}",reader[7]),
                                                        String.Format("{0}",reader[8]),
                                                        String.Format("{0}",reader[9]),
                                                        String.Format("{0}",reader[10]),
                                                        String.Format("{0}",reader[11]),
                                                        String.Format("{0}",reader[12])



                        });
                    }

                /*}
                catch (SqlException e)
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: " + e.Message);
                }*/
                con.Close();

            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: " + e.Message);
                throw;
                
            }

            return contratos;
        }
    }
}
