using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut;
internal class UseRefOut
{
    //Expressing body
    //khi 1 phương thức chỉ có 1 câu lệnh duy nhất
    public void ShowInfo()=>Console.WriteLine("Thông tin về class này");

    public static void ChangeNumbe(ref int a,ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"ChangeNumber : {nameof(a)}={a}, {nameof(b)}={b}");
    }
}
