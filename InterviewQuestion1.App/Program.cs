using System;

namespace InterviewQuestion1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(0, 5, () => Console.ReadLine(), (str) => Console.WriteLine(str));

            calculator.Run();
        }
    }
}
