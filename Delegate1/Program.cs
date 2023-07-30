//namespace Delegate1
//{

    //public delegate void MyDelegate(string msg);

    //    public class Program
    //    {
    //        public static void Main()
    //        {
    //            MyDelegate del = ClassA.MethodA;
    //            del("Hello World");

    //            del = ClassB.MethodB;
    //            del("Hello World");

    //            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
    //            del("Hello World");

    //        }
    //    }

    //    public class ClassA
    //    {
    //        public static void MethodA(string message)
    //        {
    //            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    //        }
    //    }

    //    public class ClassB
    //    {
    //        public static void MethodB(string message)
    //        {
    //            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    //        }
    //    }

    using System;

    public delegate void PrintStringDelegate(string text);

    public class TextPrinter
    {
        public static void PrintGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void PrintOrange(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Using DarkYellow for an orange-like color
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    public class Program
    {
        public static void Main()
        {
            PrintStringDelegate printString;

            printString = new PrintStringDelegate(TextPrinter.PrintGreen);
            printString("This text is printed in green color.");

            printString = new PrintStringDelegate(TextPrinter.PrintOrange);
            printString("This text is printed in orange color.");
        }
    }




