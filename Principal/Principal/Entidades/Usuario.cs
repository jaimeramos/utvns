using System;
using System.Data;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    class Usuario
    {
        #region Atributos privados
        static string Entity = "users";
        string _id,  _name, _nickname, _lastname, _email, _pwd, _token, _expirationDate, _createdAt, _updatedAt;
        bool _active, _admin;
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

        public string Nickname
        {
            get
            {
                return _nickname;
            }

            set
            {
                _nickname = value;
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

        public string Pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
            }
        }

        public string Token
        {
            get
            {
                return _token;
            }

            set
            {
                _token = value;
            }
        }

        public bool Admin
        {
            get
            {
                return _admin;
            }

            set
            {
                _admin = value;
            }
        }

        public string ExpirationDate
        {
            get
            {
                return _expirationDate;
            }

            set
            {
                _expirationDate = value;
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
        /// Obtiene un DataTable con todos los usuarios
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de usuarios
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        /// <param name="opt">opt indica si trae o no contraseña</param>
        public bool upSert(bool opt)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                name = this.Name,
                lastname = this.Lastname,
                nickname = this.Nickname,
                expirationdate = this.ExpirationDate,
                email = this.Email,
                active = this.Active,
                admin = this.Admin
            });
            string jsonPwd = new JavaScriptSerializer().Serialize(new
            {
                id = this.Id,
                name = this.Name,
                lastname = this.Lastname,
                nickname = this.Nickname,
                pwd = this.Pwd,
                expirationdate = this.ExpirationDate,
                email = this.Email,
                active = this.Active,
                admin = this.Admin
            });
            string data;
            // if opt is true then data must include PWD
            if (opt)
                data = jsonPwd;
            else
                data = json;
            if (this.Id==null)
            {
                //this.Id =
                    Data.sendData(Entity, data, "POST");
                return this.Id != String.Empty;
            }
            else
            {
                    Data.sendData(Entity + "/" + this.Id, data, "PUT");
                //  return Data.Update(Entity,args);
                return false;
            }
        }

        #endregion
    }
}
