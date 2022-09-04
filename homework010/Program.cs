// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// Первый вариант:

Console.WriteLine("Введите трёхзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int length = numberA.ToString().Length;
if (length < 3 || length > 3)
{
    Console.WriteLine("А это разве трёхзначное число?");
}
else
{
Console.WriteLine($"{"Вторая цифра числа"} {CountSecond(numberA)}");
}

int CountSecond(int num1)
{
     return ((num1 / 10) % 10);
}

// Второй вариант (по мотивам задачи 13):

// Console.WriteLine("Введите трёхзначное число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// string numberAText = Convert.ToString(numberA);
// Console.WriteLine($"{"Вторая цифра"} {numberAText[1]}");