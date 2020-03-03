using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite
{
    public abstract class Component
    {
        protected string name;
        protected int value;


        public Component(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract void Draw(string space);

        public string GetName()
        {
            return this.name;
        }
        public abstract int GetSum();
        public abstract bool IsEven();
    }
}
