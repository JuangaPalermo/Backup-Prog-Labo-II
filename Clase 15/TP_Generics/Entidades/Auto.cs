using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        //ATRIBUTOS

        string _color;
        string _marca;

        //PROPIEDADES

        public string Color
        {
            get
            {
                return this._color;
            }
        }
        
        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        //CONSTRUCTOR

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        //SOBRECARGAS

        public override bool Equals(object obj)
        {
            bool result = false;

            if(obj is Auto)
            {
                result = this == (Auto)obj;
            }

            return result;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return (a._marca == b._marca && a._color == b._color);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this._marca} - Color: {this._color}");

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
