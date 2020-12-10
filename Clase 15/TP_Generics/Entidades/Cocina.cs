using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        //ATRIBUTOS

        int _codigo;
        bool _esIndustrial;
        double _precio;

        //PROPIEDADES

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio 
        { 
            get
            {
                return this._precio;
            }
        }

        // CONSTRUCTOR  

        public Cocina (int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        //SOBRECARGAS

        public override bool Equals(object obj)
        {
            return (obj is Cocina && this == (Cocina)obj);
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return (a.Codigo == b.Codigo && a.EsIndustrial == b.EsIndustrial && a.Precio == b.Precio);
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {this.Codigo} - Precio: {this.Precio} - Es industrial? {this.EsIndustrial}");

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
