﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
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

    public class Shape : IShape, IDisposable
    {
        public Color Color { get; set; }

        public void Dispose()
        {
            //TODO: Añadir comandos para liberar espacio.
            // Aquí podríamos introducir un Dispose Pattern.
        }

        public virtual void Draw(Action<String> action) { }
    }

    public class Rectable : Shape
    {
        public Rectable(Color color)
        {
            Color = color;
        }
        public override void Draw(Action<String> action)
        {
            action.Invoke(String.Format("El tipo de forma es {0} y el color es {1}", GetType().Name, this.Color));
        }
    }
    /*"El tipo de forma es un {0} y el color es {1}", this.GetType().ToString(), this.Color.ToString();*/

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

    public class Arrow : Shape
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
