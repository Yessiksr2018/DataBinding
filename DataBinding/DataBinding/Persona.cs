using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    public class Persona : Notificable
    {
        #region Atributos
        private string nombre;
        private string pais;
        private decimal saldo;
        private DateTime fechadeNacimiento;

        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechadeNacimiento;
            }
            set
            {
                if (fechadeNacimiento == value)
                {
                    return;
                }
                fechadeNacimiento = value;
                OnPropertyChanged();
            }
        }


        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (saldo == value)
                {
                    return;
                }
                saldo = value;
                OnPropertyChanged();
            }
        }

        #endregion
        #region propiedades
        public String Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();

            }
        }
        public String Pais
        {
            get
            {
                return pais;
            }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged();
            }
        }


        #endregion
       
    }
}
