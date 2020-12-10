using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Auto : Vehiculo
    {
        #region FIELDS

        protected string _patente;

        #endregion

        #region CONSTRUCTOR

        public Auto (double precio, string patente)
            :base (precio)
        {
            this._patente = patente;
        }

        #endregion

        #region METHODS

        public abstract void MostrarPatente();

        #endregion


    }
}
