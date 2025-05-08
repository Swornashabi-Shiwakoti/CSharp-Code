namespace EmployeesAndSpecializations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee aEmployee = new Employee("Grishma", 20000);
            Console.WriteLine(aEmployee.ToString());

            Manager aManager = new Manager("Tinku", 25000);
            aManager.NumberOfEmployeesManaged = 25;
            Console.WriteLine(aManager.ToString());

            Engineer aEngineer = new Engineer("Bishal", 22000);
            aEngineer.Specialization = "Electrical Engineering";
            Console.WriteLine(aEngineer.ToString());
        }
    }
}
