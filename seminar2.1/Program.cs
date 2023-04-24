/*int data = 24;
Console.WriteLine("Good morning! Today is " + data + "april");
Console.WriteLine($"Good morning! Today is {data} april");
*/

//Задача 1.
//Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.

/*int Digits(int number)
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

Console.WriteLine("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >9 && user_number < 100)
{
    Digits1(user_number);
    /*int res = Digits(user_number);
    Console.WriteLine($"The biggest digit is {res}");
*/
}
else
{
    Console.WriteLine(" Imposible value ");
}
