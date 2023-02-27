// 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber (int num)
/*
{
    int hundreds = num / 100;
    int ones = num % 10;

    int result = hundreds * 10 + ones;
    return result;
}
*/
{
    int hundreds = num / 100;
    int ones = num % 10;

    return hundreds * 10 + ones;
}
int randNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");

// 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

bool isDivided(int number, int firstDivider, int secondDivider) 
{
    return number % firstDivider == 0 && number % secondDivider == 0;

//     /*
//     if (number % firstDivider == 0 && number % secondDivider == 0)  //   || - логическое 'или'; && - логическое 'и'
//         return true;
//     else
//         return false;
//      */   
}
Console.WriteLine("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isDivided(num, div1, div2));

// 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int ShowNum (int randomNum)
{
    int tens = randomNum / 10;
    int ones = randomNum % 10;

    if (tens > ones)
    {
        return tens;
    }
    else 
    {
        return ones;
    }
}
int randomNum = new Random().Next(10,100);

Console.WriteLine($"{randomNum} {ShowNum (randomNum)}");


// 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool IsQuad (int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1 ;
}
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsQuad(num1,num2));


