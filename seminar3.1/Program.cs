/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Koords(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("This point on 1st quoter");
    else if(x < 0 && y >0)
        Console.WriteLine("This point on 2nd quoter");
    else if(x < 0 && y < 0)
        Console.WriteLine("This point om 3rd quoter");
    else
        Console.WriteLine("This point om 4rd quoter");
}
Console.WriteLine("Enter your x coordinate: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your y coordinate: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if(xCoord == 0 || yCoord == 0)
    Console.WriteLine("its impossible value for this task!");
else
    Koords(xCoord, yCoord);
*/


/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).

void PossibleValue (int num)
{
    if(num == 1)
        Console.WriteLine("1st quoter x > 0, y > 0");
    else if(num == 2)
        Console.WriteLine("2nd quoter x < 0, y > 0");
    else if(num == 3)
        Console.WriteLine("3rd quoter x < 0, y < 0");
    else
        Console.WriteLine("4th quoter x > 0, y < 0");
}

Console.WriteLine("Input number of quoter: ");
int numQouter = Convert.ToInt32(Console.ReadLine());

if (numQouter >= 1 && numQouter <= 4)
    PossibleValue(numQouter);
else
    Console.WriteLine("Its not number of quoter!");
*/



//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (x1,y1); B(x2, y2)
//Math.Sqrt()- извлечение квадратного корня

/*
double LongLine (int x1, int x2, int y1, int y2)
{
    double lenthAB = Math.Sqrt((x1 - x2)* (x1 - x2) + (y1 - y2)*(y1 - y2));
    return lenthAB;
}

Console.WriteLine("Input x coordinat of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinat of A: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinat of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB);

Console.WriteLine($"Distance AB is {dist:f3}");
*/


//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void SquareFinder() 
{
    Console.WriteLine("Input number; ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while(current_i <= numberN)
        {
            int res = current_i * current_i;
            Console.Write($"{res}, ");
            current_i++;
        }
        Console.WriteLine("\b\b.");
    }
    else
    {
        int current_i = 1;
        while (current_i >= numberN)
        {
            Console.Write(current_i * current_i + ", ");
            current_i --;
        }
       // Console.WriteLine("Impossible value!");
    }
}
SquareFinder();
