using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace attendance_overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Олег", "РПМ");
            student.Visit();





        }
    }
    class Student
    {
        private string _name;

        public string AcademicSubjectName;

        public Student(string name, string academicSubjectName)
        {
            _name = name;
            AcademicSubjectName = academicSubjectName;
        }

        public void Visit()
        {
            while (true)
            //Запрашиваем у пользователя название предмета который сейчас преподают 

            {
                Console.WriteLine($"\nЗдравствуйте {_name}\nВведите название  предмета  ");
                string inputNameSubject = Convert.ToString(Console.ReadLine());
                //Сравниваем название указаного предмета с предметом из списка 
                if (inputNameSubject.ToLower() != AcademicSubjectName.ToLower())
                {
                    Console.WriteLine("Такого предмета не существует!\nНажмите любую клавишу что бы начать заного");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    //После проверки предмета переходим к выбору команды находился ли студент на паре и так же проверяем правильность ввода

                    Console.WriteLine("\nВыберите номер команды:\n1 - присутствовал на паре\n2 - отсутствовал");
                    int visit = Convert.ToInt32(Console.ReadLine());
                    switch (visit)
                    {
                        case 1:
                            Console.WriteLine("Вы молодец! Хорошей вас пары");
                            break;
                        case 2:
                            Console.WriteLine("Жаль, вам необходимо придоставить справку о причине отсутствия ");
                            break;
                        default:
                            Console.WriteLine("Вы выбрали неверную команду. Нажмите любую клавишу что бы начать сначала!");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                    // выводим общую информацию о посещаемости студента  за месяц на данный момент 
                    Console.WriteLine("Ваша посещаемость на данный момент:");
                    {
                        Random rand = new Random();
                        int LessonPerMonth = rand.Next(10, 35);
                        int LessonAttended = rand.Next(10, LessonPerMonth);
                        double PrecentAttendance = (double)LessonAttended / LessonPerMonth * 100;
                        int RoundedPercent = (int)Math.Round(PrecentAttendance, 0);

                        Console.WriteLine($"В этом месяце вы посетили: {RoundedPercent}% процента всех занятий!");

                        if (PrecentAttendance >= 50f)
                            Console.WriteLine("Хороший результат, так держать!");

                        else
                            Console.WriteLine("Плохо,вам стоит чаще посещать занятия ");

                    }

                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

    }
}

