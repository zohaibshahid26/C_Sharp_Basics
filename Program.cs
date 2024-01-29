using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is my first C# program!");
        Console.WriteLine("I am a student at The Tech Academy.");
        Console.WriteLine("I am learning C#!");
        Student student1 = new Student { Age = 12, Name = "Ali", Comment="he is a student", Grade=5};
        Console.WriteLine(student1);

        var x=add([1,2,4,5]);
        Console.WriteLine(x);

    }
   static public int add(params int[] numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;
    }
}
