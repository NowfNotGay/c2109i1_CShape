internal class Program
{
    public static void Add(int a, int b) => Console.WriteLine(a + b);
    public static int Substract(int a, int b) => a-b;

    public static void Show() => Console.WriteLine("C2109I1");
    public static int ReturnNumber() => 5;
    private static void Main(string[] args)
    {
        //local function (Hàm cục bộ)
        void Sub(int a,int b) => Console.WriteLine(a-b);
        //func và action => đều là delegate
        //action dùng cho các Phương thức ko có kiểu trả về(void)
        //Func dùng cho các phương thức có kiểu trả về(không có void)

        Action act = Show;
        act();
        Func<int> func = ReturnNumber;
        Console.WriteLine(func());
        Action<int, int> a = Add;
        a(5, 6);

        Func<int, int,int> sub = Substract;
        sub(10, 5);

        //Local Function ko sài đc deleGate
        //Action a = Sub;
        
        //Javacrispt Arrow function
        Action<string> acc = (str) =>
        {
            Console.WriteLine(str);
        };
        acc("Hello");
        //acc.Invoke();
    }
}