using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDemo
{
    class GeneradorDeContactos
    {
        private static List<string> ListaNombres = new List<string>
        {
            "Juan","Pedro","Gustavo","Rodolfo",
            "Manuel","Cristina","Regina","Goergina","Manuela"
        };

        private static List<string> ListaApellidos = new List<string>
        {
            "Gonsales","Pastrana","Peres","Lopes",
            "Trinidad","Mendes","Allende","Escobar","Sanches"
        };

        public static ObservableCollection<Contacto> CrearContacto()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for(int i = 0; i < 25; i++)
            {
                var nombre = ListaNombres[random.Next(ListaNombres.Count-1)];
                var apellido = ListaApellidos[random.Next(ListaApellidos.Count - 1)];
                var calle = ListaApellidos[random.Next(ListaApellidos.Count - 1)];
                var contacto = new Contacto
                {
                    Nombre = nombre + " " + apellido,
                    Telefono = GenerarTelefono(),
                    Direccion = "Avenida" + calle + ", Numero" + random.Next(1, 1000)

                };
                contactos.Add(contacto);
            }
            return contactos;
        }

        private static string GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100,999));
            telefono.Append(")");
            telefono.Append(random.Next(1000000, 9999999));
            return telefono.ToString();
        }
    }
}
