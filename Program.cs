using System;

namespace ActionsAndFuncs
{
    //public delegate void DoWork();
    //public delegate void ProcessTask(int duration);
    //public delegate int DoCalculation(int val1, int val2);
    //public delegate int DoMoreCalculations(int val1, int val2, int val3);
    //public delegate bool DoTask();

    public class Program
    {
        public static void Main(string[] args)
        {
            Func<double> getPI = () => Math.PI;
            PrintPI(getPI);

            Console.ReadKey();
        }

        public static void PrintPI(Func<double> func)
        {
            Console.WriteLine(func());
        }
    }
}
