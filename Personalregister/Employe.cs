using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Employe
    {
        private string _name;
        private int _salary;

        private static int nextID = 0;
        private readonly int _id;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name must be set");
                }
                 _name = value;
            }
        }


        public int Salary
        {
            get => _salary;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary can not be negative");
                }
                _salary = value;
            }
        }

        public Employe(string name, int salary) {
            _id = nextID++;
            this.Name = name;
            this.Salary = salary;
        
        }

        public string GetEmployInfo() {
            return string.Format("| {0, -10} | {1, -30} | {2, -10} |", _id, Name, Salary);
        }

        public int GetID() {
            return _id;
        }

    }
}
