// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double k1 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());


double x = ((b1-b2)-(b1-b2)-(b1-b2))/(k1-k2);
double y = k2 * x + b2;


Console.WriteLine("Точка пересечения двух прямых: (" + x + " ; " + y + ")");

