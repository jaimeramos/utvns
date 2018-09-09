using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.Entidades;
namespace Principal.Tools
{
    class Util
    {
        public static DataTable convertToDataTable(string json)
        {
            return (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
        }
    }
}
