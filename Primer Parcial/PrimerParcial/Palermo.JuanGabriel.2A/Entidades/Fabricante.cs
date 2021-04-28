using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabricante
    {
        #region atributos

        private string marca;
        private EPais pais;

        #endregion

        #region constructor

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        #endregion

        #region sobrecargas

        public static implicit operator String(Fabricante f)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{f.marca} - {f.pais}");

            return sb.ToString();
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {
            bool returnValue = false;

            if(String.Compare(a, b) == 0)
            {
                returnValue = true;
            }

            return returnValue;
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

        #endregion
    }
}
