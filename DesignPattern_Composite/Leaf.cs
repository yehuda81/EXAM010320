using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite
{
    class Leaf : Component
    {
        public Leaf(string name, int value) : base(name, value)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name + space + this.value);
        }
        public override int GetSum()
        {
            return this.value;
        }
        public override bool IsEven()
        {
            if (this.value % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
