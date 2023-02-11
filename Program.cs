namespace ActualDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAP 8 -> EX 3
            ShowActualDate();
            //CAP 8 -> EX 5
            ShowAlphabeticOrder();
        }

        public static void ShowActualDate()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"Hour: {date.ToString("hh:mm tt")}");
            Console.WriteLine($"Year: {date.Year}");
            Console.WriteLine($"Month:{date.Month}");
            Console.WriteLine($"Day: {date.Day}");
            Console.Write("Presione alguna tecla para continuar...");
            Console.ReadLine();
        }

        public static void ShowAlphabeticOrder()
        {
            Console.Write("Ingrese cadena#1: ");
            string firstString = Console.ReadLine();

            Console.Write("Ingrese cadena#2: ");
            string secondString = Console.ReadLine();

            if (firstString.CompareTo(secondString) < 0)
            {
                Console.WriteLine($"1- {firstString}");
                Console.WriteLine($"2- {secondString}");
            }
            else
            {
                Console.WriteLine($"1- {secondString}");
                Console.WriteLine($"2- {firstString}");
            }
            Console.Write("Presione alguna tecla para continuar...");
            Console.ReadLine();
        }
    }
}
