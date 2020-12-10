using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        //ATRIBUTOS

        int _capacidadMaxima;
        List<Cocina> _lista;

        //CONSTRUCTOR

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>(capacidad);
        }

        //METODOS

        private int GetIndice (Cocina c)
        {
            return this._lista.IndexOf(c);
        }

        public bool Agregar(Cocina c)
        {
            return (this + c);
        }

        public bool Remover(Cocina c)
        {
            return (this - c);
        }

        //SOBRECARGAS

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool resultado = false;

            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                resultado = true;
            }

            return resultado;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool resultado = false;

            if(d.GetIndice(c) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(c));
                resultado = true;
            }

            return resultado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad maxima: {this._capacidadMaxima}");
            sb.AppendLine("Listado de cocinas:");
            foreach(Cocina aux in this._lista)
            {
                sb.Append(aux.ToString());
            }

            return sb.ToString();
        }

    }
}
