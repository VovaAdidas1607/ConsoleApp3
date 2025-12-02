using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Привет 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            //Student student = new Student("Дмитрий", "Нагиев", 0, 4.5);
            PrintAllStudents(students);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Что хотите сделать?");
                Console.WriteLine("1.Создать студента");
                Console.WriteLine("2.Вывести список со студентами ");
                Console.WriteLine("3. Выйти из программы ");
                Console.WriteLine("6. Выйти из программы ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    //Создание студента
                    case 1:
                        string name;
                        string lastname;
                        double mark;
                        int id;

                        //Обработка вводимого студента
                        Console.WriteLine("Имя");
                        name = Console.ReadLine();
                        if (Validator.validation(name, true)) return;
                        Console.WriteLine("Фамилия");
                        lastname = Console.ReadLine();
                        if (Validator.validation(lastname, true)) return;
                        string _id = Console.ReadLine();
                        if (!Validator.validation(_id, true)) return;
                        id = Convert.ToInt32(_id);
                        mark = Convert.ToDouble(Console.ReadLine());
                        Student student = new Student(name, lastname, id, mark);
                        students.Add(student);
                        break;



                        //Вывод списка студентов
                    case 2:
                        PrintAllStudents(students);
                        break;


                        //Поиск студента в списке
                    case 3:
                        Console.WriteLine("Введите фамилию");
                        if (SearchByLastName(students)){
                            Console.WriteLine("Студент есть в списке");
                        }
                        else
                        {
                            Console.WriteLine("Студент нету в списке");
                        }
                            break;

                        //Выход из програмы
                    case 6:
                        Console.WriteLine("Выхожу из программы");
                        exit = true;
                        break;
                }
            }
        }
        static void PrintAllStudents(List<Student> students) //Функция вывода списка студентов
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Студент:{student.FirstName} {student.LastName}");
            }
        }
        static bool SearchByLastName(List<Student> students)
        {
            string lastname = Console.ReadLine();
            foreach (Student student in students)
            {
                
                if (student.LastName == lastname)
                {
                    return true;
                }

            }
            return false;
        }
    }
}

