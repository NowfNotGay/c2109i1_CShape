using OopRncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationCont;
internal class Weed:Plant
{
    static void Main(string[] args)
    {
        Weed w = new();
        w.ProtectedInternal();
        w.Protected();
    }
}
