// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int number = new Random().Next(1, 8);
Console.WriteLine($"День недели от 1 до 7 -> {number}");
//   Console.WriteLine("Введите номер от 1 до 7");
//   string? number= Console.ReadLine();
if (number > 5)
Console.WriteLine("Этот день выходной");
else
{
    Console.WriteLine("Этот день не выходной");
}

  
