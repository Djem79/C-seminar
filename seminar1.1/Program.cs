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

Console.WriteLine("Input your first number:");
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

