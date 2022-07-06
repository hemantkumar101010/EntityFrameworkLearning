
using EntityFrameworkData;
using EntityFrameworkData.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CRUDManager obj = new CRUDManager();

            #region CRUD-EMPLOYEE
            //Console.WriteLine("Adding a new Employee");
            //obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
            //obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
            //PrintAllEmployees();

            //Console.WriteLine("Updating Employee with EmployeeId 2");
            //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            //var employee = obj.GetEmplpoyeeById(2);
            //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            //Console.WriteLine("Deleting Employee details for EmployeeId 2");
            //obj.Delete(2);
            //PrintAllEmployees();

            //Console.ReadLine();
            #endregion

            #region CRUD-Employee-Education
            //Console.WriteLine("Adding a Employee education");
            //obj.Insert(new EmployeeEducation { CourseName = "Btech", UniversityName = "HNBGU Srinagar", PassingYear = 2021, MarksPercentage = 70, EmployeeID = 1 });
            //obj.Insert(new EmployeeEducation { CourseName = "BCA", UniversityName = "Graphic Era", PassingYear = 2022, MarksPercentage = 60, EmployeeID = 3 });
            //obj.Insert(new EmployeeEducation { CourseName = "Mtech", UniversityName = "HNBGU Srinagar", PassingYear = 2020, MarksPercentage = 78, EmployeeID = 3 });
            //obj.Insert(new EmployeeEducation { CourseName = "MCA", UniversityName = "Graphic Era", PassingYear = 2022, MarksPercentage = 66, EmployeeID = 5 });
            //PrintAllEmployeesEducation();

            //Console.WriteLine();
            //Console.WriteLine("Updating Employee education with EducationId 25");
            //obj.Update(25, new EmployeeEducation { CourseName = "Modified course", UniversityName = "Modified uni", PassingYear = 2019, MarksPercentage = 40 });
            //PrintAllEmployeesEducation();

            //Console.WriteLine("Retrieving Employee education details for EmployeeId 25");
            //var employeeEducation = obj.GetEmployeeEducationById(25);
            //Console.WriteLine($"Employee Name of employee ID 25 is {employeeEducation.ID}, {employeeEducation.CourseName}, {employeeEducation.UniversityName}");

            //Console.WriteLine("Deleting Employee edu details for EmployeeEduId 25");
            //obj.DeleteEdu(25);
            //PrintAllEmployeesEducation();

            #endregion

            ShowEmployeeAndEducation();
        }
       

        //Ont to many relationship 

        public static void ShowEmployeeAndEducation()
        {
            CRUDManager obj = new CRUDManager();


          
            var employee = new Employee { Name = "Hemant", Address = "UK" };
            List<EmployeeEducation> educationList = new List<EmployeeEducation>();
            educationList.Add(new EmployeeEducation
            {
                CourseName = "BCA",
                UniversityName = "Hnbgu",
                MarksPercentage = 80,
                PassingYear = 2020,
                Employee = employee
            });
            educationList.Add(new EmployeeEducation
            {
                CourseName = "MCA",
                UniversityName = "HNBGU",
                MarksPercentage = 75,
                PassingYear = 2022,
                Employee = employee
            });

            #region InsertingIn2Table
       
            //educationList.Add(new EmployeeEducation { CourseName = "BBA", UniversityName = "HNBGU", MarksPercentage = 80, PassingYear = 2020 });
            //educationList.Add(new EmployeeEducation { CourseName = "MBA", UniversityName = "GraphicEra", MarksPercentage = 75, PassingYear = 2022 });

            //obj.InsertEmployeeAndEducation(new Employee { Name = "Aditya", Address = "Hyderabad" }, educationList);
            //Console.WriteLine("Data inerted in employee and education table");
            #endregion

        }
        private static void PrintAllEmployees()
        {
            Console.WriteLine("Printing all Employees");
            CRUDManager obj = new CRUDManager();
            foreach (Employee employee in obj.GetAllEmployees())
            {
                Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
            }
        }

        private static void PrintAllEmployeesEducation()
        {
            Console.WriteLine("Printing all Employees education");
            CRUDManager obj = new CRUDManager();
            foreach (EmployeeEducation employeeEducation in obj.GetAllEmployeeEducation())
            {
                Console.WriteLine($"EducationId: {employeeEducation.ID}, CourseName: {employeeEducation.CourseName}, UniName: {employeeEducation.UniversityName}, Yop: {employeeEducation.PassingYear}, marks percentage:{employeeEducation.MarksPercentage}");
            }
        }
    }
}