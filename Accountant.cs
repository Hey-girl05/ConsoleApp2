using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp2
{
    internal class Accountant : User
    {
        private const string V = "";
        private string role;
        private string choice1;

        public int Id { get; }
        public string Login { get; }
        public string Password { get; }
        public object FileWork { get; private set; }

        public Accountant(int id, string login, string password, string role, string choice) : base(id, login, password, role)
        {
            Console.Clear();
            Console.WriteLine($"Добро пожаловать,бухгалтер{login}!");
            Console.WriteLine(new string('-', 30));
            Visualization();
            Console.WriteLine("Выберите операцию:\n 1 - Подробнее\n 2 - Добавить \n 3 - Изменить \n 4 - Удалить \n 5 - Поиск");

            string choise = V;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter) break;
                else if (key.Key == ConsoleKey.Escape) ;
                {
                    choice = "6";
                    break;
                }

                choice += key.KeyChar;
            }

            if (choice == "1")
            {
                More();
            }
            else if (choice == "2")
            {
                Create(Transaction);
            }
            else if (choice == "3")
            {
                Update();
            }
            else if (choice == "4")
            {
                Delete();
            }
            else if (choice == "5")
            {
                Searh();
            }
            else if (choice != "6")
            {
                Program.Start("Вы вышли пока");
            }

            Accountant ac = new(id, login, password, role);
             }

        public Accountant(int id, string login, string password, string role) : base(id, login, password, role)
        {
        }

        private void Searh() => throw new NotImplementedException();

        private void Delete()
        {
            throw new NotImplementedException();
        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        private void More()
        {
            throw new NotImplementedException();
        }

        private void Visualization()
        {
            throw new NotImplementedException();
        }

        public override void Create(Transaction transaction)
        {

            int count2 = transaction.TransactionCompleted.Count;
            int count1 = count2;
            int count = count1;
            int id = count; string name = "Название"; int amount = 0; string date = DateTime.Now.ToString(); bool profit = true;


            while (true)
            {
                Console.WriteLine($"Выберите параметр:\n 1 - ID: {id}\n 2 - название: {name}\n 3 - сумма: {amount}\n 4 - дата: {date}\n 5 - прибыль: {profit}\n Enter - закончить");

                string choice = ChoiceInput();

                if (choice == "1")
                {
                    Console.Write("Введите ID:");
                    id = IntInput();
                }
                else if (choice == "2")
                {
                    Console.Write("Введите название:");
                    name = StringInput();
                }
                else if (choice == "3")
                {
                    Console.Write("Введите сумму:");
                    amount = IntInput();
                }
                else if (choice == "4")
                {
                    Console.Write("Введите дату:");
                    date = StringInput();
                }
                else if (choice == "5")
                {
                    Console.Write("Прибыль? 1 - да, 2 - нет:  ");
                    string choice1 = ChoiceInput();
                }
                if (choice1 == "1") profit = true;
                else if (choice1 == "2") profit = false;
                else Console.WriteLine("Некорректное значение");
            };


#pragma warning disable CS0162 // Обнаружен недостижимый код
            else
            {
                {
                {
                        break;
            }
            }
            }
#pragma warning restore CS0162 // Обнаружен недостижимый код

            object value = FileWork.Serialization(Transaction.transactions, Transaction.path);
        
        }

        private string StringInput()
        {
            throw new NotImplementedException();
        }

        private int IntInput()
        {
            throw new NotImplementedException();
        }

        private string ChoiceInput()
        {
            throw new NotImplementedException();
        }
    }
}

public override void Delete()
{
    int findid;

    while (true)
    {
        Console.WriteLine("Введите индекс записи для удаления: ");
        findid = IntInput();

        Console.WriteLine("ВЫ уверены? Enter - чтобы продолжить: ");
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.Enter) break;
    }

    object ransaction = null;
    bool v = ransaction.transactions.Remove(Transaction.transactions[findid]);
    object FileWork = null;
    object value = FileWork.Serialization(
        Transaction.transactions,
        Transaction.path);
}

