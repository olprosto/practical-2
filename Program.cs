double L, x, a, e, c;

Console.WriteLine("Введите значение для переменной x");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной a");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной e");
e = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной c");
c = Convert.ToDouble(Console.ReadLine());

L = (Math.Sqrt(Math.Exp(x) - Math.Pow(Math.Cos(Math.Pow(x, 2) * Math.Pow(a, 5)), 4) + Math.Pow(Math.Atan(a - Math.Pow(x, 5)), 4) / (e * Math.Sqrt(Math.Abs(a + x * Math.Pow(c, 4))))));

Console.WriteLine($"результат решения задачи №1={L}");


double L1, x1, t, c1;

Console.WriteLine("Введите значение для переменной x");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной t");
t = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной c");
c1 = Convert.ToDouble(Console.ReadLine());


L1 = Math.Pow(Math.Tan(1 / c1), 2) + (2 * Math.Pow(x1, 2) + 5) / Math.Sqrt(c1 + t);

Console.WriteLine($"результат решения задачи №2={L1}");


double A, y, h;

Console.WriteLine("Введите значение для переменной Y");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной h");
h = Convert.ToDouble(Console.ReadLine());

A = (Math.Tan(Math.Pow(y, 3) - Math.Pow(h, 4)) + Math.Pow(h, 2)) / (Math.Pow(Math.Sin(h), 3) + y);

Console.WriteLine($"результат решения задачи №3={A}");


double F, y1, x2;

Console.WriteLine("Введите значение для переменной Y");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной x");
x2 = Convert.ToDouble(Console.ReadLine());

F = (Math.Sqrt(Math.Pow(2 + y1, 2) + Math.Sqrt(Math.Sin(y1 + 5)))) / (Math.Log10(x2 + 1) - Math.Pow(y1, 3));

Console.WriteLine($"результат решения задачи №4={F}");


double G, x3, y2, z, c2;

Console.WriteLine("Введите значение для переменной x");
x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной y");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной z");
z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной c");
c2 = Convert.ToDouble(Console.ReadLine());

G = (Math.Tan(Math.Pow(x3, 4) - 6) - Math.Pow(Math.Cos(z + x3 * y2), 3)) / (Math.Pow(Math.Cos(Math.Pow(x3, 3)), 4) * Math.Pow(c2, 2));

Console.WriteLine($"результат решения задачи №5={G}");


double K, x4, y3, b, a1;

Console.WriteLine("Введите значение для переменной x");
x4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной y");
y3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной b");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной a");
a1 = Convert.ToDouble(Console.ReadLine());

K = (Math.Sqrt(x4 + b - a1) + Math.Log10(y3)) / (Math.Atan(b + a1));

Console.WriteLine($"результат решения задачи №6={K}");


double D, x5, y4, a2;

Console.WriteLine("Введите значение для переменной x");
x5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной y");
y4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной a");
a2 = Convert.ToDouble(Console.ReadLine());

D = (Math.Cos(Math.Pow(x5, 3) + 6) - Math.Sin(y4 - a2)) / (Math.Log10(Math.Pow(x5, 4)) - 2 * Math.Pow(Math.Sin(x5), 5));

Console.WriteLine($"результат решения задачи №7={D}");


double P, a3, y5, c3, x6;

Console.WriteLine("Введите значение для переменной a");
a3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной y");
y5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной c");
c3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной x");
x6 = Convert.ToDouble(Console.ReadLine());

P = (Math.Pow(a3, 5) + Math.Pow(Math.Sin(y5 - c3), 4)) / (Math.Pow(Math.Sin(x6 + y5), 3) + Math.Abs(x6 - y5));

Console.WriteLine($"результат решения задачи №8={P}");


double R, y6, x7, d;

Console.WriteLine("Введите значение для переменной y");
y6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной x");
x7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной d");
d = Convert.ToDouble(Console.ReadLine());

R = (Math.Pow(Math.Cos(y6), 3) + Math.Pow(2, x7) * d) / (Math.Exp(y6) + Math.Log10(Math.Pow(Math.Sin(x7), 2) + 7.4));

Console.WriteLine($"результат решения задачи №9={R}");


double U, x8, y7;

Console.WriteLine("Введите значение для переменной x");
x8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение для переменной y");
y7 = Convert.ToDouble(Console.ReadLine());

U = (Math.Exp(Math.Pow(x8, 3)) + Math.Pow(Math.Cos(x8 - 4), 2)) / (Math.Atan(x8) + 5.2 * y7);

Console.WriteLine($"результат решения задачи №10={U}");