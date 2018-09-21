using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;
using Principal.Entidades;
namespace Principal.Entidades
{
    public class Incomedetail
    {
        #region Atributos
        static string Entity = "incomedetails";
        private string _id, _folio, _idincome, _idincometype, _itdescription, _idbusinessline,_blname, _amount, _datecovered, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades
        public string Id { get => _id; set => _id = value; }
        public string Folio { get => _folio; set => _folio = value; }
        public string Idincome { get => _idincome; set => _idincome = value; }
        public string Idincometype { get => _idincometype; set => _idincometype = value; }
        public string Idbusinessline { get => _idbusinessline; set => _idbusinessline = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Datecovered { get => _datecovered; set => _datecovered = value; }
        public string CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public bool Active { get => _active; set => _active = value; }
        public string Itdescription { get => _itdescription; set => _itdescription = value; }
        public string Blname { get => _blname; set => _blname = value; }
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
                idincome = this.Idincome,
                idincometype = this.Idincometype,
                itdescription= this.Itdescription,
                idbusinessline=this. Idbusinessline,
                blname= this.Blname,
                amount = this.Amount,
                datecovered= this.Datecovered
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
