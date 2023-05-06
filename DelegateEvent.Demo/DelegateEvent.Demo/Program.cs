namespace DelegateEvent.Demo
{
    internal class Program
    {
        static int Square(int input) => input * input;
        static void Main(string[] args)
        {
            var caltor = new Calculator();
            //Calculator.Calculate calc = Square;

            //var respomnse = caltor.Execute(Square, Console.WriteLine,5);

            //Use lambda
            //var respomnse = caltor.Execute((x) => x * x, Console.WriteLine, 5);

            //caltor.Calculate += Caltor_Calculate;
            caltor.Calculate += (obj, arg) => Console.WriteLine(arg.Name);
            caltor.RaiseEvent("Test name");
            //Console.WriteLine(respomnse);
            Console.ReadKey();
        }

        private static void Caltor_Calculate(object arg1, CalculatorEventArgs arg2)
        {
            Console.WriteLine(arg2.Name);
        }
    }
}