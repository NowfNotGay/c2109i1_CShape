using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionnMethod;
//Biến class thành extensionMethod
//=> class buộc phải là static
//1 class là static thì toàn bộ bên trong nó phải là static
internal static class ExtentionCheck
{
    public static void IsGreaterThan(this int i, int value = 0)=> Console.WriteLine((i > 100) ? $"{i} lớn hơn 100" : 0);
    public static void Hi(this Program obj) => Console.WriteLine("Hi");
}
