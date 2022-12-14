double a = .1;
double b = .2;
float c = 0.6f;
decimal m = 0.1M;
decimal n = 0.2M;

Console.WriteLine(m+n);

// ?: => ternary operator

// ? nullable value type
string? fullname = null;
//int i = null;

//Nullable<int> i = null; C# cũ

//C# mới
int? i = null;

int length = fullname!= null ? fullname.Length : 0;

int? length1 = fullname is not null ? fullname.Length : null;

// null-conditional operator ?
//? tương tự dấu != , fullname mà khác null thì trả về vế sau
int? leg = fullname?.Length;

//null-coalesing operator ??
//tương tự dấu ==, fullname mà = null thì trả về vế sau
int leg1 = fullname?.Length ?? 0;
