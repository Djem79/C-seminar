/*Console.WriteLine("Good morning");
Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine(number);
*/

//Задача 1.
//Напишите программу, которая на вход принимает число и выдает его квадрат

/*Console.WriteLine("Input your number:");
int number1 = Convert.ToInt32(Console.ReadLine());

int result = number1 * number1;

//Console.WriteLine(number1 * number1);
Console.WriteLine("Your number is " + number1 + " Square of this number is " + result);
Console.WriteLine($"Your number is {number1}. Square of this number is {result}");
*/


//Задача 3.
// Напишите программу, которая на вход принимает 2 числа и проверяет,
//является ли первое число квадратом второго.

/*Console.WriteLine("Input your first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine($"Your first number is a square of the second one");
}
else
{   
    Console.WriteLine($"Your first number is not a square of the second one");
}
*/

//Задача 5.
//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.


/*Console.WriteLine("Input your number:");
int numN = Convert.ToInt32(Console.ReadLine());

int current_i = numN * (-1);

while (current_i <= numN)
{
    Console.Write(current_i + " ");
    current_i ++;
}
*/


//Задача 7.
//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.


//456 % 10 -> 6
//456 % 100 -> 56
//456 / 10 -> 45
//456 / 100 -> 4

Console.WriteLine("Input your number:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{   
    //int dev = num % 10;
    //Console.WriteLine($"Last digit {num} is {dev}");
    Console.WriteLine("Last num is: " + num%10);
}
else
{
    Console.WriteLine ("Your number is not 3 digits");
}
