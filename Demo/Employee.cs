using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public enum Gender : byte
    {
        Female = 1,
        Male = 2
    }

    [Flags]
    public enum SecurityLevel : byte
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8
    }

    internal class Employee
    {
        //1.	Design and implement a Class for the employees in a company
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public HirringDate HireDate {  get; set; }
        public Gender Gender { get; set; }
        #endregion

        public override string ToString()
        {
            return $"EmpName: {Name}\nSalary: {Salary:c}\nGender: {Gender}\nSecurity Level: {SecurityLevel}\nHire Date:{HireDate.ToString()}";
        }

        #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
        public static Employee[] CreateEmployee(int size)
        {
            if (size > 0)
            {
                Employee[] employees = new Employee[size];
                for (int i = 0; i < size; i++)
                {
                    employees[i] = new Employee();
                }
                return employees;
            }
            throw new ArgumentOutOfRangeException();
        }

        public static void InsertEmployeeData(Employee[] employee)
        {
            if (employee is not null)
            {
                for (int i = 0; i < employee.Length; i++)
                {
                    bool valid;
                    int id;
                    do
                    {
                        Console.Write("ID: ");
                        valid = int.TryParse(Console.ReadLine(), out id);
                    } while (!valid);
                    employee[i].Id = id;
                    do
                    {
                        Console.Write("Name: ");
                        employee[i].Name = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(employee[i].Name));
                    decimal salary;
                    do
                    {
                        Console.Write("Salary: ");
                        valid = decimal.TryParse(Console.ReadLine(), out salary);
                    } while (!valid);
                    employee[i].Salary = salary;
                    Gender gender;
                    do
                    {
                        Console.Write("Gender: ");
                        valid = Enum.TryParse<Gender>(Console.ReadLine(),true, out gender);
                    } while (!valid);

                    employee[i].Gender = (Gender)gender;

                    int security;
                    do
                    {
                        Console.Write("SecurityLevel: ");
                        valid = int.TryParse(Console.ReadLine(), out security);
                    } while (!valid || !(security > 0 && security <= 15));

                    employee[i].SecurityLevel = (SecurityLevel)security;

                    Console.Write("Hire Date: ");

                    int day, month, year;
                    do
                    {
                        Console.Write("Day: ");
                        valid = int.TryParse(Console.ReadLine(), out day);
                    } while (!valid);

                    employee[i].HireDate.Day = day;
                    do
                    {
                        Console.Write("Month: ");
                        valid = int.TryParse(Console.ReadLine(), out month);
                    } while (!valid) ;

                    employee[i].HireDate.Month = month;
                    do
                    {
                        Console.Write("Year: ");
                        valid = int.TryParse(Console.ReadLine(), out year);
                    } while (!valid);

                    employee[i].HireDate.Year = year;
                }
            }
        }
        #endregion

        #region Print the sorted array
        public static void PrintEmps(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        #endregion

        #region 4.Sort the employees based on their hire date then Print the sorted array.
        public static void SortEmployeesByHireDate(Employee[] employees)
        {
            if (employees == null)
                return;

            for (int i = 0; i < employees.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CompareHireDates(employees[j], employees[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (employees[minIndex], employees[i]) = (employees[i], employees[minIndex]);
                }
            }
        }

        private static int CompareHireDates(Employee e1, Employee e2)
        {
            if (e1.HireDate.Year < e2.HireDate.Year) return -1;
            if (e1.HireDate.Year > e2.HireDate.Year) return 1;
            if (e1.HireDate.Month < e2.HireDate.Month) return -1;
            if (e1.HireDate.Month > e2.HireDate.Month) return 1;
            if (e1.HireDate.Day < e2.HireDate.Day) return -1;
            if (e1.HireDate.Day > e2.HireDate.Day) return 1;
            return 0;
        }
        #endregion

    }
}
