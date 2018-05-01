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
    #region atributos
        int id;
        string name, nickname, lastname, email, pwd, token, admin;
        DateTime expirationDate, createdAt, updatedAt;
        bool active;
      #endregion
       
    #region propiedades
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Pwd
        {
            get
            {
                return pwd;
            }

            set
            {
                pwd = value;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }

            set
            {
                token = value;
            }
        }

        public string Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }

            set
            {
                expirationDate = value;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }

            set
            {
                createdAt = value;
            }
        }

        public DateTime UpdatedAt
        {
            get
            {
                return updatedAt;
            }

            set
            {
                updatedAt = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }
        #endregion

    #region metodos

        public DataTable read()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://utvns-jaraga.c9users.io/api/users");
            
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            request.Headers["x-access-token"] = Data.TOKEN;
            var response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            
            DataTable dt = (DataTable) JsonConvert.DeserializeObject(content,typeof(DataTable));
            return dt;
        }
        /// <summary>
        /// Agrega registros de usuarios
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        public void UpSert()
        {
            //sqlcommand cmd = accesobd.crearsqlcomando(k_prefijo + "_upsert");
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
            //if (this._id == 0)
            //{
            //    this._id = Convert.ToInt32(AccesoBD.EjecutarSQLScalar(cmd));
            //    return this._id > 0;
            //}
            //else
            //{
            //    return AccesoBD.EjecutarSQLNonQuery(cmd) > 0;
            //}
        }

        #endregion
    }
}
