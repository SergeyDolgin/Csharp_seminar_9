// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число натуральное число N ");
int Number = Convert.ToInt32(Console.ReadLine());
int End =  1;
Console.WriteLine("Все натуральные числа от 1 до N: ");
void Nat (int End, int Number)
{
    if (Number < End)

    {
        return;
    }
    else
    {
        Nat (End, Number  - 1);
        Console.Write($"{Number}, ");

    }
}
//         Number = Number - End;
//         Console.Write (Number);
//     }
// }
try
{
    Nat(End,Number);
}
catch 
{
    Console.WriteLine("oh...something wrong");
}