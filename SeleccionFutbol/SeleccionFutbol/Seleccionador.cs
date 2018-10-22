using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleccionFutbol
{
    class Seleccionador : Seleccion
    {
        private string idFederacion;
        private string tipo;
      

        public Seleccionador()
        {
           
        }

        public string GetIdFederacion()
        {
            return idFederacion;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public void SetIdFederacion(string idFederacion)
        {
            this.idFederacion = idFederacion;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }


        public override string ToString()
        {
            return base.ToString() + "\nId. Federacion: " + idFederacion;
        }
        public string ToStringSeleccionador()
        {
            return base.ToStringSeleccion() + "\nId. Federacion: " + idFederacion;
        }
    }
}
