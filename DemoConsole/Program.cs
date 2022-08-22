// See https://aka.ms/new-console-template for more information


using DemoConsole.Models;
using DemoConsole.Utilities;


namespace DemoConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();

            DateTime date = DateTime.Now.AddDays(-2);

            string day = helper.GetMonthName(date);

            //int year = helper.GetYear(date);
            int year = DateTime.Now.ToYear();
            int month = DateTime.Now.ToMonth();
            var days = helper.GetAllDayOfWeekPerMonth(month, year, DayOfWeek.Monday);

            Console.WriteLine(string.Join("\n", days.Select(x => x.ToString("dddd - MM/dd/yyyy"))));

            //Console.WriteLine(date.ToCustomDateFormat("MM/dd/yyyy"));
            Console.ReadLine();


            //InializePerson();

        }

        public static void InializePerson() {

            var person = new List<Person>();


            person.Add(new Person { 
                 Id = 1,
                 BrithDate = DateTime.Now.AddYears(-34),
                 CreatedBy = "System",
                 CreatedOn = DateTime.Now,
                 UpdatedBy = "System",
                 UpdatedOn = DateTime.Now,
                 FirstName = "CJ",
                 LastName = "Felix",
                 Employee = new Employee { 
                     Id = 1,
                     PersonId = 1,
                     CreatedBy = "System",
                     CreatedOn = DateTime.Now,
                     UpdatedBy = "System",
                     UpdatedOn = DateTime.Now,
                     EmployeeNumber = "12345", 
                     EmployeeType = Models.Enums.EmployeeType.Regular                        
                 },
                EmailAddresses = new List<PersonEmailAddress> {
                    new PersonEmailAddress
                    {
                        CreatedBy = "System",
                        CreatedOn = DateTime.Now,
                        UpdatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        EmailAddress = "Test1@gmail.com",
                        IsPrimary = true,

                    },
                    new PersonEmailAddress
                    {
                        CreatedBy = "System",
                        CreatedOn = DateTime.Now,
                        UpdatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        EmailAddress = "Sample1@gmail.com",
                        IsPrimary = false,

                    },
                    new PersonEmailAddress
                    {
                        CreatedBy = "System",
                        CreatedOn = DateTime.Now,
                        UpdatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        EmailAddress = "Sample2@gmail.com",
                        IsPrimary = false,

                    }
                }

            });

            person.Add(new Person
            {
                Id = 2,
                BrithDate = DateTime.Now.AddYears(-25),
                CreatedBy = "System",
                CreatedOn = DateTime.Now,
                UpdatedBy = "System",
                UpdatedOn = DateTime.Now,
                FirstName = "Test",
                LastName = "User",
                Employee = new Employee
                {
                    Id = 2,
                    PersonId = 1,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedOn = DateTime.Now,
                    EmployeeNumber = "55555",
                    EmployeeType = Models.Enums.EmployeeType.Contractual
                },
                EmailAddresses = new List<PersonEmailAddress> { 
                    new PersonEmailAddress
                    {
                        CreatedBy = "System",
                        CreatedOn = DateTime.Now,
                        UpdatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        EmailAddress = "User2@gmail.com",
                        IsPrimary = true,

                    },
                    new PersonEmailAddress
                    {
                        CreatedBy = "System",
                        CreatedOn = DateTime.Now,
                        UpdatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        EmailAddress = "Sample2@gmail.com",
                        IsPrimary = false,

                    },
                    new PersonEmailAddress
                    {
                        CreatedBy = "System",
                        CreatedOn = DateTime.Now,
                        UpdatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        EmailAddress = "Sample2@gmail.com",
                        IsPrimary = false,

                    }
                }
            });

            //var data = person.Where(x=>x.Id == 2);

        }
    }
}


//Helper helper = new Helper();

//DateTime date = DateTime.Now.AddDays(-2);

//string day = helper.GetDayName(date);

//int year = helper.GetYear(date);


//string monthName = helper.GetMonthName(date);

//Console.WriteLine($"Month Name: {monthName}");

//Console.WriteLine($"{day} {year}");

//Helper helper = new Helper();

//int year = DateTime.Now.ToYear();
//int month = DateTime.Now.ToMonth();


////Console.WriteLine($"Month Name: {date}");
//var days = helper.GetAllDayOfWeekPerMonth(month, year, DayOfWeek.Monday);

//Console.WriteLine(string.Join("\n", days.Select(x => x.ToString("dddd - MM/dd/yyyy"))));
