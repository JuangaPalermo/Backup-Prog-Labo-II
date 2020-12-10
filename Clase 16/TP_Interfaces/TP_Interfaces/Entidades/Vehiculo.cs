using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region FIELDS

        protected double _precio;

        #endregion

        #region CONSTRUCTOR

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

        #endregion

        #region METHODS

        public abstract void MostrarPrecio();

        #endregion

    }
}
