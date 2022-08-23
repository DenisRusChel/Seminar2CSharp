//  Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.


int randomNumber = new Random().Next(10, 100);
int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

int max = firstDigit;

if (max < secondDigit)
{
    max = secondDigit;
}
System.Console.WriteLine($"Максимальная цифра в числе: {randomNumber} → {max}");
