using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1erParcial
{
    class Menu
    {
        public string Menu_Nombre { get; set; }
        public string Menu_ID { get; set; }
        public int Menu_HoraInicio { get; set; }
        public int Menu_HoraFinal { get; set; }

        public List<Platillo> Platillos { get; set; }

        public Menu()
        {
            Platillos = new List<Platillo>();
            Menu_Nombre = "Nuevo menú";
        }
    }
}
