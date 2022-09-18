// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()

int Exponentiation(int numA, int numB)
{
  int result = 1;
  for(int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
    return result;
}

  Console.Write("Ввести число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());

  Console.Write("Ввести число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numA, numB);
  Console.WriteLine("Число А в степени В: " + exponentiation);

