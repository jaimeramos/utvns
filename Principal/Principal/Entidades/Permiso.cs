using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    public class Permiso
    {
        #region Atributos privados
        static string Entity = "permits";
        string _id, _number, _type, _description, _validity_at, _idadmin, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades públicas
        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string ValidityAt
        {
            get
            {
                return _validity_at;
            }

            set
            {
                _validity_at = value;
            }
        }

        public string Idadmin
        {
            get
            {
                return _idadmin;
            }

            set
            {
                _idadmin = value;
            }
        }

        public string CreatedAt
        {
            get
            {
                return _createdAt;
            }

            set
            {
                _createdAt = value;
            }
        }

        public string UpdatedAt
        {
            get
            {
                return _updatedAt;
            }

            set
            {
                _updatedAt = value;
            }
        }

        public bool Active
        {
            get
            {
                return _active;
            }

            set
            {
                _active = value;
            }
        }

        #endregion

        #region metodos

        /// <summary>
        /// Obtiene un DataTable con todos los Permisos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Permisos
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>

        public string upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = this.Number,
                type = this.Type,
                description = this.Description,
                validity_at = this.ValidityAt,
                idadmin = this.Idadmin,
                active=this.Active
            });

            string data;
            data = json;
            if (this.Id == null)
            {
                 return Data.sendData(Entity, data, "POST");

               // return this.Id != String.Empty;
            }
            else
            {
                return Data.sendData(Entity + "/" + this.Id, data, "PUT");

               // return false;
            }
        }
        /// <summary>
        /// Obtiene un DataTable con todos los Tipos de Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string readTypes()
        {
            return Data.getData("permitstypes");

        }
        #endregion
    }
}
