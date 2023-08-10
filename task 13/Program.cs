// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(0, 100000);
Console.WriteLine($"Случайноe число из диапазона от 0 до бесконечности -> {number}");

//  if (number < 100);
//     Console.WriteLine("Третьей цифры нет");

//  while (number > 999)
//          number = (number / 10);
//          number = (number % 10);
//         Console.WriteLine(number);

if (number <= 99)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    while (number > 999)
    number = (number / 10);
    number = (number %10);
    Console.WriteLine(number);
}

















// int result = thirdDigit;

// if (number < 100);
//  Console.WriteLine("Число двузначное");
// if
//  (number > 100);
//  Console.Write(thirdDigit);

