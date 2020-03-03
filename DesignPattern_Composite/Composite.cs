using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite
{
    class Composite : Component
    {
        int sum;
        bool iseven;
        private IList<Component> childs = new List<Component>();

        public Composite(string name, int value) : base(name, value)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name + space + this.value);

            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int GetSum()
        {            
            sum += this.value;
            foreach (Component child in childs)
            {
                sum += child.GetSum();
            }
        
            return sum;
        }
        public override bool IsEven()
        {
            
            if (this.value %2 == 0)
            {
                foreach (Component child in childs)
                {                    
                     iseven = child.IsEven();                                      
                }
            }
           
            return iseven;
        }
    }
}
