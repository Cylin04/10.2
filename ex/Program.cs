using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project25
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            while (true)
            {
                Console.WriteLine("Employee Management Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Edit Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display Employees");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter salary: ");
                        double salary = double.Parse(Console.ReadLine());

                        Employee newEmployee = new Employee { Name = name, Age = age, Salary = salary };
                        employeeManager.AddEmployee(newEmployee);

                        Console.WriteLine("Employee added successfully!");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Enter name of employee to edit: ");
                        string modifyName = Console.ReadLine();

                        Employee UpdateEmployee = employeeManager.GetEmployeeByName(modifyName);
                        if (UpdateEmployee != null)
                        {
                            Console.Write("Enter new name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter new age: ");
                            int newAge = int.Parse(Console.ReadLine());
                            Console.Write("Enter new salary: ");
                            double newSalary = double.Parse(Console.ReadLine());

                            Employee updatedEmployee = new Employee { Name = newName, Age = newAge, Salary = newSalary };
                            employeeManager.UpdateEmployee(modifyName, updatedEmployee);

                            Console.WriteLine("Employee edit successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found!");
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter name of employee to delete: ");
                        string removeName = Console.ReadLine();

                        Employee removeEmployee = employeeManager.GetEmployeeByName(removeName);
                        if (removeEmployee != null)
                        {
                            employeeManager.RemoveEmployee(removeName);
                            Console.WriteLine("Employee delete successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found!");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        employeeManager.DisplayEmployees();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
