// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int randomNumber = new Random().Next(100, 1000);

// int firstDigit = randomNumber / 100;
// int lastDigit = randomNumber % 10;

// System.Console.WriteLine($"{randomNumber} → {firstDigit}{lastDigit}");

int CetNumber(int number)
{
    return (number / 100 * 10 + number % 10);
}
System.Console.WriteLine(CetNumber(new Random().Next(100, 1000)));
