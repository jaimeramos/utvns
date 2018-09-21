using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;
namespace Principal.Entidades
{
    public class Sparepart
    {
        #region Atributos
        static string Entity = "spareparts";
        string _id,_number, _description, _cost, _price, _stock, _idprovider;
        bool _active;
        #endregion

        #region Propiedades
        public string Number { get => _number; set => _number = value; }
        public string Description { get => _description; set => _description = value; }
        public string Cost { get => _cost; set => _cost = value; }
        public string Price { get => _price; set => _price = value; }
        public string Stock { get => _stock; set => _stock = value; }
        public string Idprovider { get => _idprovider; set => _idprovider = value; }
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
                cost = this.Cost,
                price = this.Price,
                stock = this.Stock,
                idprovider = this.Idprovider,
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
