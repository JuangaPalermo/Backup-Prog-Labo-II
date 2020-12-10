using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public double Impuesto
        {
            get;
            set;
        }

        public Deportivo(double precio, string patente, int hp)
            :base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public override void MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Precio deportivo: {this._precio}");

            Console.WriteLine(sb);
        }

        public override void MostrarPatente()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Patente: {this._patente}");

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
