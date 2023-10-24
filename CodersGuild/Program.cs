using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{

    public static void DemoMethod()
    {
        Console.WriteLine("This is a method in the same class.");
    }

    static void Main(string[] args)
    {
        TestHelpers testObject = new TestHelpers();

        Console.WriteLine("Hello world! What is your name?");
        String name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        
        testObject.MethodExample(); 
    }
}
