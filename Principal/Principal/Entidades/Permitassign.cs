using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;
namespace Principal.Entidades
{
    class Permitassign
    {
        #region Atributos privados
        static string Entity = "permitassign";
        private string _id, _idpermit, _idpermitholder, _idadmin, _dateassigned, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades publicas

        public string Id { get => _id; set => _id = value; }
        public string Idpermit { get => _idpermit; set => _idpermit = value; }
        public string Idpermitholder { get => _idpermitholder; set => _idpermitholder = value; }
        public string Idadmin { get => _idadmin; set => _idadmin = value; }
        public string Dateassigned { get => _dateassigned; set => _dateassigned = value; }
        public string CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public bool Active { get => _active; set => _active = value; }

        #endregion

        #region metodos

        /// <summary>
        /// Obtiene un DataTable con todos los Permisosvehiculos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Permisosvehiculos
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>

        public string upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                idpermit = this.Idpermit,
                idpermitholder = this.Idpermitholder,
                idadmin= this.Idadmin,
                dateassigned = this.Dateassigned,
                active = this.Active
            });

            string data;
            data = json;
            if (this.Id == null)
            {
                string d = Data.sendData(Entity, data, "POST");
                return d;
            }
            else
            {
                return Data.sendData(Entity + "/" + this.Id, data, "PUT");
            }
        }
        #endregion
    }
}
