using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public class MethodStudent
    {
        private string FIO;
        private int groupNumber;
        private int gradeBookNumber;
        private string snils;

        public MethodStudent(string fIO, int groupNumber, int gradeBookNumber, string snils)
        {
            FIO = fIO;
            this.groupNumber = groupNumber;
            this.gradeBookNumber = gradeBookNumber;
            this.snils = snils;
        }

        public void SetFIO(string fIO) => FIO = fIO;
        public string GetFIO() => FIO;

        public void SetGroupNumber(int groupNumber) => this.groupNumber = groupNumber;
        public int GetGroupNumber() => groupNumber;

        public void SetGradeBookNumber(int gradeBookNumber) => this.gradeBookNumber = gradeBookNumber;
        public int GetGradeBookNumber() => groupNumber;

        public void SetSnils(string snils) => this.snils = snils;
        public string GetSnils() => snils;

        public string Information() => $"Фио: {FIO}\nНомер группы: {groupNumber}\nНомер зачётной книжки: {gradeBookNumber}\nСнилс: {snils}";
    }
}
