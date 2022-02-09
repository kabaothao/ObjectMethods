using System;

namespace ObjectMethods // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors()); //Return False because Jim is not that smart.
            Console.WriteLine(student2.HasHonors()); //Return true because Pam is smart.

            Console.ReadLine();

        }
    }
}

/*
 Topic: Object Methods
What are object methods?
Methods are used to perform certain actions, and they are also known as functions.

Why use methods? To reuse code: define the code once, and use it many times.

So let's say that we're trying to find out which students are in the honor roll.
 */