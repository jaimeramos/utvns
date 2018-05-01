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
        class validLogin {
           public string token,success,name,message;
        };
        public static bool Login(string usr, string pwd) {
            validLogin json = JsonConvert.DeserializeObject<validLogin>(getAuth("authenticate", new string[] { usr, pwd }));
            if (json.success != null) {
                if (json.success == "true") {
                    TOKEN = json.token;
                }
            }
            return  json.success!=null;
        }
        public static string getAuth(string name, string[] args) {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + name);
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
