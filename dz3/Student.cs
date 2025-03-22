using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class Student
    {
        private string _FIO;
        private int _groupNumber;
        private int _gradeBookNumber;

        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public int GroupNumber { get; }
        public int GradeBookNumber { get; }
        public string SNILS { get; }

        public Student(string fIO, int groupNumber, int recordBookNumber, string snils)
        {
            FIO = fIO;
            GroupNumber = groupNumber;
            GradeBookNumber = recordBookNumber;
            SNILS = snils;
        }

        public string Information() => $"Фио: {_FIO}\nНомер группы: {GroupNumber}\nНомер зачётной книжки: {GradeBookNumber}\nСнилс: {SNILS}";
    }
}
