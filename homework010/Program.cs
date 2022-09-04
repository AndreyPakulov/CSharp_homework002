// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountSecond(numberA));

int CountSecond(int num1)
{
    return (num1 / 10) - (num1 / 100 * 10);
}