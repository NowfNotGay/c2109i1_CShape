using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class Class2<T,C>
{
    public T Field { get; set; }
    public C Field2 { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Field)}={Field}, {nameof(Field2)}={Field2}}}";
    }
}
