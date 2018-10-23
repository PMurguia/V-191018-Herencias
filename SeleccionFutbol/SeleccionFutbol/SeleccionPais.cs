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

        public void AniadirSeleccion(Seleccion i)
        {
            if (AltaSeleccion(i) == true)
            {
                if (i.GetType().Name == "Masajista")
                {
                    numeroMasajista++;
                }
                else if (i.GetType().Name == "Seleccionador")
                {
                    numeroSeleccionador++;
                }
                Console.WriteLine("Integrante " + i.GetType().Name + " añadido.");
            }
        }
        public List<Seleccion> MostrarDatosSeleccion()
        {
            return seleccionPais;
        }

        public bool AltaSeleccion(Seleccion i)
        {
            if (seleccionPais.Count <= 30)
            {
                if (i.GetType().Name == "Masajista" && numeroMasajista < 4)
                {
                    return true;
                }
                else if (i.GetType().Name == "Seleccionador" && numeroSeleccionador < 2)
                {
                    return true;
                }
                else if (i.GetType().Name == "Futbolista")
                {
                    return true;
                }
                Console.WriteLine("No entran más " + i.GetType().Name + "s en la selección. ");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine("No entran más " + i.GetType().Name + "s en la selección. ");
            Console.ReadLine();
            return false;
        }

        public bool BajaSeleccion(Seleccion seleccion, int id)
        {
            if (seleccion.GetId() == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveSeleccion(Seleccion seleccion)
        {
            if (BajaSeleccion(seleccion, seleccion.GetId()))
            {
                if (seleccion.GetType().Name == "Masajista")
                {
                    numeroMasajista--;
                }
                else if (seleccion.GetType().Name == "Seleccionador")
                {
                    numeroSeleccionador--;
                }
            }
        }

        public void PrepararPartido()
        {
            foreach (Seleccion integrante in this.seleccionPais)
            {
                Console.WriteLine(integrante.GetType().Name.ToUpper());
                // Console.WriteLine(integrante.ToString());
                //if(integrante.GetConcentrarse() == false)
                if (integrante.GetType().Name == "Masajista")
                {
                    Console.WriteLine(integrante.GetNombre());
                    Console.WriteLine("A dar masajes");
                }
                else if (integrante.GetType().Name == "Futbolista")
                {
                    Console.WriteLine(integrante.GetNombre());
                    Console.WriteLine("A entrenar");
                }
                else if (integrante.GetType().Name == "Seleccionador")
                {
                    Console.WriteLine(integrante.GetNombre());
                    Console.WriteLine("Dirigir entrenamiento");
                }
                Console.WriteLine("********************************************");
            }
        }

        public void JugarPartido()
        {
            foreach (Seleccion integrante in this.seleccionPais)
            {
                Console.WriteLine(integrante.GetType().Name.ToUpper());
               // Console.WriteLine(integrante.ToString());
                //if(integrante.GetConcentrarse() == false)
                if (integrante.GetType().Name == "Masajista")
                {
                    Console.WriteLine(integrante.GetNombre());
                    Console.WriteLine("A dar masajes");
                }
                else if (integrante.GetType().Name == "Futbolista")
                {
                    Console.WriteLine(integrante.GetNombre());
                    Console.WriteLine("Jugar Partido");
                }
                else if (integrante.GetType().Name == "Seleccionador")
                {
                    Console.WriteLine(integrante.GetNombre());
                    Console.WriteLine("Dirigir partido");
                }
                Console.WriteLine("********************************************");
            }
        }
    }
}


