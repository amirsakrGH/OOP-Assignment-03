namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() 
            {
                Id = 1 ,
                Name = "amir",
                Salary = 99999,
                HireDate = new HirringDate(5,5,2025),
                Gender = Gender.Male,
                SecurityLevel = SecurityLevel.Developer
            };

            Console.WriteLine(employee);


            ///
            Employee[] employees = Employee.CreateEmployee(2);
            Employee.InsertEmployeeData(employees);

        }
    }
}
