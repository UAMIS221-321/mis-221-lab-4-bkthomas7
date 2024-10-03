
    class CrimsonCrust
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("\nWelcome to Crimson Crust Pizza! Here's our menu:");
            Console.WriteLine("1. Plain Pizza");
            Console.WriteLine("2. Cheese Pizza");
            Console.WriteLine("3. Pepperoni Pizza");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");


            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice please try again");
                continue;
            }

            switch (choice)
            {
                case 1:
                    PlainPizza();
                    break;
                case 2:
                    CheesePizza();
                    break;
                case 3:
                    PepPizza();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice please try again");
                    break;
            }
        }
    }

    static void PlainPizza()
    {
        Random rand = new Random();
        int rows = rand.Next(8, 13);  

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void CheesePizza()
    {
        Random rand = new Random();
        int rows = rand.Next(8, 13);  

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j == 1 || j == i || i == rows)  
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }

    static void PepPizza()
    {
        Random rand = new Random();
        int rows = rand.Next(8, 13);  

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j == 1 || j == i || i == rows)  
                {
                    Console.Write("* ");
                }
                else if (rand.Next(0, 5) == 0)
                {
                    Console.Write("[] ");
                }
                else
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
}



