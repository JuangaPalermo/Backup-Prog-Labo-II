using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region atributos

        public ETipo tipo;

        #endregion

        #region constructor
        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo)
            : base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }

        #endregion

        #region sobrecargas

        public static bool operator == (Auto a, Auto b)
        {
            return (a.tipo == b.tipo && (Vehiculo)a == (Vehiculo)b);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)(Vehiculo)this);
            sb.AppendLine($"TIPO: {this.tipo}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Auto)
            {
                result = this == (Auto)obj;
            }

            return result;
        }


        #endregion
    }
}
