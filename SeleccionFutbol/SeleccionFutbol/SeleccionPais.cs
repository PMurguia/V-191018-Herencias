using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleccionFutbol
{
    class SeleccionPais
    {
        private string nombre;
        private List<Seleccion> seleccionPais;
        private int integrantes;
        private static int numeroSeleccionador, numeroMasajista;
   

        public SeleccionPais(string nombre)
        {
            this.nombre = nombre;
            seleccionPais = new List<Seleccion>();
        }

        public SeleccionPais(string nombre, List<Seleccion> seleccionPais)
        {
            this.nombre = nombre;
            this.seleccionPais = seleccionPais;
        }

        public void AnadirIntegrante(Seleccion i)
        {
            if (i.GetType().Name == "Seleccionador")
            {
                numeroSeleccionador++;
            }
            else if (i.GetType().Name == "Masajista")
            {
                numeroMasajista++;
            }
            seleccionPais.Add(i);
        }

        //public Boolean AnadirParticipante(Seleccion i)
        //{
        //    if(seleccionPais.Count <= 30)
        //    {
        //        if(i.GetType().Name == "Seleccionador" && numeroSeleccionador>2)
        //        {
        //            Console.WriteLine("Ya tenemos suficientes, gracias. ¿No quiere ser nuestro aguador? ");
        //            return true;
        //        }
        //        else if(i.GetType().Name == "Masajista" && numeroMasajista<4)
        //        {
        //            Console.WriteLine("Te hemos dicho que puedes ser nuestro aguador. Resto de puestos ocupados. ");
        //            return true;
        //        }
        //        else if(i.GetType().Name == "Futbolista")
        //        {
        //            return true;
        //        }
        //        Console.ReadLine();
        //    }
        //}


        public List<Seleccion> GetSeleccionPais()
        {
            return seleccionPais;
        }
    }
}
