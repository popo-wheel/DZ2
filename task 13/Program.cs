// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(0, 100000);
Console.WriteLine($"Случайное число из диапазона от 100 до бесконечности -> {number}");
int thirdDigit = number % 10;
int result = thirdDigit;

if (number < 100);
 Console.WriteLine("Число двузначное");
if
 (number > 100);
 Console.Write(thirdDigit);