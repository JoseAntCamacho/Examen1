using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public enum Colores
    {
        Red,
        Green,
        Blue
    }

    public class Shape
    {
        public Colores Colores { get; set; }
    }

    public class Rectangulo : Shape
    {

    }

    public class Circulo : Shape
    {

    }

    public class Flecha: Shape
    {

    }
}
