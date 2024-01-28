namespace ConsoleApp2
{
    internal class Cashier
    {
        private int id;
        private string login;
        private string password;
        private string role;

        public Cashier(int id, string login, string password, string role)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
        }
    }
}