using System.Collections.Generic;
using System;

namespace SeleccionFutbol
{

    class Program
    {
        static void Main(string[] args)
        {
           
            int cont = 0;

            Futbolista f1 = new Futbolista();
            f1.SetId(10);
            f1.SetNombre("Lionel ");
            f1.SetApellido(" MESSI");
            f1.SetEdad(32);
            f1.SetDorsal(10);
            f1.SetDemarcacion("Falso nueve");
            f1.SetViajar(true);
            f1.SetConcentrarse(true);
            

            Futbolista f2 = new Futbolista();
            f2.SetId(1);
            f2.SetNombre("Marc André ");
            f2.SetApellido(" Ter Stegen ");
            f2.SetEdad(25);
            f2.SetDorsal(1);
            f2.SetDemarcacion("Portero");

            Futbolista f3 = new Futbolista();
            f3.SetId(5);
            f3.SetNombre("Sergio ");
            f3.SetApellido(" Busquets");
            f3.SetEdad(32);
            f3.SetDorsal(5);
            f3.SetDemarcacion("Mediocentro Defensivo. ");

            Futbolista f4 = new Futbolista();
            f4.SetId(18);
            f4.SetNombre("Jordi ");
            f4.SetApellido(" Alba");
            f4.SetEdad(28);
            f4.SetDorsal(18);
            f4.SetDemarcacion("Lateral Izquierdo. ");

            Masajista m1 = new Masajista();
            m1.SetId(101);
            m1.SetNombre("ciento ");
            m1.SetApellido(" uno");
            m1.SetEdad(38);
            m1.SetTitulacion("Osteopata");
            m1.SetAniosExp(10);
        

            Masajista m2 = new Masajista();
            m2.SetId(201);
            m2.SetNombre("Doscientos ");
            m2.SetApellido(" Uno");
            m2.SetEdad(38);
            m2.SetTitulacion("Osteopata");
            m2.SetAniosExp(10);
            

            Seleccionador s1 = new Seleccionador();
            s1.SetId(102);
            s1.SetNombre("Armando ");
            s1.SetApellido(" Maradona");
            s1.SetEdad(48);
            s1.SetIdFederacion("Argentina");


            List<Futbolista> Futbolistas = new List<Futbolista>
            {
                f1,
                f2,
                f3,
                f4
            };

            List<Seleccionador> Selec = new List<Seleccionador>
            {
                s1
            };

            List<Masajista> Masajistas = new List<Masajista>();
            Masajistas.Add(m1);
          

            Console.WriteLine("\t\t\t\t##########---SELECCION LAMASIA DE FUTBOL---##########\n");

            Console.WriteLine(Seleccion.Contador(cont));

            foreach (Futbolista x in Futbolistas)
            {
                Console.WriteLine(x.ToStringFutbolista());
               
                
            }

            foreach(Seleccionador x in Selec)
            {
                Console.WriteLine(x.ToStringSeleccionador());
               
            }

            foreach(Masajista x in Masajistas)
            {
                Console.WriteLine(x.ToStringMasajista());

            }

            Console.ReadLine();



        }
    }
}