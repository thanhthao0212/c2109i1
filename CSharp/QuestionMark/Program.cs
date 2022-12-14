// format code ctrl + k + d
double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b == 0.3 ? "True" : "Flase");

float c = 0.6f;
decimal d = 0.1M;
decimal e = 0.2M;
Console.WriteLine(d + e == 0.3M ? "True" : "Flase");

// ?: => ternary operator

// ? nullable value type
string? fullname = null;
//int i = null;
//c# cũ
//Nullable<int> i = null;
//c# mới
bool? check = null;

//int lenght = fullname != null ? fullname.Length : 0;

//int? lenght = fullname is not null ? fullname.Length : null;

//null-conditional operator ?
//tương tự != , fullname mà khác null thì trả về vế sau
int? lenght = fullname?.Length;

//null-coalescing ??
//tương tự dấu ==, fullname bằng null thì trả về vế sau

int? chieudai = fullname?.Length ?? 0;
