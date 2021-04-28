using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        #region atributos 

        int capacidad;
        List<Vehiculo> vehiculos;

        #endregion

        #region Propiedades

        public double PrecioDeAutos
        {
            get { return ObtenerPrecio(EVehiculo.PrecioDeAutos); }
        }

        public double PrecioDeMotos
        {
            get { return ObtenerPrecio(EVehiculo.PrecioDeMotos); }
        }

        public double PrecioTotal
        {
            get { return ObtenerPrecio(EVehiculo.PrecioTotal); }
        }

        #endregion

        #region constructores

        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Concesionaria(int capacidad)
            :this()
        {
            this.capacidad = capacidad;
        }

        #endregion

        #region metodos

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad: {c.capacidad}");
            sb.AppendLine($"Total por autos: {c.PrecioDeAutos}");
            sb.AppendLine($"Total por motos: {c.PrecioDeMotos}");
            sb.AppendLine($"Total: {c.PrecioTotal}");

            foreach (Vehiculo item in c.vehiculos)
            {
                sb.AppendLine(item.ToString());                
            }

            return sb.ToString();
        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double total = 0;

            
            switch(tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    foreach (Vehiculo aux in vehiculos)
                    {
                        if (aux is Auto autos)
                        {
                            total += (Single)autos;
                        }
                    }
                    break;
                case EVehiculo.PrecioDeMotos:
                    foreach (Vehiculo aux in vehiculos)
                    {
                        if (aux is Moto autos)
                        {
                            total += (Single)autos;
                        }
                    }
                    break;
                case EVehiculo.PrecioTotal:
                    total = PrecioDeAutos + PrecioDeMotos;
                    break;
            }

            return total;
        }



        #endregion

        #region sobrecargas

        public static implicit operator Concesionaria (int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator ==(Concesionaria g, Vehiculo m)
        {
            return g.vehiculos.Equals(m);
        }

        public static bool operator !=(Concesionaria g, Vehiculo m)
        {
            return !(g == m);
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            if(c.capacidad > c.vehiculos.Count())
            {
                if(c!=v)
                {
                    c.vehiculos.Add(v);
                }
                else
                {
                    Console.WriteLine("El vehiculo ya esta en la concesionaria!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la concesionaria!!!");
            }

            return c;
        }

        #endregion
    }
}
