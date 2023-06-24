using ShoplateAPP.Models;

namespace ShoplateAPP.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetUser(string username);

        User GetUserByID(int id);
        void ChangePassword(string password, string newPassword1, string newPassword2, string username);


        void AccountDataChange(string name, string surname, string email, string phone, string password, string currentUsername);


        void AddUser(int id, string name, string surname, string phone, string email, string password, string isAdmin, string username);

    }
}
