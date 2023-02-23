// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while (current <= num)
{
    Console.Write(current + " ");
    current++; // current += 2; изменяет величину на 2 (тоже также работает -, /, *)
}

