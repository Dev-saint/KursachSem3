using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsKP
{
    public class Doctor : Person
    {
        private string Specialization = "";
        public Doctor() : base("", "", "")
        {
            Specialization = "";
        }
        public Doctor(string surname, string name, string patronymic, string specialization) : base(surname, name, patronymic)
        {
            Specialization = specialization;
        }
        public string GetSpecialization()
        {
            return Specialization;
        }
        public void SetSpecialization(string specialization)
        {
            Specialization = specialization;
        }
        public void Set(string surname, string name, string patronymic, string specialization)
        {
            base.Set(surname, name, patronymic);
            Specialization = specialization;
        }
        public override string Info()
        {
            return "ФИО и специализация доктора: " + Surname + " " + Name + " " + Patronymic + ", " + Specialization;
        }
        public bool ReadDoctor(string Path)
        {
            try
            {
                string FullPath = Path;
                string docFIO;
                string docSpec;
                int found = 0;
                using (StreamReader sr = new StreamReader(FullPath, System.Text.Encoding.Default, false))
                {
                    docFIO = sr.ReadLine();
                    found = docFIO.IndexOf(": ");
                    docFIO = docFIO.Substring(found + 2);
                    string[] FIO = docFIO.Split(' ');
                    Surname = FIO[0];
                    Name = FIO[1];
                    Patronymic = FIO[2];
                    docSpec = sr.ReadLine();
                    found = docSpec.IndexOf(": ");
                    docSpec = docSpec.Substring(found + 2);
                    Specialization = docSpec;
                }
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
