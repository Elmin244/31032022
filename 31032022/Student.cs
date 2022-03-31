using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class Student
    {
        public string FullName { get; set; }
        private static int _no;
        public Student()
        {
            _no++;
            this.No = _no;
        }
        public int No { get; }
    }
}
