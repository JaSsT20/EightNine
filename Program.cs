namespace ActualDate
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAP 8 -> EX 3
            ShowActualDate();
            Console.WriteLine("----------------------------------------");
            //CAP 8 -> EX 5
            ShowAlphabeticOrder();
            Console.WriteLine("----------------------------------------");
            //Cap 9 -> EX 1
            ShowProducts();
            //Cap 9 -> EX 4
            Console.WriteLine("----------------------------------------");
            ShowTires();
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

        public static void ShowProducts()
        {
            Products newProduct = new Products();
            newProduct.Id = 0;
            newProduct.Name = "Cuaderno";
            newProduct.Description = "Sirve para escribir en él";
            newProduct.Price = 150.00f;

            Console.WriteLine($"Producto: {newProduct.Name}");
            Console.WriteLine($"Id: {newProduct.Id}");
            Console.WriteLine($"Descripción: {newProduct.Description}");
            Console.WriteLine($"Precio: ${newProduct.Price}");

            Console.Write("Presione alguna tecla para continuar...");
            Console.ReadLine();
        }

        public static void ShowTires()
        {
            Console.WriteLine("Neumáticos");
            Tires myTire = Tires.Summer;
            Console.WriteLine($"La llanta es de tipo: {myTire}");
        }
    
    }
}
