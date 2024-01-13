using System.IO;
using System;


class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new Exception("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

    static void Main(string[] args)
    {
        checkAge(14);
    }
}

