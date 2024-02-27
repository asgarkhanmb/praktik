
using TaskClass.Service;

namespace TaskClass.Controllers
{
    class UserController
    {
        private readonly UserService employeeService;
        public UserController()
        {
            employeeService = new UserService();
        }

        public void GetAll()
        {

            var result = UserService.GetAll();
        }
        public void GetById()
        {
            var user = UserService.
            var result = UserService.GetById();

            
           
        }
    }
}
