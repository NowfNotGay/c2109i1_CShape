using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverLoading;
internal class BasicMath
{
    //properties (Thuộc tính)
    public int Num1 { get; set; }
    public int Num2 { get; set; }


    //overloading chỉ khác tham số hay kiểu của tham số
    //1 là constructor, 2 là method

    //if don't parameter ctor
    //public BasicMath(){}

    //if have parameter ctrl + . on class name
    //optional argument
    //public BasicMath(int num1=0, int num2 = 0)
    //{
    //    Num1 = num1;
    //    Num2 = num2;
    //}
}
