

//Задача Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.



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