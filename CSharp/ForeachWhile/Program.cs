using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string[] arr = {"Nghĩa","Thảo","Vinh","Phú","Vương","Nguyên"};

foreach(var a in arr)
{
    Console.WriteLine($"{a} có chiều dài {a.Length}");
}


//var i = 0;
//length = arr.length;
//while(i < arr.Length)
//{
//    Console.WriteLine(arr[i++]);
//}


//While IEnumerator
IEnumerator e = arr.GetEnumerator();
while (e.MoveNext())
{  
    string s = (string)e.Current;
    Console.WriteLine($"{s} có chiều dài {s.Length}");
}