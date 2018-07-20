using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;


namespace Principal.Entidades
{
    class Proveedor
    {
        #region Atributos privados
        static string Entity = "providers";
        string _id, _number, _name, _address, _rfc, _phone1, _phone2, _email, _createdAt, _updatedAt;
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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string Rfc
        {
            get
            {
                return _rfc;
            }

            set
            {
                _rfc = value;
            }
        }

        public string Phone1
        {
            get
            {
                return _phone1;
            }

            set
            {
                _phone1 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return _phone2;
            }

            set
            {
                _phone2 = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
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
        public bool upSert(bool opt)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = this.Number,
                name = this.Name,
                address = this.Address,
                rfc = this.Rfc,
                phone1 = this.Phone1,
                phone2 = this.Phone2,
                email = this.Email,
 
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
