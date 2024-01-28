using Nest;

namespace ConsoleApp2
{
    internal class Staff
    {
        private Name name;
        private Name name1;

        public Staff(int id, object surname, object name, object patronymic, object birthdate, object passport, object post, object salary, object userid)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthdate = birthdate;
            Passport = passport;
            Post = post;
            Salary = salary;
            Userid = userid;
        }

        public Staff(int id, object surname, Name name, object patronymic, object birthdate, object passport, object post, object salary, object userid)
        {
            Id = id;
            Surname = surname;
            this.name = name;
            Patronymic = patronymic;
            Birthdate = birthdate;
            Passport = passport;
            Post = post;
            Salary = salary;
            Userid = userid;
        }

        public Staff(int id, object surname, Name name1, object patronymic, object birthdate, object passport, object post, object salary, object userid)
        {
            Id = id;
            Surname = surname;
            this.name1 = name1;
            Patronymic = patronymic;
            Birthdate = birthdate;
            Passport = passport;
            Post = post;
            Salary = salary;
            Userid = userid;
        }

        public int Id { get; }
        public object Surname { get; }
        public object Name { get; }
        public object Patronymic { get; }
        public object Birthdate { get; }
        public object Passport { get; }
        public object Post { get; }
        public object Salary { get; }
        public object Userid { get; }
    }
}