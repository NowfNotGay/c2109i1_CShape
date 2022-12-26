using ExtensionnMethod;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding= Encoding.Unicode;

Console.Write("Vui lòng nhập 1 số:");
int i = int.TryParse(Console.ReadLine(), out var result)?result:0;

//Làm kiểm tra xem
CheckNum.check(i, 100);

//extention method
//Không thông qua đối tượng của class đang chứa
//mà thông qua cái muốn sử dụng
i.IsGreaterThan(100);
Program pro = new();
