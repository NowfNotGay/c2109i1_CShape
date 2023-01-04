using UsingTuple;

Person per = new()
{
    Id = 1,
    FirstName = "Nghia",
    LastName = "Ho"
};
Console.WriteLine(per.Id);
Console.WriteLine(per.FirstName);

//dùng tuple ko cần tới class (struct)
ValueTuple<int, string, string> p1 = (1,"Nghia","Ho");
Console.WriteLine(p1.Item2);

//mới hơn
(int, string, string) p2 = (1, "Nghia", "Ho");
Console.WriteLine(p2.Item2);

//dùng var
var p3 = (1,"Nghia","Ho");//value tuple

var p4 = (1);// => variable int p4 = 1;

//net core dùng named thay thế cho các item

(int id, string firstname, string lastname) p5 = (1, "Nghia", "Ho");
Console.WriteLine(p5.id);

//Hoặc dùm name phía trước
var p6 = (id: 1, firstname: "Nghia", lastname: "Ho");

//không phải là tuple => anonymus type
var p7 = new { id = 1, firstname = "Nghia", lastname = "Ho" };

//tuple là public còn anonymus có get không có set