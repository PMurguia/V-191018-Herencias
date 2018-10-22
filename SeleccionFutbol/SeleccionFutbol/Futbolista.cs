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
           
        }

        public int GetDorsal()
        {
            return dorsal;
        }
        public string GetDemarcacion()
        {
            return demarcacion;
        }
        public string GetTipo()
        {
            return tipo;
        }

        public void SetDorsal(int dorsal)
        {
            this.dorsal = dorsal;
        }
        public void SetDemarcacion(string demarcacion)
        {
            this.demarcacion = demarcacion;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }


        public override string ToString()
        {
            return base.ToString() + "\nDorsal: " + dorsal + "\nDemarcacion: " + demarcacion;
        }
        public string ToStringFutbolista()
        {
            return base.ToStringSeleccion() + "\nDorsal: " + dorsal + "\nDemarcacion: " + demarcacion;
        }
    }
}
