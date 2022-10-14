Console.Clear();
Console.WriteLine("<< Поиск максимального числа >>");
Console.WriteLine(" ");
Console.WriteLine("Введите первое число: ");
string name1 = Console.ReadLine();
int num1 = Convert.ToInt32(name1);
Console.WriteLine("Введите второе число: ");
string name2 = Console.ReadLine();
int num2 = Convert.ToInt32(name2);
Console.WriteLine("Введите третье число: ");
string name3 = Console.ReadLine();
int num3 = Convert.ToInt32(name3);
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine(" ");
Console.Write(">> Максимальное число: ");
Console.WriteLine(max);
Console.WriteLine(" ");
