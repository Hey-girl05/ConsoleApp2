using System.Transactions;

namespace ConsoleApp2
{
    internal class User
    {
        internal static IEnumerable<User> user;
        private int id;
        private string login;
        private string password;
        private string role;

        public User(int id, string login, string password, string role)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public static string Binding(string login);
        { 
        foreach         public override void Create()
        {
            int id = Staff.staff.Count; string surname = "Нербышев"; string name = "Тагир"; string patronymic = "-"; string birthdate = "01.01.2000"; string passport = "1234 123456"; string post = "Никто"; int salary = 10000; int userid = Staff.staff.Count;

            while(true)
            {
                Console.WriteLine($"Выберите параметр:\n 1 - ID: {id}\n 2 - фамилия: {surname}\n 3 - имя: {name}\n 4 - отчество: {patronymic}\n 5 - дата рождения: {birthdate}\n 6 - серия и номер паспорта: {passport}\n 7 - должность: {post}\n 8 - зарплата: {salary}\n 9 - ID пользователя: {userid}\n Enter - закончить");

                string v = ChoiceInput();
                string choice = v;

                if (choice == "1")
                {
                    Console.WriteLine("Введите ID:");
                    id = IntInput();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Введите фамилия:");
                    surname = StringInput();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Введите имя:");
                    name = StringInput();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Введите отчество:");
                    patronymic = StringInput();
                }

                else if (choice == "5")
                {
                    Console.WriteLine("Введите дату рождения:");
                    birthdate = StringInput(); ;
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Введите серию и ноиер паспорта:");
                    passport = StringInput(); 
                }
                else if (choice == "7")
                {
                    Console.WriteLine("Введите должность:");
                    post = StringInput();
                }
                else if (choice == "8")
                {
                    Console.WriteLine("Введите зарплату:");
                    salary = IntInput();
                }
                else if (choice == "8")
                {
                    Console.WriteLine("Введите ID пользователя:");
                    bool userdexist = false;
                    foreach (Staff staff in Staff.staff)
                    {
                        if (userid == staff.userid)
                        {
                            useridexist = true; break;
                        }
                    }


                }
                if (!useridexist) userid = IntInput();
                else Console.WriteLine("Такой ID пользователя уже занят");
            }
                else
            {
                break;
            }
        }

        public override void More()
        {
            while (true)
            {
                Console.WriteLine($"Введите индекс для заказа товара (Enter - закончить):");

                string choice = ChoiceInput();
                int index = 0;
                bool flag = true;
                if (choice != "")
                {
                    try
                    {
                        index = int.Parse(choice);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Некорректное значение!");
                        flag = false;
                    }
                    if (index < 0
                        | index >= Product.products.Count) flag = false;

                    if (flag)
                    {
                        Console.WriteLine(value: $" ID: {Product.products[index].id}\n Название: {Product.products[index].name}\n Цена: {Product.products[index].price}\n Кол-во на складе: {Product.products[index].available}");
                        Console.WriteLine("Кол-во продукта для заказа: ");
                        int selected = IntInput();

                        if (selected != 0 & selected <= Product.products[index].available)
                        {
                            Product.products[index].available -= selected;
                            Transaction newtransaction = new(Transaction.transactions.Count, Product.products[index].name, Product.products[index].price * selected, DateTime.Now.ToString(), true);
                            Transaction.transactions.Add(newtransaction);
                            object value = FileWork.Serialization(Transaction.transactions, Transaction.path);
                        }
                        else
                        {
                            Console.WriteLine("Некорректное значение!");
                        }
                    }
                    else Console.WriteLine("Некорректное значение!");
                }
                else break;
            }
        }
    }
}