using System;

namespace InterviewQuestion1.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator(0, 5, () => Console.ReadLine(), Console.WriteLine);

            calculator.Run();
        }
    }
}
