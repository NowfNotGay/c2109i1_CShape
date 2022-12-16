using ArgumentAndParams;

//pure oop
//ArgumentClass argument = new ArgumentClass();

// dungf var
//var argu = new ArgumentClass();


//target-type
ArgumentClass argu = new();


//named argument
argu.Display(1,2,3);
argu.Display(b:1, c:2, a:3);
//argu.Display(b:1,2, 3); =>Error

argu.Show(c:2);
argu.SumParam(1,2,3,4,5,6);

int[] ints = { 1, 2, 3, 4 };
argu.SumParam(ints);