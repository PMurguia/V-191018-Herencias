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
            this.tipo = "seleccionador";
        }

        public string GetIdFederacion()
        {
            return idFederacion;
        }
        public void SetIdFederacion(string idFederacion)
        {
            this.idFederacion = idFederacion;
        }

        public static void DirigirPartido(string idFederacion)
        {

        }

        public string ToStringSeleccionador()
        {
            return base.ToStringSeleccion() + "\nId. Federacion: " + idFederacion + "\n" + tipo;
        }
    }
}
