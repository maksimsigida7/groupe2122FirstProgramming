// Напишите программу, которая принимает на 
// вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
//=================================================================

// Чтение данных с консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Расстояние между двумя точками
double CalcData(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

// Собираем данные
int x1 = ReadData("Введите х1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");

// Выдаем результат
PrintResult("Расстояние между точками: " + Math.Round(CalcData(x1, x2, y1, y2, z1, z2),2).ToString());