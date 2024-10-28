namespace LambdaOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            //public int Add(int a, int b)
            //{
            //    return a + b;
            //}
            Console.WriteLine(1 + "\n---------------");
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(1,5));

            //2
            //public bool IsOdd(int number)
            //{
            //    return number % 2 != 0;
            //}
            Console.WriteLine(2 + "\n---------------");
            Func<int, bool> isOdd = num => num % 2 != 0;
            Console.WriteLine(isOdd(3));

            //3
            //public void PrintMessage(string message)
            //{
            //    Console.WriteLine(message);
            //}
            Console.WriteLine(3 + "\n---------------");
            Action<string> value = s => Console.WriteLine(s);
            value("dado");

            //4
            //public double CalculateCircleArea(double radius)
            //{
            //    return Math.PI * radius * radius;
            //}
            Console.WriteLine(4 + "\n---------------"); ;
            Func<double , double> calculateCircleArea = r => Math.PI *r * r;
            Console.WriteLine(calculateCircleArea(5));

            //5
            //public string GetFullName(string fName, string lName)
            //{
            //    return $"{fName} {lName}";
            //}
            Console.WriteLine(5 + "\n---------------");
            Func<string,string, string> getFullName = (fName, lName) => $"{fName} {lName}";
            Console.WriteLine(getFullName("dado", "ali"));

            //6 (a, b, c) => (a * b) + c
            Console.WriteLine(6 + "\n---------------");
            Func<int, int, int, int> calc = (a, b, c) => (a * b) + c;
            Console.WriteLine(calc(2,3,4));

        }
    }
}
