using MappingInhertance.Data;
using MappingInhertance.Data.Models;

namespace EFCoreSession5Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using InheritanceDBContext db = new InheritanceDBContext();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Ahmed",
                Age = 30,
                Address = "Cairo",
                Salary = 50000,
                StartDate = DateTime.Now
            };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Mohamed",
                Age = 25,
                Address = "Giza",
                HourRate = 200,
                CountOfHours = 100
            };
            db.FullTimeEmployees.Add(fullTimeEmployee);
            db.PartTimeEmployees.Add(partTimeEmployee);
            db.SaveChanges();
            Console.WriteLine("Data Saved Successfully");
		}
    }
}
