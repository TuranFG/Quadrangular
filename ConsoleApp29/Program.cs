namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rectangular(10,20);
            Console.WriteLine(rec);

            var rhomb = new Rhombus(4, 30);
            Console.WriteLine(rhomb);

            var square = new Square(4);
            Console.WriteLine(square);

            var trp = new Trapezium(4,10,5,4);
            Console.WriteLine(trp);


        }
    }
}