using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsKP
{
    public abstract class Person
    {
        protected string Surname;
        protected string Name;
        protected string Patronymic;

        public Person()
        {
            Surname = "";
            Name = "";
            Patronymic = "";
        }

        public Person(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        public string GetSurname()
        {
            return this.Surname;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetPatronymic()
        {
            return this.Patronymic;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPatronymic(string patronymic)
        {
            Patronymic = patronymic;
        }

        public void Set(string surname, string name, string patronymic)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
        }

        public virtual string Info()
        {
            return "ФИО: " + Surname + " " + Name + " " + Patronymic;
        }
    }
}
