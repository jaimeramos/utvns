using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    public class Permisionario
    {
        #region Atributos privados
        static string Entity = "permitholders";
        string _id, _number, _firstname, _lastname, _address, _rfc, _phone1, _phone2, _email, _type, _license, _licensevalidity, _dateadmission, _createdAt, _updatedAt;
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

        public string Firstname
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
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

        public string License
        {
            get
            {
                return _license;
            }

            set
            {
                _license = value;
            }
        }

        public string LicenseValidity
        {
            get
            {
                return _licensevalidity;
            }

            set
            {
                _licensevalidity = value;
            }
        }

        public string DateAdmission
        {
            get
            {
                return _dateadmission;
            }

            set
            {
                _dateadmission = value;
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
        /// Obtiene un DataTable con todos los Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Obtiene un DataTable con todos los Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string readById(string ID)
        {
            return Data.getData(Entity+"/"+ID);

        }
        /// <summary>
        /// Agrega registros de Permisionarios
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        /// <param name="opt">opt indica si trae o no contraseña</param>
        public bool upSert()
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = this.Number,
                firstname = this.Firstname,
                lastname = this.Lastname,
                address = this.Address,
                rfc = this.Rfc,
                phone1 = this.Phone1,
                phone2 = this.Phone2,
                email = this.Email,
                type = this.Type,
                license = this.License,
                licensevalidity = this.LicenseValidity,
                dateadmission = this.DateAdmission,
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
        /// Obtiene un DataTable con todos los Tipos de Permisionarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string readTypes()
        {
            return Data.getData("permitholderstypes");

        }
        #endregion
    }
}
