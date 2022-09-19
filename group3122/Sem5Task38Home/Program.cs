// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

// Получение данных от пользователя и преобразование в число

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double minNumb = Int32.MaxValue;
double maxNumb = Int32.MinValue;

// Определяем максимальное и минимальное число
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > maxNumb)
        {
            maxNumb = numbers[x];
        }
    if (numbers[x] < minNumb)
        {
            minNumb = numbers[x];
        }
}

Console.WriteLine($"Сгенерировано всего {numbers.Length} чисел. Максимальное значение в массиве = {maxNumb}, минимальное значение в массиве = {minNumb}");
Console.WriteLine($"Разница между макс. и мин. значением = {maxNumb - minNumb}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}