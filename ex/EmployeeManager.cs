using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project25
{
    class EmployeeManager
    {
        private ArrayList employeesList;
        private Hashtable employeesHashtable;
        private Dictionary<string, Employee> employeesDictionary;

        public EmployeeManager()
        {
            employeesList = new ArrayList();
            employeesHashtable = new Hashtable();
            employeesDictionary = new Dictionary<string, Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employeesList.Add(employee);
            employeesHashtable.Add(employee.Name, employee);
            employeesDictionary.Add(employee.Name, employee);
        }

        public void UpdateEmployee(string name, Employee updatedEmployee)
        {
            for (int i = 0; i < employeesList.Count; i++)
            {
                Employee employee = (Employee)employeesList[i];
                if (employee.Name == name)
                {
                    employeesList[i] = updatedEmployee;
                    employeesHashtable[employee.Name] = updatedEmployee;
                    employeesDictionary[employee.Name] = updatedEmployee;
                    break;
                }
            }
        }

        public void RemoveEmployee(string name)
        {
            employeesList.Remove(GetEmployeeByName(name));
            employeesHashtable.Remove(name);
            employeesDictionary.Remove(name);
        }

        public Employee GetEmployeeByName(string name)
        {
            return (Employee)employeesHashtable[name];
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (DictionaryEntry entry in employeesHashtable)
            {
                Employee employee = (Employee)entry.Value;
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }
    }
}
