using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HairFlowDesktop.Models
{
    public partial class Persona : ObservableObject
    {
        [ObservableProperty] // Crea la propiedad "Nombre" mediante libería CommunityToolkit.Mvvm.
        private string? _nombre;

        [ObservableProperty] // Crea la propiedad "Edad" mediante libería CommunityToolkit.Mvvm.
        private int _edad;

        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }
}
