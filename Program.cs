using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
//using System.Linq;

namespace ConsoleApplication1
{


    class Program
    {
        enum Education
        {
            Spe******t, Bachelor, SecondEducation


        }

        public class Person
        {
            // Field
            public string name;

            // Constructor
            public Person()
            {
                name = "unknown";
            }

            // Method
            public void SetName(string newName)
            {
                name = newName;
            }
        }

        class Exam
        {

            public String Name_s;
            public int Mark;
            public System.DateTime Date;

            public Exam(string a, int b, System.DateTime c)
            {
                Name_s = a; Mark = b; Date = c;
            }

            public Exam()
            {


                Name_s = "no subject`s name ";
                Mark = 777;
                Date = DateTime.Now;
            }

            public override string ToString()
            {
                return "Subject`s name= " + Name_s + "; Mark: " + Mark + "; Date: " + Date.ToString();
            }
        }

        class Student
        {
            private Person Student_info;
            private Education Form_info;
            private int Group;
            private Exam[] Exam_info;
            public Exam[] arr = new Exam[0];
            public Student(string a, Education b, int c)
            {

                Person p = new Person();
                p.SetName(a);
                Student_info = p;
                Form_info = b;
                Group = c;
            }

            public Student()
            {
                Person p = new Person();
                p.SetName("no student");
                Student_info = p;
                Education r = new Education();
                Form_info = r;
                Group = 13;
            }

            public Person getPerson()
            {
                return Student_info;
            }

            public Education getEducation()
            {
                return Form_info;
            }

            public int getInt()
            {
                return Group;
            }

            public Exam[] getExam()
            {
                return arr;
            }


            public void setPerson(Person St)
            {
                Student_info = St;
            }

            public void setEducation(Education F)
            {
                Form_info = F;
            }

            public void setInt(Int16 G)
            {
                Group = G;
            }

            public void setExam(Exam[] m)
            {
                Exam[] arr = m;
            }
            public Double get_GPA() //grade point average- средний бал
            {
                if (arr.Length > 0)
                {
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                        sum += arr[i].Mark;
                    return (sum / arr.Length);
                }
                return 0;

            }

            public bool get_bool(Education b)
            {
                if (Form_info == b) return true;
                else return false;
            }

            public void AddExams(params Exam[] mass)
            {
                Exam[] tmp = new Exam[mass.Length + arr.Length];
                for (int i = 0; i < arr.Length; i++)
                    tmp[i] = arr[i];
                for (int i = 0; i < mass.Length; i++)
                    tmp[i + arr.Length] = mass[i];
                arr = tmp;
            }

            public override string ToString()
            {
                string str = "Student= " + Student_info.name + " \nForm= " + Form_info + " \nGroup= " + Group + " \nExam= " + Exam_info;
                str += "\ncount of exams= " + arr.Length;
                for (int i = 0; i < arr.Length; i++)
                    str += "\n " + arr[i].ToString();
                return str;

            }

            public string ToShortString()
            {
                string str = "Student= " + Student_info.name + " \nForm= " + Form_info + " \nGroup= " + Group + " \nExam= " + Exam_info;
                str += "\nGPA= " + get_GPA();
                return str;
            }

        }

        static void Main(string[] args)
        {
            Student obj1 = new Student();
            Console.WriteLine(obj1.ToShortString());
            System.Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine(obj1.get_bool(Education.Spe * *****t));
            Console.WriteLine(obj1.get_bool(Education.Bachelor));
            Console.WriteLine(obj1.get_bool(Education.SecondEducation));
            System.Console.WriteLine("--------------------------------------------------------------------------------");
            Student obj2 = new Student("new student", Education.Bachelor, 123);
            Console.WriteLine(obj2.ToString());
            System.Console.WriteLine("--------------------------------------------------------------------------------");
            Exam[] arr = new Exam[5];
            for (int i = 0; i < 4; i++)
                arr[i] = new Exam("new" + i, 1, DateTime.Now);
            Console.ReadKey();
            arr[4] = new Exam("new" + 4, 1, DateTime.Now);
            System.Console.WriteLine("--------------------------------------------------------------------------------");
            obj2.AddExams(arr);
            Console.WriteLine(obj2.ToString());
            Console.Write("GPA=");
            Console.WriteLine(obj2.get_GPA());
            Console.ReadKey();
        }
    }
}