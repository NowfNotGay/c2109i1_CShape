using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentAndParams;
internal class ArgumentClass
{

    //=> expression body
    public void Display(int a, int b, int c)=>
        Console.WriteLine($"{nameof(a)} = {a},{nameof(b)} = {b},{nameof(c)} = {c}");

    //Optional argument
    public void Show(int a = 0, int b = default, int c = 0) =>
        Console.WriteLine($"{nameof(a)} = {a},{nameof(b)} = {b},{nameof(c)} = {c}");

    public void SumParam(params int[] values)
    {
        int sum = 0;
        IEnumerator e = values.GetEnumerator();
        while (e.MoveNext())
        {
            sum += (int)e.Current;
        }
        Console.WriteLine(sum);
    }
}
