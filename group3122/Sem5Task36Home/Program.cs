// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.


// Получение данных от пользователя и преобразование в число

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrRandNum(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int sum = 0;


for (int x = 0; x < numbers.Length; x += 2) //  складываем числа на нечетных позициях
    sum = sum + numbers[x];

Console.WriteLine($"всего задано {numbers.Length} чисел, а сумма элементов на нечётных позициях = {sum}");

// Создание и заполнение массива числами от 1 до 10

void FillArrRandNum(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}

//Печать

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}