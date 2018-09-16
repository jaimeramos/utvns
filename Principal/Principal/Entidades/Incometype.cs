using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;

namespace Principal.Entidades
{
    class Incometype
    {
        #region Atributos
        static string Entity = "incometypes";
        string _id, _number, _description, _amount;
        bool _active;
        #endregion

        #region Propiedades
        public string Number { get => _number; set => _number = value; }
        public string Description { get => _description; set => _description = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public bool Active { get => _active; set => _active = value; }
        public string Id { get => _id; set => _id = value; }
        #endregion

        #region Métodos
        /// <summary>
        /// Obtiene un DataTable con todos los Proveedores
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Proveedores
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        /// <param name="opt">opt indica si trae o no contraseña</param>
        public bool upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = this.Number,
                description = this.Description,
                amount = this.Amount,
                active = this.Active
            });

            string data;

            data = json;
            if (this.Id == null)
            {

                Data.sendData(Entity, data, "POST");

                return this.Id != String.Empty;
            }
            else
            {
                Data.sendData(Entity + "/" + this.Id, data, "PUT");

                return false;
            }
        }

        #endregion
    }
}
