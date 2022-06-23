// See https://aka.ms/new-console-template for more information


namespace payrollf
{
    internal class Classmain
    {
        public static void Main(string[] args)
        {
            Exercises Operations = new Exercises();

            Console.WriteLine("Main payroll");
            Console.WriteLine("1. Insert new employee");
            Console.WriteLine("2. Exit the main");

            

            string Opc = Console.ReadLine();

            int Opc1;
            Console.Clear();

            switch (Opc)
            {

                case "1":
                    do
                    {
                        Operations.CalculatePayroll();
                        Operations.PrintDates();
                        Console.WriteLine("1. Insert new employee");
                        Console.WriteLine("2. Exit ");
                        Console.Clear();

                        Opc1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Data invalied");

                     
                    }
                    while (Opc1 != 2);
                    break;

                case "2":
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Exit of Console");
                    break;
            }

            Console.Clear();

        }
    }
}

