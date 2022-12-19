using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class Class1 : ITestFile, IBinaruFile
{
    public void ReadFile() => Console.WriteLine("Read File");

    public void WriteBinaryFile() => Console.WriteLine("Write Binary File");

    public void WriteTextFile() => Console.WriteLine("Write Text File");


}
