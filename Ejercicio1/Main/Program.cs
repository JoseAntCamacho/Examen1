using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {            
            var bar = new Bar { Name = "Jose"};
            bar.Name = "Hola";
            bar.Name = "Hola";
            bar.Name = "Hola2654";
            
            Console.ReadLine();            
        }
    }
}*/

namespace Ejercicio3
{
    class Program
    {        
        static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Rectable(Color.red),
                new Circle(Color.blue),
                new Rectable(Color.green),
                new Arrow(Color.blue)
            };
            foreach(var shape in shapes)
            {
                shape.Draw(Console.WriteLine);
            }
            Console.ReadLine();
        }
    }
}

