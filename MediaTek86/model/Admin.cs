
namespace MediaTek86.model
{
    public class Admin
    {
        public string Login { get; }

        public string Pwd { get; }

        public Admin(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
