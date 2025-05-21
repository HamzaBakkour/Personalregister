using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Personalregister
{
    internal class EmployesManager
    {

        private List<Employe> employes = new List<Employe>();

        public bool AddEmploye() {

            Console.Write("Enter employe name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employe salary: ");
            int salary = int.Parse(Console.ReadLine());

            employes.Add(new Employe(name, salary));
            return true;
        }
        public void ListEmployes() {


            Console.WriteLine("\n\n|||||||||||||||||| Employee ||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine(">");
            Console.WriteLine("| {0, -10} | {1, -30} | {2, -10} |", "ID", "Name", "Salary");
            Console.WriteLine(">");
            foreach (var employe in employes) {
                Console.WriteLine(employe.GetEmployInfo());
                Console.WriteLine(">");
            }
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n\n");
        }



        public void RemoveEmploye() {

            ListEmployes();

            Console.Write("Enter employe ID to remove: ");
            
            string employeID = Console.ReadLine();
            
            if (string.IsNullOrEmpty(employeID))
            {
                throw new ArgumentException("ID must be set");
            }

            if (employes.Remove(employes.First(e => e.GetID() == int.Parse(employeID))))
            {
                Console.WriteLine($"Employe with ID {employeID} was successfuly removed");
                Console.WriteLine("New embloyes table: ");
                ListEmployes();
            }
            else {
                Console.WriteLine("Operation unsuccessfuly!");
            }
        }

        public int GetAllSalary() {
            return employes.Sum(e => e.Salary);
        }
    }
}
