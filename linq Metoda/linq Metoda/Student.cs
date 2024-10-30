using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_Metoda
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public override string ToString()
        {
            string ispis = "Redni Broj:" + this.StudentID + "Ime:" + this.StudentName;
            return ispis;
        }
    }
}
