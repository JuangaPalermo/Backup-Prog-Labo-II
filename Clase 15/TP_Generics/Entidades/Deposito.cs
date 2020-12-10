using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito <T>
    {
        int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>(capacidad);
        }

        //METODOS

        private int GetIndice(T g)
        {
            int retorno = -1;
            int i = 0;
            foreach(T aux in this._lista)
            {
                if(aux.Equals(g))
                {
                    retorno = 1;
                    break;
                }
                i++;
            }

            return retorno;
        }

        public bool Agregar(T g)
        {
            return (this + g);
        }

        public bool Remover(T g)
        {
            return (this - g);
        }

        //SOBRECARGAS

        public static bool operator +(Deposito<T> g, T a)
        {
            bool resultado = false;

            if (g._lista.Count < g._capacidadMaxima)
            {
                g._lista.Add(a);
                resultado = true;
            }

            return resultado;
        }

        public static bool operator -(Deposito<T> g, T a)
        {
            bool resultado = false;

            if (g.GetIndice(a) != -1)
            {
                g._lista.RemoveAt(g.GetIndice(a));
                resultado = true;
            }

            return resultado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad maxima: {this._capacidadMaxima}");
            sb.AppendLine($"Listado de Elementos {typeof(T).Name}");
            
            foreach (T aux in this._lista)
            {
                sb.Append(aux.ToString());
            }

            return sb.ToString();
        }
    }
}
