Console.Clear();
Console.WriteLine("<< Чётное или нечётное число >>");
Console.WriteLine(" ");
Console.WriteLine("Введите число: ");
string name = Console.ReadLine();
int num = Convert.ToInt32(name);
Console.WriteLine(" ");
if (num%2 == 0)
{
    Console.WriteLine(">> Число " + num + " - ЧЁТНОЕ");
}
else
{
    Console.WriteLine(">> Число " + num + " - НЕЧЁТНОЕ");
}
Console.WriteLine(" ");
