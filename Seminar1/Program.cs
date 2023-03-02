//Console.WriteLine("Вывод текста, текст в кавычках");

// int num1 = 25; // целые числа, например -2, 25, 1500
// int num2 = 40;
// double num2 = 13.45; //вещественное число
// string word = "Irina"; // обязательно двойные кавычки
// char symbol = '%'; //один символ, цифра, буква, знак, пробел - в одинарных кавычках
// bool check = num1>num2; //true or false

// Console.WriteLine("my number are " + num1  + " and " + num2 + " and it is good!");
// Console.WriteLine($"my number are {num1} and {num2} and it is good!");
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if (number1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}

// 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while (current <= num)
{
    Console.Write(current + " ");
    current++; // current += 2; изменяет величину на 2 (тоже также работает -, /, *)
}

// 34215 / 10 = 3421
// 34215 / 100 = 342
// 34215 / 1000 = 34
// 34215 / 10000 = 3

// 34215 % 10 = 5
// 34215 % 100 = 15
// 34215 % 1000 = 215
// 34215 % 10000 = 4215
