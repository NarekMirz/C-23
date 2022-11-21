//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трёхзначное число ");

int number = int.Parse(Console.ReadLine());

if(number > 1000 || number < 100)
{
    System.Console.WriteLine($"У вас не трёхзначное число {number} ,введите трёхзначное");
}
else
{
    int des = number / 10;
    int ed = des % 10;
    System.Console.WriteLine($"Второе число трёхзначного числа {ed}");
}
Console.ReadLine();
