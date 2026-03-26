using System;

namespace UniversityApp
{// класс Group
    public class Group
    {
        private string _groupNumber { get; set; }

        // массив студентов
        private Student[] _students;

        // текущее количество студентов
        private int _count;

        // конструктор
        public Group(string groupNumber)
        {
            _groupNumber = groupNumber;
            _students = new Student[0];
            _count = 0;
        }

        // добавление студента
        public void Add(Student student)
        {
            // проверка на существование
            for (int i = 0; i < _count; i++)
            {
                if (_students[i].Id == student.Id)
                {
                    Console.WriteLine("Студент с таким номером уже существует.");
                    return;
                }
            }

            // создание нового массива большего размера
            Student[] newArray = new Student[_count + 1];

            // копирование старых данных
            for (int i = 0; i < _count; i++)
                newArray[i] = _students[i];

            // добавление нового студента
            newArray[_count] = student;

            _students = newArray;
            _count++;
        }

        // удаление студента
        public void Remove(string id)
        {
            int index = -1;

            // поиск студента
            for (int i = 0; i < _count; i++)
            {
                if (_students[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Студент не найден.");
                return;
            }

            // создание нового массива меньшего размера
            Student[] newArray = new Student[_count - 1];

            int j = 0;
            for (int i = 0; i < _count; i++)
            {
                if (i != index)
                {
                    newArray[j] = _students[i];
                    j++;
                }
            }

            _students = newArray;
            _count--;
        }

        // индексатор (по номеру зачетки)
        public Student this[string id]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_students[i].Id == id)
                        return _students[i];
                }

                return null;
            }
        }

        // переопределение ToString
        public override string ToString()
        {
            // сортировка по фамилии (пузырьковая)
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (string.Compare(_students[i].LastName, _students[j].LastName) > 0)
                    {
                        Student temp = _students[i];
                        _students[i] = _students[j];
                        _students[j] = temp;
                    }
                }
            }

            string result = "Группа: " + _groupNumber + "\n";

            for (int i = 0; i < _count; i++)
                result += _students[i].ToString() + "\n";

            return result;
        }
    }
}
