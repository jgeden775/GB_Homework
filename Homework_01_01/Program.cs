Console.Clear();
Console.WriteLine("<< Большее и меньшее число >>");
Console.WriteLine(" ");
Console.WriteLine("Введите первое число: ");
string name1 = Console.ReadLine();
int num1 = Convert.ToInt32(name1);
Console.WriteLine("Введите второе число: ");
string name2 = Console.ReadLine();
int num2 = Convert.ToInt32(name2);
Console.WriteLine(" ");
if (num1 > num2)
{
    Console.WriteLine(">> Первое число " + num1 + " - БОЛЬШЕ");
    Console.WriteLine(">> Второе число " + num2 + " - МЕНЬШЕ");
}
else
{
    Console.WriteLine(">> Второе число " + num2 + " - БОЛЬШЕ");
    Console.WriteLine(">> Первое число " + num1 + " - МЕНЬШЕ");
}
Console.WriteLine(" ");
