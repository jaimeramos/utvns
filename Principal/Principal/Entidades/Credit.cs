using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;

namespace Principal.Entidades
{
    public class Credit
    {
        #region Atributos
            static string Entity = "credits";
            string _id, _folio,  _idpermitholder, _idsale, _amount, _createdAt, _updatedAt;
            bool _active;
        #endregion

        #region Propiedades
            public string Id { get => _id; set => _id = value; }
            public string Folio { get => _folio; set => _folio = value; }
            public string Idpermitholder { get => _idpermitholder; set => _idpermitholder = value; }
            public string Idsale { get => _idsale; set => _idsale = value; }
            public string Amount { get => _amount; set => _amount = value; }
            public string CreatedAt { get => _createdAt; set => _createdAt = value; }
            public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
            public bool Active { get => _active; set => _active = value; }
        #endregion

        #region Métodos
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
                idpermitholder = this.Idpermitholder,
                idsale= this.Idsale,
                amount = this.Amount,
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
                return Data.sendData(Entity + "/" + this.Id, data, "PUT");
                //return false;
            }
        }
        
        #endregion
    }
}
