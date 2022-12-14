//using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding= Encoding.Unicode;

var num1 = Random.Shared.Next(0, 9);
var num2 = Random.Shared.Next(0, 9);
Console.WriteLine($"{nameof(num1)} = {num1}");
Console.WriteLine($"{nameof(num2)} = {num2}");
Console.Write($"Vui lòng nhập dấu: ");
var pheptoan = Console.ReadLine();

//switch case
switch (pheptoan)
{
    case "+" when num1 >0 && num2 >0:  Console.WriteLine(num1+ num2); 
               break;
    case "-" when num1 >= num2: Console.WriteLine(num1- num2);
               break;
    case "*": Console.WriteLine(num1*num2);
               break;
    case "/" when num2 !=0: Console.WriteLine(num1/num2);
               break;
    default: Console.WriteLine("Hi, I can't do it");
               break;
}


//switch expression => biểu thức switch
Console.WriteLine(
    pheptoan switch
    {
        "+" when num1 > 0 && num2 > 0 => num1 + num2,
        "-" when num1 >= num2 => num1 - num2,
        "*" => num1*num2,
        "/" when num2!= 0 => num1/num2,
        _ =>"I can't do it"
    }
);

