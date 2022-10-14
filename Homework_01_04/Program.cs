Console.Clear();
Console.WriteLine("<< Нахождение всех чётных чисел в заданном интервале >>");
Console.WriteLine(" ");
Console.WriteLine("Введите число (это будет предел интервала): ");
string name = Console.ReadLine();
int num = Convert.ToInt32(name);
Console.WriteLine("Чётные числа, в интевале от 1 до " + num + ":");
for (int index = 1; index <= num; index++)
{
    if (index%2 == 0)
    {
        Console.Write(index + " ");
    }
    else
    {
        
    }
}
