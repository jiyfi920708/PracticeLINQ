using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
             SeedDatabase();
        }

        public static void SeedDatabase()
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        IList<Student> studentList = new List<Student>() 
                        { 
                            new Student() { StudentID = 1, FirstName = "Laith", LastName = "Alfaloujeh",Role = "senior"},
                            new Student() { StudentID = 2, FirstName = "Mekkala", LastName = "Bourapa",Role = "sophomore"},
                            new Student() { StudentID = 3, FirstName = "Charles", LastName = "Coufal",Role = "junior" },
                            new Student() { StudentID = 4, FirstName = "John", LastName = "Cunningham",Role = "senior" },
                            new Student() { StudentID = 5, FirstName = "Michael",LastName = "Hayes",Role = "sophomore" },
                            new Student() { StudentID = 6, FirstName = "Aaron", LastName = "Hebert",Role = "junior" },
                            new Student() { StudentID = 7, FirstName = "YiFu", LastName = "Ji",Role = "Graduate Student"},
                            new Student() { StudentID = 8, FirstName = "Todd ", LastName = "Kile",Role = "junior"},
                            new Student() { StudentID = 9, FirstName = "Mara", LastName = "Kinoff",Role = "Graduate Student" },
                            new Student() { StudentID = 10, FirstName = "Cesareo", LastName = "Lona",Role = "senior" },
                            new Student() { StudentID = 11, FirstName = "Michael", LastName = "Matthews",Role = "junior" },
                            new Student() { StudentID = 12, FirstName = "Mason", LastName = "McCollum",Role = "sophomore" },
                            new Student() { StudentID = 13, FirstName = "Alexander", LastName = "McDonald",Role = "senior"},
                            new Student() { StudentID = 14, FirstName = "Phelps", LastName = "Merrell",Role = "freshman" },
                            new Student() { StudentID = 15, FirstName = "Quan", LastName = "Nguyen",Role = "senior" },
                            new Student() { StudentID = 16, FirstName = "Alexander", LastName = "Roder",Role = "junior" },
                            new Student() { StudentID = 17, FirstName = "Amy", LastName = "Saysouriyosack",Role = "senior" },
                            new Student() { StudentID = 18, FirstName = "Claudia", LastName = "Silva",Role = "sophomore" },
                            new Student() { StudentID = 19, FirstName = "Gabriela", LastName = "Valenzuela",Role = "junior" },
                            new Student() { StudentID = 20, FirstName = "Kayla", LastName = "Washington",Role = "sophomore" },
                            new Student() { StudentID = 21, FirstName = "Matthew", LastName = "Webb",Role = "senior" },
                            new Student() { StudentID = 22, FirstName = "Cory", LastName = "Williams",Role = "freshman" },
                          

                        };  

                        db.Students.AddRange(studentList);

                        db.SaveChanges();
                    }

                    else
                    {
                        var studnets = db.Students.ToList();
                        
                        //where practice
                        //var studentFiltered = studnets.Where(s => s.Role !="senior");

                        //var studentFiltered = studnets.Where(s => s.FirstName.StartsWith("M"));

                        //var studentFiltered = studnets.Where(s => s.LastName.StartsWith("L"));

                        //var studentFiltered = db.Students
                        //                        .OrderBy(s => s.LastName)
                        //                        .Where(s => s.LastName.StartsWith("L") && s.FirstName.Length>= 6);

                        //

                        
                        //Find Practice
                        //var studentFiltered = from s in studnets
                        //                      where s.LastName.Contains("John")
                        //                      select s;
                        //var studentFiltered = studnets.Where(s => s.FirstName.Contains("John"));

                        //var studentFiltered = studnets.Where(s => s.FirstName.Contains("Alexander"));

                        //var studentFiltered = s.FirstName.Min(s => s.Length);

                        //

                        //


                        //Sort Practice
                        //var studentFiltered = from student in studnets
                        //            orderby student.FirstName
                        //            select student;

                        //var studentFiltered = from student in studnets
                        //            orderby student.LastName descending
                        //            select student;

                        //

                        //var studentFiltered = from s in studnets
                        //                      orderby s.FirstName, s.Role ="senior"
                        //                      select s;

                        //var studentFiltered = from s in studnets
                        //            orderby s.LastName descending, s.Role !="senior"
                        //            select s;

                        //Group Practice
                        //

                        //

                        //

                        foreach(Student s in studentFiltered)
                        {
                            Console.WriteLine(s);
                        }

                    }
                }

                catch(Exception exp)
                    {
                            Console.WriteLine(exp.Message);
                    }                    
            }    
        }    
    }
}