using OopPolymorphismInterface;

//Class1 a = new();
//a.WriteTextFile();
//a.WriteBinaryFile();
//a.ReadFile();


////c# cũ
//((IBinaruFile)a).showInfo();
////c# mới
//(a as IBinaruFile).showInfo();


ITestFile itext = new Class1();
itext.ReadFile();
itext = new Class2();
itext.ReadFile();
