using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    class Ingreso
    {
        #region Atributos privados
        static string Entity = "incomes";
        string _id, _folio, _receiptnumber, _idvehicle, _idpermitholder, _amount, _date, _createdAt, _updatedAt;
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

        public string Folio
        {
            get
            {
                return _folio;
            }

            set
            {
                _folio = value;
            }
        }

        public string Receiptnumber
        {
            get
            {
                return _receiptnumber;
            }

            set
            {
                _receiptnumber = value;
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

        public string Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
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
        /// Obtiene un DataTable con todos los Ingresos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public string read()
        {
            return Data.getData(Entity);

        }
        /// <summary>
        /// Agrega registros de Ingreso
        /// </summary>
        /// <returns>'true' si fue correcto, 'false' si fue incorrecto</returns>

        public bool upSert(bool opt)
        {
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                folio = this.Folio,
                receiptnumber = this.Receiptnumber,
                Idvehicle = this.Idvehicle,
                idpermitholder = this.Idpermitholder,
                amount = this.Amount,
                date = this.Date,


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
