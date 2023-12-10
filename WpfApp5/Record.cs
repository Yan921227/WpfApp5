using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class Record
    {
        public   Student SelectedStudent { get; set; }
       public Course SelectedCourse { get; set; }

        public bool Equals(Record r) //人與課不重複
        {
            return this . SelectedStudent.StudentId == r.SelectedStudent.StudentId &&
                this.SelectedCourse .CourseName == r.SelectedCourse .CourseName;
        }
    }
}
