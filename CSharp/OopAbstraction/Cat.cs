namespace OopAbstraction;
internal abstract class Cat:Animal
{
    private bool gender;
    public void ShowInfoCat()
    {
        Console.WriteLine($"{nameof(gender)} = {gender}");
    }
}
//1 phương thức là abtract thì class phải abstract nhưng
//class abstract bênh trong chưa chắc có abstract
