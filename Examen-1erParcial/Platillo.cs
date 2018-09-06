using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1erParcial
{
    class Platillo
    {
        public string Platillo_Nombre { get; set; }
        public string Platillo_ID { get; set; }
        public string Platillo_Descripcion { get; set; }
        public double Platillo_Precio { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }

        public Platillo(int Precio)
        {
            Platillo_Precio = 50;

            do
            {
                if (Platillo_Precio >= 50)
                {
                    Platillo_Precio = Precio;
                }
                else
                {
                    Console.WriteLine("Precio no puede ser menor que $50");
                }
            } while (Platillo_Precio < 50);
        }

    }
}
