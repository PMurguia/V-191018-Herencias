using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleccionFutbol
{
    class Futbolista : Seleccion
    {
        private int dorsal;
        private string demarcacion;
        private string tipo;

        public Futbolista()
        {
            this.tipo = "Futbolista";
        }

        public int GetDorsal()
        {
            return dorsal;
        }
        public string GetDemarcacion()
        {
            return demarcacion;
        }

        public void SetDorsal(int dorsal)
        {
            this.dorsal = dorsal;
        }
        public void SetDemarcacion(string demarcacion)
        {
            this.demarcacion = demarcacion;
        }

        public static void JugarPartido(int dorsal, string demarcacion)
        {

        }

        public static void Entrenar(int dorsal, string demarcacion)
        {

        }

        public string ToStringFutbolista()
        {
            return base.ToStringSeleccion() + "\nDorsal: " + dorsal + "\nDemarcacion: " + demarcacion + "\n" + tipo;   
        }
    }
}
