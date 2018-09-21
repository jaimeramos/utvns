using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    class Detalleventasvc
    {
        #region Atributos privados
        static string Entity = "saledetailsvcs";
        string _id, _folio, _idsale, _idworkshopsvc, _svcdescription, _idmechanic, _mechname, _price, _quantity, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades públicas
        public string Id { get => _id; set => _id = value; }
        public string Folio { get => _folio; set => _folio = value; }
        public string Idsale { get => _idsale; set => _idsale = value; }
        public string Idworkshopsvc { get => _idworkshopsvc; set => _idworkshopsvc = value; }
        public string Svcdescription { get => _svcdescription; set => _svcdescription = value; }
        public string Idmechanic { get => _idmechanic; set => _idmechanic = value; }
        public string Mechname { get => _mechname; set => _mechname = value; }
        public string Price { get => _price; set => _price = value; }
        public string Quantity { get => _quantity; set => _quantity = value; }
        public string CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public bool Active { get => _active; set => _active = value; }
        #endregion

        #region metodos

        /// <summary>
        /// Obtiene un DataTable con todos los detalles de ventas
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de detalles de ventas
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>

        public bool upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                folio = 1,
                idsale = this.Idsale,
                idworkshopsvc = this.Idworkshopsvc,
                svcdescription = this.Svcdescription,
                idmechanic = this.Idmechanic,
                mechname = this.Mechname,
                price = this.Price,
                quantity = this.Quantity,
                active= this.Active
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
