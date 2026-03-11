namespace Task3EngMai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
        {
      new Student { Id = 1, Name = "Ahmed Ali", Age = 21, Department = "CS", GPA = 3.6 },
             new Student { Id = 2, Name = "Sara Mohamed", Age = 20, Department = "IT", GPA = 3.2 },
             new Student { Id = 3, Name = "Omar Hassan", Age = 22, Department = "CS", GPA = 2.8 },
             new Student { Id = 4, Name = "Mona Adel", Age = 19, Department = "IS", GPA = 3.9 },
             new Student { Id = 5, Name = "Youssef Kamal", Age = 23, Department = "CS", GPA = 2.4 },
             new Student { Id = 6, Name = "Aya Mostafa", Age = 21, Department = "IT", GPA = 3.5 },
             new Student { Id = 7, Name = "Hassan Mahmoud", Age = 24, Department = "IS", GPA = 1.9 },
             new Student { Id = 8, Name = "Nada Fathy", Age = 20, Department = "CS", GPA = 3.1 },
             new Student { Id = 9, Name = "Ali Samir", Age = 18, Department = "IT", GPA = 2.6 },
             new Student { Id = 10, Name = "Reem Tarek", Age = 22, Department = "IS", GPA = 3.7 },
             new Student { Id = 11, Name = "Amr Nabil", Age = 21, Department = "CS", GPA = 4.0 },
             new Student { Id = 12, Name = "Laila Ashraf", Age = 19, Department = "IT", GPA = 2.2 }
            };


            var courses = new List<Course>
 {
     new Course { Id = 1, Title = "C# Fundamentals", Credits = 3 },
     new Course { Id = 2, Title = "OOP", Credits = 4 },
     new Course { Id = 3, Title = "Databases", Credits = 3 },
     new Course { Id = 4, Title = "ASP.NET MVC", Credits = 4 },
     new Course { Id = 5, Title = "LINQ Deep Dive", Credits = 2 }
 };



            var enrollments = new List<Enrollment>
{
    new Enrollment { StudentId = 1, CourseId = 1 },
    new Enrollment { StudentId = 1, CourseId = 2 },

    new Enrollment { StudentId = 2, CourseId = 1 },
    new Enrollment { StudentId = 2, CourseId = 3 },

    new Enrollment { StudentId = 3, CourseId = 2 },

    new Enrollment { StudentId = 4, CourseId = 4 },
    new Enrollment { StudentId = 4, CourseId = 5 },

    new Enrollment { StudentId = 6, CourseId = 3 },
    new Enrollment { StudentId = 6, CourseId = 4 },

    new Enrollment { StudentId = 8, CourseId = 1 },

    new Enrollment { StudentId = 10, CourseId = 2 },
    new Enrollment { StudentId = 10, CourseId = 3 },

    new Enrollment { StudentId = 11, CourseId = 5 }
};




            var res1 = students.Select(s => s.Name).ToList();
            foreach (var name in res1)
            {
                Console.WriteLine(name);
            }

            var res2 = students.Select(s => new { s.Name, s.GPA }).ToList();
            foreach (var item in res2)
            {
                Console.WriteLine($"Name: {item.Name}, GPA: {item.GPA}");
            }
            var res3 = students.Where(s => s.GPA > 3.8);
            Console.WriteLine(res3);

            var res4 = students.Where(s => s.Age > 18).ToList();
            foreach (var student in res4)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            //Level 1 – Fundamentals
            var result1 = students.Where(s => s.Age > 20).ToList();
            foreach (var student in result1)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
            var result2 = students.Where(s => s.Department == "CS").ToList();
            foreach (var student in result2)
            {
                Console.WriteLine($"Name: {student.Name}, Department: {student.Department}");
            }
            var result3 = students.Select(s => new { s.Name, s.Department }).ToList();
            foreach (var item in result3)
            {
                Console.WriteLine($"Name: {item.Name}, Department: {item.Department}");
            }
            var result4 = students.OrderBy(s => s.GPA).ToList();
            foreach (var student in result4)
            {
                Console.WriteLine(student);
            }
            var result5 = students.OrderByDescending(s => s.GPA).ThenBy(s => s.Name).ToList();
            foreach (var student in result5)
            {
                Console.WriteLine(student);
            }
            var result6 = students.Take(5).ToList();
            foreach (var student in result6)
            {
                Console.WriteLine(student);
            }
            var result7 = students.Where(s => s.GPA < 2.0).ToList();
            foreach (var student in result7)
            {
                Console.WriteLine(student);
            }
            var result8 = students.Where(s => s.GPA > 2.0).ToList();
            foreach (var student in result8)
            {
                Console.WriteLine(student);
            }
            var result9 = students.Count();
            Console.WriteLine(result9);

            var result10 = students.Where(s => s.Name.Length > 5).ToList();
            foreach (var student in result10)
            {
                Console.WriteLine(student);
            }

            //Level 2 – Aggregation & Calculation

            var re1 = students.Count();
            Console.WriteLine(re1);
            var re2 = students.Max(s => s.GPA);
            Console.WriteLine(re2);
            var re3 = students.Min(s => s.GPA);
            Console.WriteLine(re3);
            var re4 = students.Average(s => s.GPA);
            Console.WriteLine(re4);
            var re5 = students.Where(s => s.Department == "CS").Average(s => s.GPA);
            Console.WriteLine(re5);
            var re6 = students.Sum(s => s.GPA);
            Console.WriteLine(re6);
            var re7 = students.Count(s => s.GPA > re4);
            Console.WriteLine(re7);
            var re8 = students.OrderByDescending(s => s.GPA).Take(3).Average(s => s.GPA);
            Console.WriteLine(re8);
            var re9 = students.OrderBy(s => s.GPA).Skip(2).Average(s => s.GPA);
            Console.WriteLine(re9);
            var re10 = students.OrderBy(s => s.GPA).Take(10);
            Console.WriteLine(re10);
            var re11 = students.Count() > 20;
            Console.WriteLine(re11);

            //Level 3 – Advanced LINQ 

            var r1 = students.GroupBy(s => s.Department).Select(g => new { Department = g.Key, Count = g.Count() }).ToList();
            foreach (var item in r1)
            {
                Console.WriteLine($"Department: {item.Department}, Count: {item.Count}");
            }
            var r2 = students.GroupBy(s => s.Department).Select(g => new { Department = g.Key, AverageGPA = g.Average(s => s.GPA) }).ToList();
            foreach (var item in r2)
            {
                Console.WriteLine($"Department: {item.Department}, Average GPA: {item.AverageGPA}");
            }

            var r3 = students.GroupBy(s => s.GPA < 2.5 ? "Low" : s.GPA <= 3.5 ? "Medium" : "High").Select(g => new { Category = g.Key, Count = g.Count() }).ToList();
            foreach (var item in r3)
            {
                Console.WriteLine($"Category: {item.Category}, Count: {item.Count}");
            }

            var r4 = students.Join(enrollments, s => s.Id, e => e.StudentId, (s, e) => new { s.Name, e.CourseId }).Join(courses, se => se.CourseId, c => c.Id, (se, c) => new { se.Name, c.Title }).ToList();
            foreach (var item in r4)
            {
                Console.WriteLine($"Name: {item.Name}, Course: {item.Title}");
            }

            var r5 = students.GroupJoin(enrollments, s => s.Id, e => e.StudentId, (s, es) => new { s.Name, CourseCount = es.Count() }).ToList();
            foreach (var item in r5)
            {
                Console.WriteLine($"Name: {item.Name}, Course Count: {item.CourseCount}");
            }

            var r6 = students.GroupJoin(enrollments, s => s.Id, e => e.StudentId, (s, es) => new { s.Name, TotalCredits = es.Join(courses, e => e.CourseId, c => c.Id, (e, c) => c.Credits).Sum() }).ToList();
            foreach (var item in r6)
            {
                Console.WriteLine($"Name: {item.Name}, Total Credits: {item.TotalCredits}");
            }

            var r7 = students.Where(s => !enrollments.Any(e => e.StudentId == s.Id)).ToList();
            foreach (var student in r7)
            {
                Console.WriteLine($"Name: {student.Name} has not enrolled in any courses.");
            }

            var r8 = students.GroupBy(s => s.Department).Select(g => new { Department = g.Key, HighestGPA = g.Max(s => s.GPA) }).ToList();
            foreach (var item in r8)
            {
                Console.WriteLine($"Department: {item.Department}, Highest GPA: {item.HighestGPA}");
            }

            var r9 = students.GroupBy(s => s.Department).Select(g => new { Department = g.Key, AvgGPA = g.Average(s => s.GPA) }).OrderByDescending(x => x.AvgGPA).ToList();
            foreach (var item in r9)
            {
                Console.WriteLine($"Department: {item.Department}, Average GPA: {item.AvgGPA}");
            }
        }
    }
    
}
