using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;
namespace Principal.Entidades
{
    public class Workshopsvc
    {
        #region Atributos
        static string Entity = "workshopsvcs";
        string _id, _number, _description, _cost;
        bool _active;
        #endregion

        #region Propiedades
        public string Number { get => _number; set => _number = value; }
        public string Description { get => _description; set => _description = value; }
        public string Cost { get => _cost; set => _cost = value; }
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
                number = 1,
                description = this.Description,
                cost = this.Cost,
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
        /// <summary>
        /// Obtiene un DataTable con todos los Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string readById(string ID)
        {
            return Data.getData(Entity + "/" + ID);

        }
        #endregion
    }
}
