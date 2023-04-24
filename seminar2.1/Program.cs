/*int data = 24;
Console.WriteLine("Good morning! Today is " + data + "april");
Console.WriteLine($"Good morning! Today is {data} april");
*/

//Задача 1.
//Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.

/*
int Digits(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    if (ed > dec)
    {
        return ed;
    }
    else 
    {
        return dec;
    }

}*/
/*
void Digits1 (int number)
{
    int ed = number % 10;
    int dec = number / 10;
    if (ed >dec)
    {
        Console.WriteLine("The biggest digit is " + ed);
    }
    else
    {
        Console.WriteLine("The biggest digit is " + dec);
    }
}
/*
Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >9 && user_number < 100)
{
    Digits1(user_number);
    /*int res = Digits(user_number);
    Console.WriteLine($"The biggest digit is {res}");*/
/*
}
else
{
    Console.WriteLine(" Imposible value ");
}
*/

// Задача 2
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8

// 1. Невозратный метод без аргумунтов
// 2. генератор
/*
void MaxDigit ()
{
    
    int minVal = 10;
    int maxVal = 99;
    int random = new Random().Next(minVal, maxVal +1);
    Console.WriteLine("Your number is " + random);

    Digits1 (random);
}
MaxDigit();
*/

// Задача 3
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/*
void Cratnost (int a, int b, int num)
{
    if (num % a == 0, num % b == 0)
    {
        Console.WriteLine($"your number {num} is multiply of {a} and {b}");
    }
    else
    {
        Console.WriteLine($"your number {num} is not multiply of {a} and {b}");
    }
}   
Console.WriteLine("Enter your number: ");
int new_user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your 1 devider: ");
int dev1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your 2 devider: ");
int dev2 = Convert.ToInt32(Console.ReadLine());

Cratnost (dev1, dev2, new_user_num);
*/


//Задача 4
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46, 789 -> 79


int DeletDec()
{   
    int randomNumber = new Random().Next(100, 1000);
    Console.WriteLine("your number is " + randomNumber);

    int digit1 = randomNumber / 100;
    int digit2 = randomNumber % 10;

    int newNum = digit1 * 10 + digit2;
    return newNum;
}

Console.WriteLine($"Your number is {DeletDec()}");

