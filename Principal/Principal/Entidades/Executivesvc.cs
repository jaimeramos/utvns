using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Principal.EnlaceDatos;
namespace Principal.Entidades
{
    class Executivesvc
    {
        #region Atributos
        static string Entity = "executivesvcs";
        string _id, _number, _linenumber, _imei, _simcard, _model, _brand, _contractnumber, _validity, _startdate, _cutoffdate, _amount, _idvehicle, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades
        public string Id { get => _id; set => _id = value; }
        public string Number { get => _number; set => _number = value; }
        public string Linenumber { get => _linenumber; set => _linenumber = value; }
        public string Imei { get => _imei; set => _imei = value; }
        public string Simcard { get => _simcard; set => _simcard = value; }
        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string Contractnumber { get => _contractnumber; set => _contractnumber = value; }
        public string Validity { get => _validity; set => _validity = value; }
        public string Startdate { get => _startdate; set => _startdate = value; }
        public string Cutoffdate { get => _cutoffdate; set => _cutoffdate = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Idvehicle { get => _idvehicle; set => _idvehicle = value; }
        public string CreatedAt { get => _createdAt; set => _createdAt = value; }
        public string UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public bool Active { get => _active; set => _active = value; }
        #endregion

        #region Métodos
        /// <summary>
        /// Obtiene un DataTable con todos los Vehiculos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Vehiculos
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        /// <param name="opt">opt indica si trae o no contraseña</param>
        public string upSert()
        {           
            if (this.Id == null) { }
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = 1,
                linenumber = this.Linenumber,
                imei = this.Imei,
                simcard = this.Simcard,
                model = this.Model,
                brand = this.Brand,
                contractnumber = this.Contractnumber,
                validity = this.Validity,
                startdate = this.Startdate,
                cutoffdate = this.Cutoffdate,
                amount = this.Amount,
                idvehicle = this.Idvehicle,
                active = this.Active
            });

            string data = json;
            if (this.Id == null)
            {
                return Data.sendData(Entity, data, "POST");
            }
            else
            {
                return Data.sendData(Entity + "/" + this.Id, data, "PUT");
            }
        }

        #endregion
    }
}
