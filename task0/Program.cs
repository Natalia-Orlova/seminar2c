// Напишите программу, которая 
//выводит случайное число из отрезка [10, 99] и 
//показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100); // 10, 99 + 1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int firstDigit = number / 10; // получаем 1-ю цифру числа
int secondDigit = number % 10; // получаем 2-ю цифру числа

if (firstDigit == secondDigit) 
Console.WriteLine($"цифры числа {number} равны");


else if (firstDigit > secondDigit) 
Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");

else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");