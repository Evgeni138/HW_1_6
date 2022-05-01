// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите по очереди: b1, k1, b2, k2");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());

// double x = b2/(k1-k2) - b1/(k1-k2);
// double y = (b2/(k1-k2) - b1/(k1-k2)) * k1 + b1;
// Console.WriteLine($"({x}; {y})");

void CrossLine(double a1, double a2, double a3, double a4) 
{
    double x, y;
    x = a3/(a2-a4) - a1/(a2-a4); //(a3-a1)/(a2-a4);
    y = (a3/(a2-a4) - a1/(a2-a4)) * a2 + a1;
    Console.WriteLine($"({x}; {y})");
}

CrossLine(b1, k1, b2, k2);
