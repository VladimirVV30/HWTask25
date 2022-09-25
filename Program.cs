// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree(double A, double B)
{
    double X = Math.Pow(A, B);
    return X;
}
try
{
    System.Console.Write  ("Введите число, которое будем возводить в степень ");
    double A = Convert.ToDouble (Console.ReadLine());
    System.Console.Write ("Введите степень = ");
    double B = Convert.ToDouble (Console.ReadLine());

    System.Console.WriteLine($"Число {A} в степени {B} будет равно {Degree(A, B)}");
}
catch
{
    System.Console.WriteLine("Необходимо ввести число цифрами!");
}
