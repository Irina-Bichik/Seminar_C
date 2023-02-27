// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

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
