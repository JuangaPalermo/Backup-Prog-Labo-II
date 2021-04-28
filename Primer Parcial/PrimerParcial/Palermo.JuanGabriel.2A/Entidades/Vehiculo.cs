using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region atributos

        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        #endregion

        #region propiedades

        public int VelocidadMaxima
        {
            get
            {
                if(this.velocidadMaxima == 0)
                {
                    this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);
                }

                return this.velocidadMaxima;
            }
        }

        #endregion

        #region constructores

        static Vehiculo()
        {
            generadorDeVelocidades = new Random();
        }

        public Vehiculo(float precio, string modelo, Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
            this.velocidadMaxima = VelocidadMaxima;
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio)
            :this(precio, modelo, new Fabricante(marca,pais))
        {
        }

        #endregion

        #region metodos

        private static string Mostrar (Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"FABRICANTE: {(String)v.fabricante}");
            sb.AppendLine($"MODELO: {v.modelo}");
            sb.AppendLine($"VELOCIDAD MAXIMA: {v.velocidadMaxima}");
            sb.AppendLine($"PRECIO: {v.precio}");

            return sb.ToString();
        }

        #endregion

        #region sobrecargas

        public static bool operator == (Vehiculo a, Vehiculo b)
        {
            bool returnValue = false;

            if(String.Compare(a.modelo, b.modelo) == 0 && String.Compare(a.fabricante, b.fabricante) == 0)
            {
                returnValue = true;
            }

            return returnValue;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static explicit operator String (Vehiculo v)
        {
            return Mostrar(v);
        }

        #endregion
    }
}