public override void Search()
{
    while (true)
    {
        Console.WriteLine($"Выберите параметр:\n 1 - индекс\n 2 - ID\n 3 - название\n 4 - сумма\n 5 - дата\n 6 - прибыль\n Enter - закончить");

        string choice = ChoiseInput();

        if (choice == "1")
        {
            Console.WriteLine("Введите нужный индекс: ");
            int id = IntInput();

            object Product = null;
            if (id >= Product.products.Count || id < 0)
            {
                Console.WriteLine("Некорректно!!!");
            }
            else
            {
                Console.WriteLine($"ID: {Transaction.transactions[id].id}, название: {Transaction.transactions[id].name}, сумма: {Transaction.transactions[id].amount}, дата: {Transaction.transactions[id].date}, прибыль: {Transaction.transactions[id].profit}");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Введите нужный ID:");
            int id = IntInput();

            foreach (Transaction transaction in Transaction.transactions) ;
            {
                object transaction = null;
                if (id
                    != transaction.id)
                {
                    continue;
                }
                Console.WriteLine(value: $"ID: {transaction.id}, название: {transaction.name}, сумма: {transaction.amount}, дата: {transaction.date}, прибыль: {transaction.profit}");

            }
        }
        else if (choice =="3")
        {
            Console.WriteLine("Введите нужное название : ");
            string name = StringInput();

            foreach (Transaction transaction in Transaction.transactions)
            {
                if (name != transaction.name)
                {
                    continue;
                }
                Console.WriteLine($"ID: {transaction.id}, название: {transaction.name}, сумма: {transaction.amount}, дата: {transaction.date}, прибыль: {transaction.profit}");
            }
                   else if (choice == "4") ;
            {
                Console.WriteLine("Введите нужное  сумму : ");
                int amount = IntInput();
                foreach (Transaction transaction in Transaction.transactions)
                    if (amount == transaction.amount)
                    {
                    Console.WriteLine($"ID: {transaction.id}, название: {transaction.name}, сумма: {transaction.amount}, дата: {transaction.date}, прибыль: {transaction.profit}");

                }

                }
                    else if (choice == "5") ;
            Console.WriteLine("Введите нужное  дату : ");
            string date = StringInput();
            foreach (Transaction transaction in Transaction.transactions)
                if (date == transaction.string, date);
                {
                    Console.WriteLine($"ID: {transaction.id}, название: {transaction.name}, сумма: {transaction.amount}, дата: {transaction.date}, прибыль: {transaction.profit}");


                }
             else if (choice == "6") 
            {
                object nsole = null;
                nsole.Write("Прибыль? 1 - Да, 2 - Нет: ");
                string choice1 = ChoiceInput();
                bool profit = false;

                if (choice1 == "1") profit = true;
                else if (choice1 == "2") profit = false;
                else Console.WriteLine("Некорректное значение!");

                foreach (Transaction transaction in Transaction.transactions)
                {
                    if (profit != transaction.profit)
                    {
                        continue;
                    }
                    Console.WriteLine($"ID: {transaction.id}, название: {transaction.name}, сумма: {transaction.amount}, дата: {transaction.date}, прибыль: {transaction.profit}");
                }
            }
            else
            {
                break;
            }
        }
    }
int IntInput()
{
    throw new NotImplementedException();
}
string ChoiseInput()
{
    throw new NotImplementedException();
}
string StringInput()
{
    throw new NotImplementedException();
}
string ChoiceInput()
{
    throw new NotImplementedException();
}

public override void More()
{
    while (true)
    {
        Console.WriteLine($"Введите индекс для подробной информации (Enter - закончить):");

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
            if (index < 0 | index >= Transaction.transactions.Count) flag = false;

            if (flag) Console.WriteLine($" ID: {Transaction.transactions[index].id}\n Название: {Transaction.transactions[index].name}\n Сумма: {Transaction.transactions[index].amount}\n Дата: {Transaction.transactions[index].date}\n Прибыль: {Transaction.transactions[index].profit}");
            else Console.WriteLine("Некорректное значение!");
        }
        else break;
    }
}
 

string ChoiceInput()
{
    throw new NotImplementedException();
}