
namespace TaskClass
{
     class User
    {
        public int id;
        public string fullname;
        public string email;
        public int password;
        public int age;

        public static implicit operator int(User v)
        {
            throw new NotImplementedException();
        }
    }
}
