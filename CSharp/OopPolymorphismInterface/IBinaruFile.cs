using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal interface IBinaruFile
{
    //có kiểu trả về và tên phương thức nhưng ko có bổ từ
    void WriteBinaryFile();
    void ReadFile();

    //phương thức mặc đinh của interface
    void showInfo() => Console.WriteLine("this is binaryfile");


}
