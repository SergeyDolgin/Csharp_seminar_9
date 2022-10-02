// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Sum(int M, int N)
{
    int result = M;
    if (M>N) 
    {
        Console.WriteLine("число N должно быть больше M ");
        return 0;
    }
    
    if (M == N)
        return 0;
    else
    {
        return N+Sum(M,N-1);
    }
}
try{
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма всех натуральных чисел в промежутке от M до N: ");
Console.WriteLine(M+Sum(M,N));
}
catch 
{
    Console.WriteLine("oh...something wrong");
}