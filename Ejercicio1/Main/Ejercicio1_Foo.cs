using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
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

    public class Ejercicio1_Foo : Foo, IEventos
    {
        private string _Name;
        public event ChangeNameEventHandler ChangeName;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value != Name)
                {
                    var changeName = new ChangeNameEventArgs(_Name, value);
                    _Name = value;
                    OnChangeName(changeName);
                }
            }
        }
        public void OnChangeName(ChangeNameEventArgs e)
        {
            ChangeName?.Invoke(this, e);
            Console.WriteLine("El nombre anterior era {0} y el nuevo nombre es {1}", e.OldName, e.NewName);
        }
    }


}
