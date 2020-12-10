using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos)
            :base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }

        public override void MostrarPatente()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Patente familiar: {this._patente}");

            Console.WriteLine(sb);
        }

        public override void MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Precio familiar: {this._precio}");

            Console.WriteLine(sb);
        }
    }
}
