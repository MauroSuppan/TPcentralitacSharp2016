using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita unaCentralita = new Centralita("Telefonica");
            Local local1 = new Local("Calzada",30, "Adrogue",(float)2.65);
            Provincial provincial1 = new Provincial("Buenos Aires", Franja.Franja_1, 21, "Cordoba");
            Local local2 = new Local("Claypole", 45, "Burzaco", (float)1.99);
            Provincial provincial2 = new Provincial(Franja.Franja_3, provincial1);

            unaCentralita.Llamadas.Add(local1);
            unaCentralita.Llamadas.Add(provincial1);
            unaCentralita.Llamadas.Add(local2);
            unaCentralita.Llamadas.Add(provincial2);

            unaCentralita.Mostrar();


            Console.ReadLine();

        }
    }
}
