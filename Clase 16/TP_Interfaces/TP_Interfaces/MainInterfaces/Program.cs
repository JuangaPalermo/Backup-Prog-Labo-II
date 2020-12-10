using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace MainInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta carreta = new Carreta(5000);
            Familiar familiar = new Familiar(100000, "abc123", 4);
            Deportivo deportivo = new Deportivo(200000, "def456", 2);
            Avion avion = new Avion(444444, 10000);
            Privado privado = new Privado(555555, 20000, 5);
            Comercial comercial = new Comercial(666666, 30000, 600);

            Console.WriteLine("CALCULOS CON AFIP:");

            deportivo.Impuesto = 0.28;
            avion.Impuesto = 0.33;
            privado.Impuesto = 0.33;
            comercial.Impuesto = 0.33;

            Console.WriteLine(Gestion.MostrarImpuestoNacional(deportivo));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avion));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(privado));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(comercial));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("CALCULOS CON ARBA: ");

            carreta.Impuesto = 0.18;
            avion.Impuesto = 0.27;
            deportivo.Impuesto = 0.23;
            comercial.Impuesto = 0.25;

            Console.WriteLine(Gestion.MostrarImpuestoProvincial(carreta));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(avion));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(comercial));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(deportivo));

            Console.ReadLine();

        }
    }
}
