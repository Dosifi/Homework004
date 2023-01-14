// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Power(int A, int B)
{
  int result = 1;
  for(int i=1; i <= A; i++)
  {
    result = result * B;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int power = Power(A, B);
  Console.WriteLine($"Ответ: {power}");