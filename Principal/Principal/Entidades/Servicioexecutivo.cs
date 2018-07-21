using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;


namespace Principal.Entidades
{
    class Servicioexecutivo
    {
        #region Atributos privados
        static string Entity = "executivesvcs";
        string _id, _number, _linenumber, _imei, _simcard, _model, _brand, _contractnumber, _validity, _startdate, _cutoffdate, _amount, _idvehicle, _iddriver, _idpermitholder, _createdAt, _updatedAt;
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

        public string Linenumber
        {
            get
            {
                return _linenumber;
            }

            set
            {
                _linenumber = value;
            }
        }

        public string Imei
        {
            get
            {
                return _imei;
            }

            set
            {
                _imei = value;
            }
        }

        public string Simcard
        {
            get
            {
                return _simcard;
            }

            set
            {
                _simcard = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                _brand = value;
            }
        }

        public string Contractnumber
        {
            get
            {
                return _contractnumber;
            }

            set
            {
                _contractnumber = value;
            }
        }

        public string Validity
        {
            get
            {
                return _validity;
            }

            set
            {
                _validity = value;
            }
        }

        public string Startdate
        {
            get
            {
                return _startdate;
            }

            set
            {
                _startdate = value;
            }
        }

        public string Cutoffdate
        {
            get
            {
                return _cutoffdate;
            }

            set
            {
                _cutoffdate = value;
            }
        }

        public string Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }

        public string Idvehicle
        {
            get
            {
                return _idvehicle;
            }

            set
            {
                _idvehicle = value;
            }
        }

        public string Iddriver
        {
            get
            {
                return _iddriver;
            }

            set
            {
                _iddriver = value;
            }
        }

        public string Idpermitholder
        {
            get
            {
                return _idpermitholder;
            }

            set
            {
                _idpermitholder = value;
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
        /// Obtiene un DataTable con todos los Servicios executivos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Servicios executivos
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>
        /// <param name="opt">opt indica si trae o no contraseña</param>
        public bool upSert(bool opt)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = this.Number,
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
                iddriver = this.Iddriver,
                idpermitholder = this.Idpermitholder,


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

        #endregion
    }
}
