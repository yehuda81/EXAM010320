using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Composite
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Component root = new Composite("Canvas root",8);
            Component circle1 = new Leaf("Circle 1",4);
            Component rectangle = new Leaf("Rectangle x",2);
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite("Container y",18);
            Component circle2 = new Leaf("Circle 1",6);
            Component circle3 = new Leaf("Circle 2",4);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite("Container of triangles",6);
            Component t1 = new Leaf("Triangle 1",11);
            Component t2 = new Leaf("Triangle 2",20);
            container2.AddChild(t1);
            container2.AddChild(t2);

            //root.AddChild(container2);

            root.Draw(""); // without recurrsion

            //Draw(root, ""); // with recusrion
            int sum = root.GetSum();
            Console.WriteLine(sum);
            Console.WriteLine(root.IsEven());
        }

        // recursion
        static void Draw(Component c, string space)
        {
            Console.WriteLine(space + c.GetName());

            if (c.GetChilds() == null)
                return;

            foreach (Component child in c.GetChilds())
            {
                Draw(child, space + "    ");
            }
        }
    }
   
}
