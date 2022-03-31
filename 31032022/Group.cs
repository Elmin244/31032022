using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    class Group
    {
        private static int _noP = 100;
        private static int _noD=100;
        private static int _noS = 100;
        public Group(Type _type)
        {
            this.type = _type;
            switch (_type)
            {
                case Type.programming:
                    _noP++;
                    numberofGroup = numberofGroup + ("P" + _noP);
                    break;
                case Type.design:
                    _noD++;
                    numberofGroup = numberofGroup + ("D" + _noD);
                    break;
                case Type.system:
                    _noS++;
                    numberofGroup = numberofGroup + ("S" + _noS);
                    break;
                default:
                    break;
            }
            this.No = numberofGroup;
        }
        
        public string No { get; }
        private string numberofGroup = " ";
        public Student[] students { get; set; }
        public Type type { get; set; }
        public Student FindStudentByNo(int no)
        {
            foreach (Student student in this.students)
            {
                if (student.No==no)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
