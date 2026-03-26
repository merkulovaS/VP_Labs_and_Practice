using System;

namespace UniversityApp
{
    // Перечисление формы обучения
    public enum StudyForm
    {
        Budget,
        Commercial,
        Target
    }

    // класс Person
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        // конструктор
        public Person(string lastName, string firstName, string middleName,
                      DateTime birthDate, string address, string phone)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
        }

        // переопределение ToString (возвращает ФИО)
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(MiddleName))
                return LastName + " " + FirstName;

            return LastName + " " + FirstName + " " + MiddleName;
        }

        // виртуальный метод получения полной информации
        public virtual string GetInfo()
        {
            return "ФИО: " + ToString() +
                   "\nДата рождения: " + BirthDate.ToString("dd.MM.yyyy") +
                   "\nАдрес: " + Address +
                   "\nТелефон: " + Phone;
        }
    }
}
