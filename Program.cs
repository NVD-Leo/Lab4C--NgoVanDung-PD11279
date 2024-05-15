using System.Text;

namespace Lab4
{
    public class Lab4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai1
            Console.WriteLine("Bài 1");
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var newlist = list.FindAll(item => item % 2 == 0);
            foreach (var item in newlist)
            {
                Console.WriteLine(item);
            }
            //bai2
            Console.WriteLine("-----------------");
            Console.WriteLine("Bài 2: ");
            List<Userdata> users = new List<Userdata>()
            {
                new Userdata { name = "Alice", level = 10 },
                new Userdata { name = "Toro", level = 20 },
                new Userdata { name = "Thane", level = 30 },
            };
            var userNamesAndLevels = users.Select(user => new { user.name, user.level });
            Console.WriteLine("-----------------");
            Console.WriteLine("Bài 2 a:");
            foreach (var user in userNamesAndLevels)
            {
                Console.WriteLine($"Name: {user.name}, Level: {user.level}");
            }
            var sortedUsersByLevel = users.OrderByDescending(user => user.level);
            Console.WriteLine("-----------------");
            Console.WriteLine("Bài 2 b:");
            foreach (var user in sortedUsersByLevel)
            {
                Console.WriteLine($"Name: {user.name}, Level: {user.level}");
            }
            //Bai3
            Console.WriteLine("-----------------");
            Console.WriteLine("Bài 3:");
            List<Student> students = new List<Student>
        {
            new Student { Stt = 1, name = "Bảo Trâm", Age = 15 },
            new Student { Stt = 2, name = "Quốc Trung", Age = 18 },
            new Student { Stt = 3, name = "Huyền Trang", Age = 20 },
            new Student { Stt = 4,  name = "Gia Lâm", Age = 12 },
            new Student { Stt = 5, name = "Vân Anh", Age = 16 },
            new Student { Stt = 6, name = "Văn Dũng", Age = 21 }
        };

            //Bai3 a
            Console.WriteLine("-----------------");
            Console.WriteLine("Bài 3 a:");
            var queryResultQuerySyntax =
                from student in students
                where student.Age > 12 && student.Age < 20
                select student;
            foreach (var student in queryResultQuerySyntax)
            {
                Console.WriteLine($"Stt: {student.Stt} ,Name: {student.name}, Age: {student.Age}");
            }
            //Bai3 b
            Console.WriteLine("-----------------");
            Console.WriteLine("Bài 3 b:");
            var queryResultMethodSyntax = students
                .Where(student => student.Age > 12 && student.Age < 20);
            foreach (var student in queryResultMethodSyntax)
            {
                Console.WriteLine($"Stt: {student.Stt} ,Name: {student.name}, Age: {student.Age}");
            }
        }
    }
        
    public class Userdata
    {
        public string name { get; set; }
        public int level { get; set; }
    }
    public class Student
    {
        public string name { get; set; }
        public int Age { get; set; }
        public int Stt { get; set; }
    }
}
