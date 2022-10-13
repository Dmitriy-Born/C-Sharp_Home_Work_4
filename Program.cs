//Задача 1
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("----------Задание №1----------");
Console.WriteLine("Введите число, которое возводить в степень: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, равное степени: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A}, возведенное в степень {B} = {Construction(A,B)}");

int Construction(int number, int degree){
    int result = 1;
    for (int i = 1; i <= degree; i++){
        result = result * number;
    }
    return result;
}

//Задача 2
//ННапишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("----------Задание №2----------");
Console.WriteLine("Введите число: ");
int C = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {C} = {Sum(C)}");

int Sum(int num){
    int R = 0;   
    while (num > 0){
        R = R + num % 10;
        num = num / 10;   
    }   
    return R;
}