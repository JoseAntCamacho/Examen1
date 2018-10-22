using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Foo
    {
        public string Name { get; set; }
    }

    public interface IEventos
    {
        event ChangeNameEventHandler ChangeName;
        void OnChangeName(ChangeNameEventArgs e);
    }

    public class ChangeNameEventArgs : EventArgs
    {
        public string OldName { get; private set; }
        public string NewName { get; private set; }
        public ChangeNameEventArgs(string oldName, string newName)
        {
            this.OldName = oldName;
            this.NewName = newName;
        }
    }

    public delegate void ChangeNameEventHandler(object obj, ChangeNameEventArgs e);

    public class Bar : Foo, IEventos
    {
        // private string _Name; No es necesario, porque temos el de la clase abstracta.
        public event ChangeNameEventHandler ChangeName;
        public new string Name //faltaba poner un new porque así se pueden crear instancias de la clase abstracta.
        {
            get
            {
                return base.Name; //hemos puesto el base.Name y así retornamos la implementación.
            }
            set
            {
                if (value != Name)
                {
                    var changeName = new ChangeNameEventArgs(Name, value);
                    Name = value;
                    OnChangeName(changeName);
                }
            }
        }
        public void OnChangeName(ChangeNameEventArgs e)
        {
            //ChangeName?.Invoke(this, e); NOS quedamos con el puntero y evitamos que alguien se quite de la suscripción. Después lo invocamos.
            var handler = this.ChangeName;
            if (null != handler)
            {
                handler.Invoke(this, e);
            }

            Console.WriteLine("El nombre anterior era {0} y el nuevo nombre es {1}", e.OldName, e.NewName);
        }
    }
}
