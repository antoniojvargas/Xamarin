using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding1
{
    public partial class MainPage : ContentPage
    {
        public Empleado NuevoEmpleado { get; set; }
        public MainPage()
        {
            NuevoEmpleado = new Empleado();
            NuevoEmpleado.NombreCompleto = "Antonio Vargas";
            NuevoEmpleado.Email = "antoniovargas@outlook.com";
            BindingContext = NuevoEmpleado;
            InitializeComponent();
        }
    }
}
