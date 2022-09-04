// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
VerifyDay(numberDay);

void VerifyDay(int numDay) 
{
  if (numDay == 6 || numDay == 7) 
    { 
        Console.WriteLine("Да, этот день выходной");
    }
  else 
    if (numDay < 1 || numDay > 7) 
        {
             Console.WriteLine("Увы, такого дня недели нет");
        }
    else
        {
             Console.WriteLine("Нет, это не выходной");
        }
}

