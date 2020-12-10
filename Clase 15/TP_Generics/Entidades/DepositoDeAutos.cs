using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        //ATRIBUTOS

        int _capacidadMaxima;
        List<Auto> _lista;

        //CONSTRUCTOR

        public DepositoDeAutos (int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>(capacidad);
        }

        //METODOS

        private int GetIndice(Auto a)
        {
            //int result = -1;
            //foreach(Auto aux in this._lista)
            //{
            //    if(a.Equals(aux))
            //    {
            //        result = this._lista.IndexOf(aux);
            //        break;
            //    }
            //}

            return this._lista.IndexOf(a);
        }

        public bool Agregar(Auto a)
        {
            return (this + a);
        }

        public bool Remover(Auto a)
        {
            return (this - a);
        }

        //SOBRECARGAS

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool result = false;

            if(d._capacidadMaxima > d._lista.Count())
            {
                d._lista.Add(a);
                result = true;
            }

            return result;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool resultado = false;

            if(d.GetIndice(a) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(a));
                resultado = true;
            }

            return resultado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad maxima: {this._capacidadMaxima}");
            sb.AppendLine($"Listado de autos:");
            foreach(Auto a in this._lista)
            {
                sb.Append(a.ToString());
            }

            return sb.ToString();
        }

    }
}
