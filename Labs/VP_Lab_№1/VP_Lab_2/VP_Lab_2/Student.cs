using System;

namespace UniversityApp
{
    // класс Student
    public class Student : Person
    {
        // дополнительные свойства студента
        public string Id { get; set; }
        public string Citizenship { get; set; }
        public StudyForm Form { get; set; }

        // конструктор
        public Student(string lastName, string firstName, string middleName,
                       DateTime birthDate, string address, string phone,
                       string id, string citizenship, StudyForm form)
            : base(lastName, firstName, middleName, birthDate, address, phone)
        {
            Id = id;
            Citizenship = citizenship;
            Form = form;
        }

        // переопределение GetInfo
        public override string GetInfo()
        {
            return base.GetInfo() +
                   "\nНомер зачетной книжки: " + Id +
                   "\nГражданство: " + Citizenship +
                   "\nФорма обучения: " + Form;
        }

        // переопределение Equals
        public override bool Equals(object obj)
        {
            Student otherStudent = obj as Student;

            if (otherStudent == null)
                return false;

            return LastName == otherStudent.LastName &&
                   FirstName == otherStudent.FirstName &&
                   MiddleName == otherStudent.MiddleName &&
                   BirthDate == otherStudent.BirthDate &&
                   Address == otherStudent.Address &&
                   Phone == otherStudent.Phone &&
                   Id == otherStudent.Id &&
                   Citizenship == otherStudent.Citizenship &&
                   Form == otherStudent.Form;
        }

        // переопределение операторов ==
        public static bool operator ==(Student left, Student right)
        {
            if ((object)left == null && (object)right == null)
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Equals(right);
        }

        // переопределение операторов !=
        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
