﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principal.EnlaceDatos;
using System.Web.Script.Serialization;

namespace Principal.Entidades
{
    public class Vehiculo
    {
        #region atributos
        static string Entity = "vehicles";
        string _id, _token, _number, _brand, _model, _type, _description, _year, _color, _serie, _motorserie, _plate, _iddriver, _idpermit, _createdAt, _updatedAt;
        bool _active;
        #endregion

        #region Propiedades
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

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public string Serie
        {
            get
            {
                return _serie;
            }

            set
            {
                _serie = value;
            }
        }

        public string Motorserie
        {
            get
            {
                return _motorserie;
            }

            set
            {
                _motorserie = value;
            }
        }

        public string Plate
        {
            get
            {
                return _plate;
            }

            set
            {
                _plate = value;
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

        public string Idpermit
        {
            get
            {
                return _idpermit;
            }

            set
            {
                _idpermit = value;
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
            string json = new JavaScriptSerializer().Serialize(new
            {
                _id = this.Id,
                number = this.Number,
                brand = this.Brand,
                model = this.Model,
                type = this.Type,
                description = this.Description,
                year = this.Year,
                color = this.Color,
                serie = this.Serie,
                motorserie = this._motorserie,
                plate = this.Plate,
                iddriver = this.Iddriver,
                idpermit = this.Idpermit,
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
