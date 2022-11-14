using static System.Console;
Clear();

/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

WriteLine("Введите положительные и отрицательные числа, через пробел: ");
Write(">> ");
string numbers = ReadLine();
StringToArray(numbers);
WriteLine();
Write("Ваш набор чисел: ");
WriteLine($"[{String.Join(", ", StringToArray(numbers))}]");
WriteLine();
WriteLine($"Из них положительных: {PosiNum(StringToArray(numbers))}");
WriteLine();

int[] StringToArray(string input)
{
int[] result = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse).ToArray();
return result;
}

int PosiNum(int[] array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
	{
		if(array[i] > 0) result++;
	}
	return result;
}
