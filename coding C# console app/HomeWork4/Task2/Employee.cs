using System;

namespace Task2
{
    class Employee
    {
        private string firstName , surName;
        private string position;
        private int experience;

        public string FirstName { get { return firstName; } }
        public string SurName { get { return surName; } }
        public string Position 
        { 
            get { return position; } 
            set { if (value == "junior" || value == "middle" || value == "senior" || value == "team lead")
                { position = value; }
                else {
                    Console.WriteLine("Not correct position.");
                    position = null;
                }
            } 
        }
        public int Experience 
        { 
            get { return experience; } 
            set { if (value>=1 && value<= 15)
                { experience = value; }
                else
                {
                    Console.WriteLine("Not correct experience.");
                    experience = 0;
                }
            } 
        }

        public double Salary(string position, int experience)
        {
            double indexOfPosition = 0;
            if (position == "junior")
            {
                indexOfPosition = 1.2;
            }
            else if (position == "middle")
            {
                indexOfPosition = 1.6;
            }
            else if (position == "senior")
            {
                indexOfPosition = 2;
            }
            else if (position == "team lead")
            {
                indexOfPosition = 3;
            }

            return indexOfPosition*experience*320;
        }

        public double Taxes(double taxes)
        { 
        return taxes/19.5;
        }

        public Employee(string firstName, string surName)
        {
            this.firstName = firstName;
            this.surName = surName;
        }

    }
}
