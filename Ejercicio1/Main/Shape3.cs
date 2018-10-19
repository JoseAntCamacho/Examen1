using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public enum Color
    {
        red,
        green,
        blue
    }

    public interface IShape
    {
        Color Color { get; set; }
        void Draw(Action<String> action);        
    }

    public class Shape : IShape
    {
        public Color Color { get; set; }     
        public virtual void Draw(Action<String> action) { }
    }

    public class Rectable : Shape
    {
        public Rectable (Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> action)            
        {
            action.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));            
        }
    }    

    public class Circle : Shape
    {
        public Circle(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> action)
        {
            action.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));
        }
    }

    public class Arrow: Shape
    {
        public Arrow(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> action)
        {
            action.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));
        }
    }    
}
