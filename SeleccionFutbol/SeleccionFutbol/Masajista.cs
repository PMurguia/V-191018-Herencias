using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleccionFutbol
{
    class Masajista : Seleccion
    {
        private string titulacion;
        private int aniosExp;
        private string tipo;

        public Masajista()
        {
            this.tipo = "Masajista";
        }

        public string GetTitulacion()
        {
            return titulacion;
        }
        public int GetAniosExp()
        {
            return aniosExp;
        }

        public void SetTitulacion(string titulacion)
        {
            this.titulacion = titulacion;
        }
        public void SetAniosExp(int aniosExp)
        {
            this.aniosExp = aniosExp;
        }

        public static void DarMasaje(string titulacion, int aniosExp)
        {

        }

        public string ToStringMasajista()
        {
            return base.ToStringSeleccion() + "Titulacion: " + titulacion + " Años de experiencia: " + aniosExp + "\n" + tipo;
        }
    }
}
