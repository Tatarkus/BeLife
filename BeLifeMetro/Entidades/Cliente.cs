using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLifeMetro
{
    public class Cliente
    {
     
        private String rut;
        private String nom;
        private String ape;
        private DateTime fec_nac;
        private int sexo;
        private int estado;

        public Cliente(String rut, String nom, String ape, DateTime fec_nac, int sexo, int estado)
        {
            this.rut = rut;
            this.nom = nom;
            this.ape = ape;
            this.fec_nac = fec_nac;
            this.sexo = sexo;
            this.estado = estado;




        }

        public Cliente(List <String> datos_cliente)
        {
            this.rut = datos_cliente[0];
            this.nom = datos_cliente[1];
            this.ape = datos_cliente[2];
            this.fec_nac = DateTime.Parse(datos_cliente[3]);
            this.sexo = int.Parse( datos_cliente[4]);
            this.estado = int.Parse(datos_cliente[5]);




        }

        public Cliente()
        {
        }


        public String GetRut()
        {
           return this.rut;  

        }

        public void SetRut(String rut)
        {
            this.rut = rut;
        }


        public String GetNom()
        {

                return nom;
   

        }

        public void SetNom(String nom)
        {
            this.nom = nom;
        }

        public String getApe()
        {
            return this.ape;
        }

        public void SetApe(String ape)
        {
            this.ape = ape;
        }
        public DateTime GetFec ()
        {
            
                return this.fec_nac;

            
        }

        public void SetFecNac(DateTime fecnac)
        {
            this.fec_nac = fecnac;
        }



        public void SetSexo(int sexo)
        {
            this.sexo = sexo;
        } 
        

        public int GetSexo()
        {
            return sexo;
        }


        public int GetEstado()
        {
            return estado;
        }

        public String GetEstadoString()
        {
            char vocal_genero;
            if (this.sexo == 1) {
                vocal_genero = 'o';
            } else { vocal_genero = 'a'; }

            switch (this.estado)
            {
                case 1:
                    return "Solter"+vocal_genero;
                case 2:
                    return "Casad" + vocal_genero;
                case 3:
                    return "Divorciad" + vocal_genero;

                default:
                    return "Viud" + vocal_genero;
            }
        }

        public String GetSexoString() {
            if (this.sexo == 1)
                return "Hombre";
            return "Mujer";
        }

        public void SetEstado(int estado)
        {
            this.estado = estado;
        }



    }

}

