using System.Collections.Generic;
using System;

namespace SeleccionFutbol
{

    class Program
    {
        static void Main(string[] args)
        {

            Futbolista f1 = new Futbolista();
            f1.SetId(10);
            f1.SetNombre("Lionel ");
            f1.SetApellido(" MESSI");
            f1.SetEdad(32);
            f1.SetDorsal(10);
            f1.SetDemarcacion("Falso nueve");
            f1.SetViajar(true);
            f1.SetConcentrarse(false);



            Futbolista f2 = new Futbolista();
            f2.SetId(1);
            f2.SetNombre("Marc André ");
            f2.SetApellido(" Ter Stegen ");
            f2.SetEdad(25);
            f2.SetDorsal(1);
            f2.SetDemarcacion("Portero");
            f2.SetViajar(true);
            f2.SetConcentrarse(false);

            Futbolista f3 = new Futbolista();
            f3.SetId(5);
            f3.SetNombre("Sergio ");
            f3.SetApellido(" Busquets");
            f3.SetEdad(32);
            f3.SetDorsal(5);
            f3.SetDemarcacion("Mediocentro Defensivo. ");
            f3.SetViajar(true);
            f3.SetConcentrarse(false);

            Futbolista f4 = new Futbolista();
            f4.SetId(18);
            f4.SetNombre("Jordi ");
            f4.SetApellido(" Alba");
            f4.SetEdad(28);
            f4.SetDorsal(18);
            f4.SetDemarcacion("Lateral Izquierdo. ");
            f4.SetViajar(true);
            f4.SetConcentrarse(false);

            Masajista m1 = new Masajista();
            m1.SetId(101);
            m1.SetNombre("ciento ");
            m1.SetApellido(" uno");
            m1.SetEdad(38);
            m1.SetTitulacion("Osteopata");
            m1.SetAniosExp(10);
            m1.SetViajar(true);
            m1.SetConcentrarse(false);


            Masajista m2 = new Masajista();
            m2.SetId(201);
            m2.SetNombre("Doscientos ");
            m2.SetApellido(" Uno");
            m2.SetEdad(38);
            m2.SetTitulacion("Osteopata");
            m2.SetAniosExp(10);
            m2.SetViajar(true);
            m2.SetConcentrarse(false);


            Seleccionador s1 = new Seleccionador();
            s1.SetId(102);
            s1.SetNombre("Armando ");
            s1.SetApellido(" Maradona");
            s1.SetEdad(48);
            s1.SetIdFederacion("Argentina");
            s1.SetViajar(true);
            s1.SetConcentrarse(false);


            List<Seleccion> seleccions = new List<Seleccion>
            {
                f1,f2,f3,f4,m1,m2,s1
            };

            SeleccionPais sp = new SeleccionPais("paris", seleccions);



            //List<Futbolista> Futbolistas = new List<Futbolista>
            //{
            //    f1,
            //    f2,
            //    f3,
            //    f4
            //};

            //    List<Seleccionador> Selec = new List<Seleccionador>
            //    {
            //        s1
            //    };

            //    List<Masajista> Masajistas = new List<Masajista>
            //    {
            //        m1,
            //        m2
            //    };

            //    foreach (Futbolista x in Futbolistas)
            //    {
            //        Console.WriteLine(x.ToStringFutbolista());
            //        Console.WriteLine("A entrenar. ");
            //    }

            //    foreach (Seleccionador x in Selec)
            //    {
            //        Console.WriteLine(x.ToStringSeleccionador());
            //        Console.WriteLine("A dirigir");
            //    }

            //    foreach (Masajista x in Masajistas)
            //    {
            //        Console.WriteLine(x.ToStringMasajista());
            //        Console.WriteLine("A dar masajes. ");

            //    }


            Console.WriteLine("\t\t\t\t##########---SELECCION LAMASIA DE FUTBOL---##########\n");

            foreach (Seleccion integrante in seleccions)
            {
                Console.WriteLine(integrante.GetType().Name.ToUpper());
                Console.WriteLine(integrante.ToString());
                //if (integrante.GetConcentrarse() == false)
                if (integrante.GetType().Name == "Masajista")
                {
                    Console.WriteLine("A dar masajes");
                }
                else if (integrante.GetType().Name == "Futbolista")
                {
                    Console.WriteLine("A entrenar");
                }
                else if (integrante.GetType().Name == "Seleccionador")
                {
                    Console.WriteLine("A dirigir");
                }
                Console.WriteLine("********************************************");
            }
            Console.WriteLine("Integrantes totales: " + seleccions.Count);
            Console.ReadLine();


            sp.JugarPartido();
            Console.WriteLine();
            sp.PrepararPartido();
            Console.WriteLine();
            Console.ReadLine();


            const int ALTA = 1, BAJA = 2, SHOW = 3, PREPARE = 4, MATCH = 5, EXIT = 6;
            int option;

            do
            {



                Console.WriteLine("Menú");
                Console.WriteLine("1. Alta de participante");
                Console.WriteLine("2. Baja de participante");
                Console.WriteLine("3. Mostrar datos de seleccion");
                Console.WriteLine("4. Preparar partido");
                Console.WriteLine("5. Jugar partido");
                Console.WriteLine("6. Salir");
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case ALTA:
                        Console.WriteLine("Puesto (Masajista, Seleccionador o Futbolista)");
                        string puesto = Console.ReadLine();
                        Console.WriteLine("Numero Id.");
                        int id = Int32.Parse(Console.ReadLine();
                        Console.WriteLine("Nombre");
                        string nombre = Console.ReadLine();
                        Console.Write("Apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Edad");
                        int edad = Int32.Parse(Console.ReadLine());

                        if (puesto.ToUpper() == "Masajista")
                        {
                            Console.WriteLine("Titulacion");
                            string titulacion = Console.ReadLine();
                            Masajista m3 = new Masajista(nombre,
                        }
                }

            } while (option != EXIT);
        }
    }
}