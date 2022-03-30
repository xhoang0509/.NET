using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }

        public int scholarship
        {
            get
            {
                if (mark > 8)
                {
                    return 500;
                }
                else if (7 <= mark && mark <= 8)
                {
                    return 300;
                }
                else
                {
                    return 0; ;
                }
            }
        }

        public Student()
        {

        }

        public Student(string id)
        {
            this.id = id;
        }

        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
    }
}
