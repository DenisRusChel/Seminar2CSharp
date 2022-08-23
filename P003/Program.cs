// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ил второе число кратным пермоу. 
// Если ивтрое число не кратно числу первому, то программа выводт остаток от деления.

// Console.WriteLine("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// if(numberA%numberB == 0)
// {
// System.Console.WriteLine("кратно");
// }
// else
// {
//     System.Console.WriteLine($"не кратно, остаток {numberA%numberB}");


// void Check(int a, int b)
// {
//     if (a % b == 0)
//     {
//         System.Console.WriteLine("кратно");
//     }
//     else
//     {
//         System.Console.WriteLine($"не кратно, остаток: {a % b}");
//     }
// }
// Check(17, 7);


bool Check(int num)
{
    if (num % 7 == 0 && num % 23 ==0)
    {
    return true;
}
else
{
    return false;
}
}
System.Console.WriteLine((Check(161)));
