using System;
using System.IO;
using System.Net;
using System.Data;
using Newtonsoft.Json;
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
        public DataTable upsert()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://utvns-jaraga.c9users.io/api/users");

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(content, typeof(DataTable));
            return dt;
        }

        #endregion
    }
}
