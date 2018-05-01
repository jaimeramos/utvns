using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Principal.EnlaceDatos
{
    class Data
    {
        public static string TOKEN = "";
        private static string url = "https://utvns-jaraga.c9users.io/api/";
        //Session State
        class validLogin {
           public string token,success,name,message;
        };
        
        /// <summary>
        /// Realiza el inicio de sesión
        /// </summary>
        /// <param name="usr">Nombre de usuario</param>
        /// <param name="pwd">Contraseña</param>
        /// <returns>Devuelve true si las credenciales son correctas, false si no</returns>
        public static bool Login(string usr, string pwd) {
            validLogin json = JsonConvert.DeserializeObject<validLogin>(getAuth("authenticate", new string[] { usr, pwd }));
            if (json.success != null) {
                if (json.success == "true") {
                    TOKEN = json.token;
                }
            }
            return  json.success!=null;
        }

        /// <summary>
        /// Permite obtener los registros de la entidad
        /// </summary>
        /// <param name="Entity">Nombre de la entidad</param>
        /// <returns>Regresa un DataTable</returns>
        public static DataTable getData(string Entity) {

            var request = (HttpWebRequest)WebRequest.Create(url+Entity);
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
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(content, typeof(DataTable));
            return dt;
        }
        /// <summary>
        /// Realiza la autenticación mediante la API
        /// </summary>
        /// <param name="entity">Nombre de la entidad</param>
        /// <param name="args">Arreglo con las credenciales de acceso</param>
        /// <returns>Objeto JSON en string con detalles de la autenticación</returns>
        public static string getAuth(string entity, string[] args) {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + entity);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new

            StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    nickname = args[0],
                    pwd = args[1]
                });

                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                 result = streamReader.ReadToEnd();
            }
            return result;
        }
    }
}
