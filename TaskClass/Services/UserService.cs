
namespace TaskClass.Service
{
    class UserService
    {
        internal static object GetById()
        {
            throw new NotImplementedException();
        }

        public User[] GetAll()
        {
            User user1 = new()
            {
                id = 1,
                fullname = "Test Testov1",
                email = "testov1@gmail.com",
                password = 1234,
                age = 27
            };
            User user2 = new()
            {
                id = 2,
                fullname = "Test Testov2",
                email = "testov2@gmail.com",
                password = 12345,
                age = 22
            };
            User user3 = new()
            {
                id = 3,
                fullname = "Test Testov3",
                email = "testov3@gmail.com",
                password = 123454,
                age = 32
            };
            User user4 = new()
            {
                id = 4,
                fullname = "Test Testov4",
                email = "testov4@gmail.com",
                password = 12346,
                age = 29
            };

            User[] users = { user1, user2, user3, user4 };
            return users;


        }
        public User GetById(User[] users, User id)
        {
            return users.FirstOrDefault(m => m.id == id);
        }

    }
}
