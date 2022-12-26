// See https://aka.ms/new-console-template for more information
using Entity;
using ExeciseOop.Helper;

Console.WriteLine("Hello, World!");
Product1 a = new();
a.Pro_Date = Validate<DateTime>.CheckReadLine();