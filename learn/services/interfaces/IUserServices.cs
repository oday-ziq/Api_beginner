using learn.models;
namespace learn.services.interfaces
{
    public interface IUserServices
    {
        User? GetByid(int id);
        List<User> GetAll();
        void AddNewUser(User user);
        void DeleteUser(int id);
        void UpdateUser(int id,User UpdatedUser);


    }
}
