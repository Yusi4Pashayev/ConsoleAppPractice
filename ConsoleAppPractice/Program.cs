using ConsoleAppPractice.Modells;
using ConsoleAppPractice.Servicces;

namespace ConsoleAppPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var groupManager = new GroupManager();
            var departmentManager = new DepartmentManager();
            var teacherManager = new TeacherManager();
            var StudentManager = new StudentManager();

            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                #region Group Manager
                if (command.ToLower() == "add group")
                {
                    var group1 = new Group()
                    {
                        Id = 123,
                        Name = "P329",
                    };

                    var group2 = new Group()
                    {
                        Id = 211,
                        Name = "P333",
                    };

                    groupManager.Add(group1);

                    groupManager.Add(group2);

                }
                else if (command.ToLower() == "update group")
                {
                    Console.Write("Id daxl edin:");
                    var id = int.Parse(Console.ReadLine());

                    var existGroup = groupManager.Get(id);

                    if (existGroup == null) continue;

                    Console.WriteLine(existGroup);

                    var group3 = new Group()
                    {
                        Id = 3,
                        Name = "A327",
                    };

                    groupManager.Update(id, group3);

                }

                else if (command.ToLower().Equals("print groups"))
                {
                    groupManager.Print();
                }

                else if (command.ToLower().Equals("delete group"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    groupManager.Delete(id);
                }

                #endregion

                #region Department Manager

                else if (command.ToLower() == "add department")
                {
                    var department1 = new Department()
                    {
                        Id = 1,
                        Name = "Neft qaz",
                    };

                    var department2 = new Department()
                    {
                        Id = 2,
                        Name = "ITIF",
                    };

                    departmentManager.Add(department1);

                    departmentManager.Add(department2);

                }
                else if (command.ToLower() == "update department")
                {
                    Console.Write("Id daxl edin:");
                    var id = int.Parse(Console.ReadLine());

                    var existDepartment = departmentManager.Get(id);

                    if (existDepartment == null) continue;

                    Console.WriteLine(existDepartment);

                    var department3 = new Department()
                    {
                        Id = 3,
                        Name = "Mexanika",

                    };

                    departmentManager.Update(id, department3);

                }

                else if (command.ToLower().Equals("print departments"))
                {
                    departmentManager.Print();
                }

                else if (command.ToLower().Equals("delete department"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    departmentManager.Delete(id);
                }

                #endregion

                #region Teacher Manager

                else if (command.ToLower() == "add teacher")
                {
                    var Teacher1 = new Teacher()
                    {
                        Id = 1,
                        FirstName = "Memmed",
                        LastName = "Memmedov",
                        FatherName = "Memmed oglu",
                        Age = 28,
                        Department = new Department()
                        {
                            Id = 1,
                            Name = "Neft qaz",

                        },
                        Group = new Group()
                        {
                            Id = 123,
                            Name = "P329",
                        },
                        Subject = "Art"

                    };

                    var Teacher2 = new Teacher()
                    {
                        Id = 2,
                        FirstName = "Eli",
                        LastName = "Eliyev",
                        FatherName = "Eli oglu",
                        Age = 29,
                        Department = new Department()
                        {
                            Id = 2,
                            Name = "ITIF",

                        },
                        Group = new Group()
                        {
                            Id = 211,
                            Name = "P333",
                        },
                        Subject = "Philosophy"
                    };

                    teacherManager.Add(Teacher1);

                    teacherManager.Add(Teacher2);

                }
                else if (command.ToLower() == "update teacher")
                {
                    Console.Write("Id daxl edin:");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    if (existTeacher == null) continue;

                    Console.WriteLine(existTeacher);

                    var teacher3 = new Teacher()
                    {
                        Id = 3,
                        FirstName = "Salam",
                        LastName = "Salamov",
                        FatherName = "Salam oglu",
                        Age = 30,
                        Department = new Department()
                        {
                            Id = 3,
                            Name = "Mexanika",

                        },
                        Group = new Group()
                        {

                            Id = 3,
                            Name = "A327",

                        },
                        Subject= "math"
                        

                    };

                    teacherManager.Update(id, teacher3);

                }

                else if (command.ToLower().Equals("print teacher"))
                {
                    teacherManager.Print();
                }

                else if (command.ToLower().Equals("delete teacher"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }

                #endregion

                #region Student Manager 
                
                else if (command.ToLower() == "add student")
                {
                    var student1 = new Student()
                    {
                        Id = 1,
                        FirstName = "Elvin",
                        LastName = "Cebrayilov",
                        FatherName = "... oglu",
                        Age = 24,
                        
                        Group = "P329",
                        Course = "1",
                        EntryDate= DateTime.Now,

                    };

                    var student2 = new Student()
                    {
                        Id = 2,
                        FirstName = "Vusal",
                        LastName = "Eliyev",
                        FatherName = "... oglu",
                        Age = 23,

                        Group = "P329",
                        Course = "1",
                        EntryDate = DateTime.Now,
                    };

                    StudentManager.Add(student1);

                    StudentManager.Add(student2);

                }
                else if (command.ToLower() == "update student")
                {
                    Console.Write("Id daxl edin:");
                    var id = int.Parse(Console.ReadLine());

                    var existStudent = StudentManager.Get(id);

                    if (existStudent == null) continue;

                    Console.WriteLine(existStudent);

                    var student3 = new Student()
                    {
                        Id = 2,
                        FirstName = "Elcin",
                        LastName = "Quliyev",
                        FatherName = "... oglu",
                        Age = 23,

                        Group = "P329",
                        Course = "1",
                        EntryDate = DateTime.Now,
                    };

                    StudentManager.Update(id, student3);

                }

                else if (command.ToLower().Equals("print student"))
                {
                    StudentManager.Print();
                }

                else if (command.ToLower().Equals("delete student"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    StudentManager.Delete(id);
                }

                #endregion

            } while (command.ToLower() != "quit");

        }
    }
}