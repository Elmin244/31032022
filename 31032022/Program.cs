using System;

namespace _31032022
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            {
                student1.FullName = "Fidan Agayarova";
            }
            Student student2 = new Student();
            {
                student2.FullName = "Feyruz Agayarov";
            }
            Student student3 = new Student();
            {
                student3.FullName = "Teymur Emiraslanov";
            }
            Student student4 = new Student();
            {
                student4.FullName = "Yusif Hesenov";
            }
            Student student5 = new Student();
            {
                student5.FullName = "Nergiz Ismayilova";
            }
            Group group1 = new Group(Type.programming)
            {
                students = new Student[1]
            };
            Group group2 = new Group(Type.design)
            {
                students = new Student[2]
            };
            Group group3 = new Group(Type.system)
            {
                students = new Student[3]
            };
            Group group4 = new Group(Type.system)
            {
                students = new Student[4]
            };
            foreach (Student student in group1.students)
            {
                Console.WriteLine($"FullName:{student.FullName}- No:{student.No} GroupNo: {group1.No}");
            }
            foreach (Student student in group2.students)
            {
                Console.WriteLine($"FullName:{student.FullName}- No:{student.No} GroupNo: {group2.No}");
            }
            foreach (Student student in group3.students)
            {
                Console.WriteLine($"FullName:{student.FullName}- No:{student.No} GroupNo: {group3.No}");
            }
            foreach (Student student in group4.students)
            {
                Console.WriteLine($"FullName:{student.FullName}- No:{student.No} GroupNo: {group4.No}");
            }


        }
    }
}
