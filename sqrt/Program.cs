namespace sqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(sqrtCalc(25));
        }

        static double sqrtCalc(int x)
        {
            double result = Math.Sqrt(x);
            return result;
        }
    }
}