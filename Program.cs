

//Задача Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.


/*

Console.WriteLine ("Insert 5-digit number: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine("It's palindrome");
    }
    else
    {
        Console.WriteLine("It's not palindrome");
    }
}

else
{
    Console.WriteLine ("Incorrect number");
}

*/





//Задача: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.





/* 

double LineLength (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return lengthAB;
}

Console.WriteLine ("Input X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Z coord of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input Z coord of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LineLength(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance AB is {dist:f3}");

*/



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.





void CubeFinder ()
{
    Console.WriteLine("Input number: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    
    if (numN > 0)
    {
        int current_i = 1;
        while (current_i <= numN)
        {
            int res = current_i*current_i*current_i;
            Console.Write($"{res}, ");
            current_i++;
        }
        Console.WriteLine("\b\b.");
    }
    else
    {
    int current_i=1;
     while (current_i >= numN)
        {
            int res = current_i*current_i*current_i;
            Console.Write($"{res:f0}, ");
            current_i--;
        }
        Console.WriteLine("\b\b.");
    }
}
CubeFinder();
