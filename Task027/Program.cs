// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

  int Sum (int number)
  {  
    int length = Convert.ToString(number).Length;
    int count = 0;
    int result = 0;

    for (int i = 0; i < length; i++)
    {
      count = number - number % 10;
      result = result + (number - count);
      number = number / 10;
    }
    return result;
  }

int sum = Sum(number);
Console.WriteLine($"Сумма цифр в числе: {sum}");