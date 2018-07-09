using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLifeMetro
{
    public class Contrato
    {
        String titular;
        String numero_contrato;
        DateTime creacion;
        //DateTime termino;
        String id_plan;
        String id_poliza;
        DateTime inicio_vigencia;
        DateTime termino_vigencia;
        bool esta_vigente = false;
        bool declaracion_salud;
        float prima_anual;
        float prima_mensual;
        String observaciones;

        public Contrato()
        {
            numero_contrato = DateTime.Now.ToString("yyyyMMddHHmmss");
            creacion = DateTime.Now;
            if (DateTime.Compare(inicio_vigencia, termino_vigencia) >= 0)
                esta_vigente = true;


        }
        public Contrato(DateTime termino,int id_plan,String id_poliza, DateTime inicio_vigencia, DateTime termino_vigencia, bool declaracion_salud, float prima_anual,float prima_mensual,  String[] observaciones)
        {
            numero_contrato = DateTime.Now.ToString("yyyyMMddHHmmss");
            creacion = DateTime.Now;
            if (DateTime.Compare(inicio_vigencia, termino_vigencia) < 0)
                esta_vigente = true;

        }

        public Contrato(List<String> datos_contrato)
        {
            this.numero_contrato = datos_contrato[1];
            this.titular =datos_contrato[0];
            this.esta_vigente = bool.Parse( datos_contrato[2]);
            this.creacion = DateTime.Parse(datos_contrato[3]);
            this.id_poliza = datos_contrato[4];
            this.creacion = DateTime.Parse(datos_contrato[5]);
            this.termino_vigencia = DateTime.Parse(datos_contrato[6]); ;
            this.id_plan = datos_contrato[7];
            this.inicio_vigencia = DateTime.Parse(datos_contrato[8]);
            this.declaracion_salud = bool.Parse(datos_contrato[9]);
            this.prima_anual = float.Parse(datos_contrato[10]);
            this.prima_mensual = float.Parse(datos_contrato[11]);
            this.observaciones = datos_contrato[12];










        }

        /*public Contrato UpdateContrato(DateTime termino, int id_plan, String id_poliza, DateTime inicio_vigencia, DateTime termino_vigencia, bool declaracion_salud, float prima_anual, float prima_mensual, String[] observaciones)
        {
            //this.numero_contrato = numero_contrato;
            //this.creacion = creacion;
            this.termino = termino;
            this.id_plan = id_plan;
            this.id_poliza = id_poliza;
            this.inicio_vigencia = inicio_vigencia;
            this.termino_vigencia = termino_vigencia;
            //this.esta_vigente = esta_vigente;
            this.declaracion_salud = declaracion_salud;
            this.prima_anual = prima_anual;
            this.prima_mensual = prima_mensual;
            //String[] observaciones;
            this.esta_vigente = EstaVigente();
            return this;

        }*/

        public string GetNumero()
        {
            return this.numero_contrato;
        }

        public bool GetVigente()
        {
            return this.esta_vigente;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public DateTime GetInicioVigencia()
        {
            return this.inicio_vigencia;
        }

        public bool GetSalud()
        {
            return this.declaracion_salud;
        }

        public DateTime GetFinVigencia()
        {
            return this.termino_vigencia;
        }
        public DateTime GetCreacion()
        {
            return this.creacion;
        }

   


        public bool EstaVigente()
        {
            if (DateTime.Compare(inicio_vigencia, termino_vigencia) >= 0)
                return (esta_vigente = true);
            return(esta_vigente = false);

        }
        public float GetPrimaMensual()
        {
            return prima_mensual;
        }

        public float GetPrimaAnual()
        {
            return prima_anual;
        }
        public String GetObs()
        {
            return observaciones;
        }
        public String GetPoliza()
        {
            return id_poliza;
        }
        public List <String> InfoContratos()

        {
            List<String> datos = new List<string> { numero_contrato, this.creacion.ToString(), this.esta_vigente.ToString()};
            return datos;

        }



    }


}
