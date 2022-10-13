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