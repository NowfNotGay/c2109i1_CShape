using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationProperty;
internal class HumanBeing
{
    //fields các field phải là private
    private string fullnane;

    //thuộc tính address dùng cho window app,web app,console app
    //gọi là thuộc tính theo C# mới
    public string Address {private get; set; }
    
    private int age;

    //public string Fullname { get; set; }


    //các phươnng thức getter setter nếu viết trên mobile
    //gọi là propertiy theo c# cũ
    public string Fullname
    {
        set =>
            fullnane = value;
        get =>
            fullnane;
    }
    public void ShowProper()
    {
        Console.WriteLine($"{nameof (Address)} = {Address}");
        Console.WriteLine($"{nameof (fullnane)}");
    }
}
