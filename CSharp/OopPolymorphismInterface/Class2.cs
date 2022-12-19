using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class Class2 : IBinaruFile, ITestFile
{
    //buộc phải dụng bổ từ
    public void ReadFile() => Console.WriteLine("ReadFile of ITextFile");

    public void WriteTextFile() => Console.WriteLine("Write Text File");


    //không dung bổ từ
    void IBinaruFile.ReadFile() => Console.WriteLine("Read of IBinaryFile");

    void IBinaruFile.WriteBinaryFile() => Console.WriteLine("Write Banary File");
}
