using System;

namespace laba5
{
    public class Student //Создать пространство имен с классом student,
    { // содержащий поля: фамилия и инициалы, номер группы, возраст. И методом выводящим информацию о студенте
        public string Name;
        public string Group;
        private int Age; //Поле возраст имеет модификатор private

        public Student(string name, string group, int age) // и н и ц и а л и з а ц и я  
        {
            Name = name;
            Group = group;
            Age = age;
        }

        public void PrintInfo() // м е т о д   в ы в о д а 
        {
            Console.WriteLine($"Имя: {Name}, Группа: {Group}, Возраст: {Age}");
        }
    }
}

namespace Reader //Создать другое пространство имен с классом Reader,
{ // хранящий информацию о пользователе библиотеки: ФИО, номер читательского билета, факультет, дата рождения, телефон
    public class Reader
    {
        private string FullName; //поле ФИО имеет модификатор private.
        public string CardNumber;
        public string Faculty;
        private string DateOfBirth; //поле дата рождения имеет модификатор private.
        public string PhoneNumber;

        public Reader(string fullName, string cardNumber, string faculty, string dateOfBirth, string phoneNumber)
        { // и н и ц и а л и з а ц и я  
            FullName = fullName;
            CardNumber = cardNumber;
            Faculty = faculty;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {FullName}, Номер читательского билета: {CardNumber}, Факультет {Faculty}, Дата рождения: {DateOfBirth}, Телефон: {PhoneNumber}");
        }

        public void TakeBook(int count) //takeBook, который будет принимать количество взятых книг
        {
            Console.WriteLine($"{FullName} взял(а) {count} книг(и)");
        }

        public void TakeBook(params string[] bookNames) //takeBook, который будет принимать переменное количество названий книг
        {
            Console.WriteLine($"{FullName} взял(а) книги: {string.Join(", ", bookNames)}");
        }

        public void ReturnBook(int count) //Аналогичным образом перегрузить метод returnBook()
        {
            Console.WriteLine($"{FullName} вернул(а) {count} книг(и)");
        }

        public void ReturnBook(params string[] bookNames) //Аналогичным образом перегрузить метод returnBook()
        {
            Console.WriteLine($"{FullName} вернул(а) книги: {string.Join(", ", bookNames)}");
        }
    }
}

class Program
{
    static void Main(string[] args) //В методе main создать два массива объектов, содержащих по три элемента каждый
    {
        laba5.Student[] students = new laba5.Student[3]
                {
                new laba5.Student("Гусин А. Д.", "18it21", 25),
                new laba5.Student("Кислый Е. Д.", "18it22", 24),
                new laba5.Student("Модный Н. Н.", "18it19", 21)
                };

        Reader.Reader[] readers = new Reader.Reader[3]
                {
                new Reader.Reader("Гусин А. Д.", "123456", "Английского языка", "1998.02.12", "+71234567890"),
                new Reader.Reader("Кислый Е. Д.", "234567", "Английского языка", "1999.12.02", "+71234567891"),
                new Reader.Reader("Модный Н. Н.", "345078", "Английского языка", "2002.01.9", "+71234567892")
                };

        foreach (var student in students)
        {
            student.PrintInfo();
        }

        foreach (var reader in readers)
        {
            reader.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[1].TakeBook("Философия", "Словарь", "История");
        readers[0].ReturnBook(3);
        readers[1].ReturnBook("Философия", "Словарь", "История");
    }
}


