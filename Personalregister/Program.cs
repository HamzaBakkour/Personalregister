using Xunit;


namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployesManager employesManager = new EmployesManager();

            Console.WriteLine("Welcome to Employe Manager v.0.01");
            while (true) {
                Console.WriteLine("1. Add employe");
                Console.WriteLine("2. Delete employe");
                Console.WriteLine("3. List employees");
                Console.WriteLine("4. Calculate employees salary");
                Console.WriteLine("5. Exit");

                Console.Write("Enter command line: ");
                string choice = Console.ReadLine();
                switch (choice) {
                    case "1":
                        employesManager.AddEmploye();
                        break;
                    case "2":
                        employesManager.RemoveEmploye();
                        break;
                    case "3":
                        employesManager.ListEmployes();
                        break;
                    case "4":
                        Console.WriteLine("\nEmbloyee salary sun: " + employesManager.GetAllSalary() + "\n");
                        break;
                    default:
                        Console.WriteLine(choice + " is not a valid choice please try again");
                        break;
                }

                if (choice == "5") {
                    Console.Write("Are you sure you want to exit (n to stay, other input to exit): ");
                    choice = Console.ReadLine();
                    if (choice?.ToLower() == "n") {
                        continue;
                    }
                    break;
                }

            }
        }
    }
}
