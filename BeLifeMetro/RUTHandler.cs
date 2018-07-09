using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeLifeMetro
{
    public class RUTHandler
    {
        String rut;
        String digito;
        public RUTHandler()
        {
        }

        public bool Validar(string r, string myDigito)
        {
            /* ALGORITMO OBTENIDO DE WIKIPEDIA
             https://es.wikipedia.org/wiki/Anexo:Implementaciones_para_algoritmo_de_rut#C#
             */

            this.rut = r;
            this.digito = myDigito;
            string digito;
            int suma = 0;
            for (int x = r.Length - 1; x >= 0; x--)
                suma += int.Parse(char.IsDigit(r[x]) ? r[x].ToString() : "0") * (((r.Length - (x + 1)) % 6) + 2);
            int numericDigito = (11 - suma % 11);
            digito = numericDigito == 11 ? "0" : numericDigito == 10 ? "K" : numericDigito.ToString();

            if (myDigito.CompareTo(digito) == 0) return true;
            return false;


        }

        //Entrega un RUT de la forma 12.345.678-9
        public string Formatear(String r)
        {
            String rut_formateado = "";
            String rut_numeros = "";
            String rut_digito = "";
            if (r.Length > 0)
            {
                rut_numeros = r.Substring(0, r.Length - 1);
                rut_digito = r.Substring(r.Length - 1);
                this.rut = rut_numeros;
                this.digito = rut_digito;
            }
            if (r.Length >= 8 && r.Length <= 10)
            {
                
                rut_formateado = String.Format("{0:#,#}", int.Parse(rut_numeros));
                rut_formateado += "-";
                rut_formateado += rut_digito.ToUpper();

            }
            else
            {
                if (rut_numeros.Length > 0 && rut_digito.Length > 0)
                {

                    rut_formateado = String.Format("{0:#,#}", int.Parse(rut_numeros));
                    rut_formateado += "-";
                    rut_formateado += rut_digito.ToUpper();
                }

            }
            return rut_formateado;

        }

        public String ValidarInput( String rut_incompleto,System.Windows.Forms.KeyPressEventArgs e)
        {
            //VALIDAR EL INPUT CARACTER A CARACTER
            if (e.KeyChar.CompareTo('\b')==0 && rut_incompleto.Length >= 1)
            {
                return rut_incompleto.Substring(0,rut_incompleto.Length);
            }

            if (rut_incompleto.Length < 9)
            {
                if (rut_incompleto.Length < 7)
                {
                    if ((e.KeyChar).CompareTo('0') <= 9 && ((e.KeyChar).CompareTo('0') >= 0))
                    {
                        rut_incompleto = rut_incompleto + ((e.KeyChar).ToString());


                    }

                }
                else
                {
                    if ((e.KeyChar).CompareTo('0') <= 9 && ((e.KeyChar).CompareTo('0') >= 0) || ((e.KeyChar).CompareTo('k') == 0) || ((e.KeyChar).CompareTo('K') == 0))
                    {
                        rut_incompleto = rut_incompleto + ((e.KeyChar).ToString());
                    }
                }
            }
            e.Handled = true;
            return rut_incompleto;
            
        }
    

        public string getDigito()
        {
            return this.digito;
        }

        public string getRut()
        {
            return this.rut;
        }
    }
}
