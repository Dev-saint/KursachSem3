using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsKP
{
    public class Patient : Person
    {
        public Patient() : base("", "", "")
        {
            ;
        }
        public Patient(string surname, string name, string patronymic) : base(surname, name, patronymic)
        {
            ;
        }
        public override string Info()
        {
            return "ФИО пациента: " + Surname + " " + Name + " " + Patronymic;
        }
    }
}
