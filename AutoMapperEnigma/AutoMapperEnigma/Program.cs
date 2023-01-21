using AutoMapper;
using AutoMapperEnigma.ConfigProfile;

class Program
{

    //Depedency Injection == teknik mengatur cara bagaimana cara suatu objek dibentuk ketika object lain dibutuhkan
    static void Main()
    {
        var config = new AutoMapper.MapperConfiguration( cfg =>
        {
            cfg.AddProfile(new ConfigurationProfile()); //class cinfig yg sudah dibuat sebelumnya
        });

        IMapper mapper = config.CreateMapper();

        var employee = Employee.GetAllEmployee();

        //mapping pakai Automapper -- dari employee ke DTO
        var employeeList = mapper.Map<List<EmployeeDto>>(employee);

        foreach(var emp in employeeList)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department}");
        }


        //mapping automapper -- dari dto ke employee
        EmployeeDto employeeDto = new EmployeeDto();
        employeeDto.Name = "Rafif";
        employeeDto.Department = "Konoha";

        var employeeDtoList = mapper.Map<Employee>(employeeDto);
        employeeDtoList.Id = 14;
        Console.WriteLine($"{employeeDtoList.Id} - {employeeDtoList.Name} - {employeeDtoList.Department}");





    }
    public class EmployeeDto
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<Employee> GetAllEmployee() //API
        {
            return new List<Employee>() //MOCK API yg akan di testing oleh FE
            {
                new Employee(){Id = 1, Name = "Madara", Department = "Katon"},
                new Employee(){Id = 2, Name = "Kakashi", Department = "Raiton"},
                new Employee(){Id = 3, Name = "Naruto", Department = "Fuuton"},
                new Employee(){Id = 4, Name = "Kakuzu", Department = "Katon"},
                new Employee(){Id = 5, Name = "Sasuke", Department = "Katon"},
                new Employee(){Id = 6, Name = "Oonoki", Department = "Jinton"},
                new Employee(){Id = 7, Name = "Kisame", Department = "Suiton"},
                new Employee(){Id = 8, Name = "Mitsuki", Department = "Fuuton"},
                new Employee(){Id = 9, Name = "Boruto", Department = "Raiton"},
                new Employee(){Id = 10, Name = "Sarada", Department = "Katon"},
                new Employee(){Id = 11, Name = "Jiraya", Department = "Katon"},
                new Employee(){Id = 12, Name = "Gaara", Department = "Doton"},
                new Employee(){Id = 13, Name = "Karatsuchi", Department = "Doton"},
                new Employee(){Id = 14, Name = "Madara", Department = "Katon"},
                new Employee(){Id = 15, Name = "Madara", Department = "Katon"},
            };
        }
    }

}