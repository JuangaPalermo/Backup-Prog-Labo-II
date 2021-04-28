using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region atributos

        public ECilindrada cilindrada;

        #endregion

        #region constructores

        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada) 
            : base(precio, modelo, new Fabricante(marca, pais))
        {
            this.cilindrada = cilindrada;
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(Moto a, Moto b)
        {
            return (a.cilindrada == b.cilindrada && (Vehiculo)a == (Vehiculo)b);
        }

        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)(Vehiculo)this);
            sb.AppendLine($"CILINDRADA: {this.cilindrada}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Moto)
            {
                result = this == (Moto)obj;
            }

            return result;
        }

        #endregion

    }
}
