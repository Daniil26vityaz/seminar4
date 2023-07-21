// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
  System.Console.Write(message);
  string readInput = System.Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}