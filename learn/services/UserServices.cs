using learn.models;
using learn.services.interfaces;

namespace learn.services
{
    public class UserServices : IUserServices
    {
        static List<User> users =
        [
            new()
            {
                Id = 1,
                firstName = "oday",
                lastName = "ziq",
                Email = "odaylouy3@gmail.com",
                //DateOfBirth = new DateTime(2002, 6, 13)
            },
            new()
            {
                Id = 2,
                firstName = "mahomud",
                lastName = "ash",
                Email = "mahmoudash@gmail.com",
                //DateOfBirth = new DateTime(2002,4,20)
            },
            new()
            {
                Id = 3,
                firstName = "omar",
                lastName = "dar",
                Email = "omardar@gmail.com",
                //DateOfBirth = new DateTime(2002,4,12)
            }
        ];

        public User? GetByid(int id)
        {
            return users.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<User> GetAll()
        {
            return users.ToList();
        }
        public void AddNewUser(User user)
        {
            users.Add(user);
        }
        public void UpdateUser(int id, User UpdatedUser)
        {
            var user = GetByid(id);
            if (user == null)
            {
                throw new Exception("user not found");
            }
            users.Remove(user);
            users.Add(UpdatedUser);

        }

        public void DeleteUser(int id)
        {
            var user = GetByid(id);
            if (user == null)
            {
                throw new Exception("user not included");
            }
            users.Remove(user);
        }
    }
}
