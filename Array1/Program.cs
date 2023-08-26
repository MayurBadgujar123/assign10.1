namespace Array1
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee No: " + EmpNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numEmployees];

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                Console.Write("Employee No: ");
                int empNo = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                employees[i] = new Employee { EmpNo = empNo, Name = name, Salary = salary };
            }

            
            Employee highestSalaryEmployee = employees.OrderByDescending(emp => emp.Salary).FirstOrDefault();
            Console.WriteLine("\nEmployee with the highest salary:");
            highestSalaryEmployee.DisplayDetails();

           
            Console.Write("\nEnter Employee No to be searched: ");
            int searchEmpNo = int.Parse(Console.ReadLine());

            Employee searchedEmployee = employees.FirstOrDefault(emp => emp.EmpNo == searchEmpNo);

            if (searchedEmployee != null)
            {
                Console.WriteLine("\nEmployee found:");
                searchedEmployee.DisplayDetails();
            }
            else
            {
                Console.WriteLine("\nEmployee not found.");
            }
        }
    }
}