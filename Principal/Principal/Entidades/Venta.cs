using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;


namespace Principal.Entidades
{
    public class Venta
    {
        #region Atributos privados
        static string Entity = "sales";
        string _id, _folio, _receiptnumber, _idpermitholder, _type, _amount, _date, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades públicas
        public string Id { get => _id; set => _id = value; }
        public string Folio { get => _folio; set => _folio = value; }
        public string Receiptnumber { get => _receiptnumber; set => _receiptnumber = value; }
        public string Idpermitholder { get => _idpermitholder; set => _idpermitholder = value; }
        public string Type { get => _type; set => _type = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Date { get => _date; set => _date = value; }
        public string CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public bool Active { get => _active; set => _active = value; }
        #endregion

        #region metodos

        /// <summary>
        /// Obtiene un DataTable con todas las ventas
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de ventas
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>

        public string upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                folio = 1,
                receiptnumber = 1,
                idpermitholder = this.Idpermitholder,
                type = this.Type,
                amount = this.Amount,
                date = this.Date
                //active=this.Active
            });

            string data;
            data = json;
            if (this.Id == null)
            {
                return Data.sendData(Entity, data, "POST");
                //return this.Id != String.Empty;
            }
            else
            {
              return  Data.sendData(Entity + "/" + this.Id, data, "PUT");
                //return false;
            }
        }
        /// <summary>
        /// Obtiene un DataTable con todos los Tipos de Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string readTypes()
        {
            return Data.getData("salestypes");

        }
        #endregion
    }
}
