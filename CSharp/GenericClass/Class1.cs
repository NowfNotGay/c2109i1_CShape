using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class Class1<T>
{
    public T Field { get; set; }
    public void show() => Console.WriteLine(Field);
}
