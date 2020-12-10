using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public double Impuesto 
        {
            get;
            set;
        }

        public Avion(double precio, double velMax)
            :base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public override void MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Precio avion: {this._precio}");

            Console.WriteLine(sb);
        }

        double IAFIP.CalcularImpuesto()
        {
            return (this._precio * this.Impuesto);
        }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * this.Impuesto);
        }
    }
}
