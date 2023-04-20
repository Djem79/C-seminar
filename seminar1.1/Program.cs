/*Console.WriteLine("Good morning");
Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine(number);
*/

//Задача 1.
//Напишите программу, которая на вход принимает число и выдает его квадрат

Console.WriteLine("Input your number:");
int number1 = Convert.ToInt32(Console.ReadLine());

int result = number1 * number1;

//Console.WriteLine(number1 * number1);
Console.WriteLine("Your number is " + number1 + " Square of this number is " + result);
Console.WriteLine($"Your number is {number1}. Square of this number is {result}");