using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    class Datos
    {

        private ObservableCollection<Persona> personas;
        private Persona personaSeleccionada;

        public ObservableCollection<Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }

        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                if (personaSeleccionada == value)
                {
                    return;
                }
                personaSeleccionada = value;
                OnPropertyChanged();
            }
        }

        #region Constructores
        public Datos()
        {
            var aleatorio = new Random();
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 11; i++)
            {
                Personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"Pais {i}",
                    FechaDeNacimiento = new DateTime(1980 + i, i + 1, 1),
                    Saldo = (decimal)(aleatorio.Next(100, 5000) * 3.1416)
                });
            }
        }
        #endregion
    }
}
}
