// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
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

string LinNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i,pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN,pow);

    return outLine;
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");
PrintResult(LinNumbers(num,1));
PrintResult(LinNumbers(num,3));