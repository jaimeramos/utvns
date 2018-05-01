using System;
using System.IO;
using System.Net;
using System.Data;
using Newtonsoft.Json;
using Principal.EnlaceDatos;
namespace Principal.Entidades
{
    class Usuario
    {
        #region Atributos privados
        static string Entity = "users";
        string _id,  _name, _nickname, _lastname, _email, _pwd, _token, _admin;
        DateTime _expirationDate, _createdAt, _updatedAt;
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

        public string Admin
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

        public DateTime ExpirationDate
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

        public DateTime CreatedAt
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

        public DateTime UpdatedAt
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
        public DataTable read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de usuarios
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        public bool UpSert()
        {
            //accesobd.parameteradd(cmd, "@id", sqldbtype.int, this.id);
            //accesobd.parameteradd(cmd, "@nombre", sqldbtype.varchar, this.nombre);
            //accesobd.parameteradd(cmd, "@direccion", sqldbtype.varchar, this.direccion);
            //accesobd.parameteradd(cmd, "@telefono", sqldbtype.varchar, this.telefono);
            //accesobd.parameteradd(cmd, "@website", sqldbtype.varchar, this.website);
            //accesobd.parameteradd(cmd, "@id_categoria", sqldbtype.int, this.id_categoria);
            //accesobd.parameteradd(cmd, "@corporativo", sqldbtype.varchar, this.corporativo);
            //accesobd.parameteradd(cmd, "@ventasanualespromedio", sqldbtype.money, this.ventasanualespromedio);
            //accesobd.parameteradd(cmd, "@id_giro", sqldbtype.int, this.id_giro);
            //accesobd.parameteradd(cmd, "@id_sector", sqldbtype.int, this.id_sector);
            //accesobd.parameteradd(cmd, "@id_tipoforjador", sqldbtype.int, this.id_tipoforjador);
            //accesobd.parameteradd(cmd, "@activo", sqldbtype.bit, this.activo);
            //accesobd.parameteradd(cmd, "@logo", sqldbtype.varchar, this.logo);
            if (this.Id==String.Empty)
            {
            //    this.Id = Data.Post(Entity,args);
                return this.Id != String.Empty;
            }
            else
            {
                //  return Data.Update(Entity,args);
                return false;
            }
        }

        #endregion
    }
}
