using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Entidades
{
    class Vehiculo
    {
        #region atributos
        private int numero = 0;
        #endregion

        #region Propiedades
        /// <summary>
        /// Almacena un numero economico del vehiculo
        /// entre 0 y 500
        /// </summary>
        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                if(value<=500)
                    numero = value;
            }
        }
        #endregion

        #region metodos
        
        /// <summary>
        /// Devuelve la marca del ve
        /// </summary>
        /// <param name="y">Numero economico</param>
        /// <returns></returns>
        public string dimeMarca(int y) {
            return "La pínche marca es" + this.Numero;
        }
        #endregion
    }
}
