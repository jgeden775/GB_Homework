using static System.Console;
Clear();

/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Write("Введите значение B1: ");
double dotB1 = Convert.ToDouble(ReadLine());
Write("Введите значение K1: ");
double dotK1 = Convert.ToDouble(ReadLine());
Write("Введите значение B2: ");
double dotB2 = Convert.ToDouble(ReadLine());
Write("Введите значение K2: ");
double dotK2 = Convert.ToDouble(ReadLine());

WriteLine($"Значения B1, K1, B2 и K2: {dotB1}, {dotK1}, {dotB2}, {dotK2}");
WriteLine();
WriteLine($"Первая прямая: y = {dotK1} * x + {dotB1}");
WriteLine($"Вторая прямая: y = {dotK2} * x + {dotB2}");
WriteLine();
WriteLine($"Точка их пересечения: ({String.Join(", ", IntersectionPoint(dotB1, dotK1, dotB2, dotK2))})");
WriteLine();

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
double x = (b1 - b2) / -(k1 - k2);
double y = k2 * x + b2;
double[] result = {x, y};
return result;
}
