using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    class Egreso
    {
        #region Atributos privados
        static string Entity = "outcomes";
        string _id, _folio, _description, _reference, _type, _amount, _idbusinessline, _date, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades públicas
        public string Id { get => _id; set => _id = value; }
        public string Folio { get => _folio; set => _folio = value; }
        public string Description { get => _description; set => _description = value; }
        public string Reference { get => _reference; set => _reference = value; }
        public string Type { get => _type; set => _type = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Idbusinessline { get => _idbusinessline; set => _idbusinessline = value; }
        public string Date { get => _date; set => _date = value; }
        public string CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public bool Active { get => _active; set => _active = value; }
        #endregion

        #region metodos

        /// <summary>
        /// Obtiene un DataTable con todos los Egresos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Egreso
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>

        public bool upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                folio = 1,
                description = this.Description,
                reference = this.Reference,
                type = this.Type,
                idbusinessline = this.Idbusinessline,
                amount = this.Amount,
                date = this.Date,
                active=this.Active

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
        /// Obtiene un DataTable con todos los Tipos de Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string readTypes()
        {
            return Data.getData("outcomestypes");

        }
        #endregion
    }
}
