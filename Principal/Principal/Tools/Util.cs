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
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Principal.Tools
{
    class Util
    {
        public static DataTable convertToDataTable(string json)
        {
            return (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
        }
        public static void validaInteger(object sender) {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se pueden ingresar números");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
            }
        }
        public static void validaDecimal(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(((TextBox)sender).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
