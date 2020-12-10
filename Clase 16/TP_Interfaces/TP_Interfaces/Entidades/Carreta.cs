using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta : Vehiculo, IARBA
    {

        public double Impuesto
        {
            get;
            set;
        }

        #region CONSTRUCTOR

        public Carreta(double precio)
            :base(precio)
        {

        }

        #endregion

        #region METHODS

        public override void MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Precio carreta: {this._precio}");

            Console.WriteLine(sb);
        }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * this.Impuesto);
        }

        #endregion
    }
}
