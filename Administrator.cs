namespace ConsoleApp2
{
    internal class Administrator
    {
        private int id;
        private string login;
        private string password;
        private string role;

        public Administrator(int id, string login, string password, string role)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.role = role;
        }
    }
}