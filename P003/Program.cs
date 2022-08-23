// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ил второе число кратным пермоу. 
// Если ивтрое число не кратно числу первому, то программа выводт остаток от деления.

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA%numberB == 0)
{
System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {numberA%numberB}");
}