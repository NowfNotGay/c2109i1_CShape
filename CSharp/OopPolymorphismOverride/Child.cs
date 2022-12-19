using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverride;
internal class Child: Parent
{
    //override sử dụng cho abstract or virtual
    public override void Display()
    {
        //base.Display();
        Console.WriteLine("Child Display");
    }

    public new void Show() => Console.WriteLine("Child show");
}
