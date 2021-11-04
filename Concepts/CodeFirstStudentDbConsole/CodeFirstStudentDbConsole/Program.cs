using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudentDbConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentsContext())//
            {
                Console.WriteLine("Enter Name of student: \n");
                var name = Console.ReadLine();
                var student = new Students { Name = name };
                db.Students.Add(student);
                db.SaveChanges();
                // Display all Students from the database by name 
                var query = from s in db.Students
                            orderby s.Name
                            select s;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        public class Students
        {
            public int Id { get; set; }

            public string Name { get; set; }

        }
        public class  StudentsContext : DbContext
        {
            public DbSet<Students> Students { get; set; }
            
        }
    }
}
