using System.Text;
using System.Text.RegularExpressions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string? str = "";
Console.WriteLine("Vui lòng nhập số : ");
str = Console.ReadLine();

var formuler = new Regex("^[0-9]+$");

Console.WriteLine(
        
    );

// cách 1 trên wed sẽ sử dụng này nhiều hơn
//int? a = formuler.IsMatch(str) ? Convert.ToInt32(str) : null; đa nền tảng
int? a = formuler.IsMatch(str) ? int.Parse(str) : null;


//Cách  2 sử dụng trên console nhiều hơn
//cách 2
if (int.TryParse(str,out int i)) 
{
    Console.WriteLine($"i là số : {i}");
}

//dùng try catch
Console.WriteLine("Vui lòng nhập số lượng");
string? amount = Console.ReadLine();
//mệnh đề "guard clause"
if (string.IsNullOrEmpty(amount))
{
    return;
}

//làm cái gì dó
if(amount != null)
{
    //làm gì đó
}



//Phải xác định được vấn đề để sử dụng exception
try
{
    int total = int.Parse(amount);
    if (total <= 0) throw new Exception("Phải lớn hơn 0");
    Console.WriteLine($"{nameof(total)} = {total}");
}
catch(Exception e)
{
    Console.WriteLine($"{e.GetType} ,{e.Message}");
}