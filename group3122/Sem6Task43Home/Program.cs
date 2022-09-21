// Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


// Чтение данных из консоли

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double x = 0;
double y = 0;

if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают"); // Вывод значения если точки b1(2) и точки k1(2) - равны

else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу"); // Вывод значения если только точки k1(2) - равны
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine("Точка пересечения двух прямых: " + " (" + x + " ; " + y + ")");
}