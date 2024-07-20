using learn.models;
using learn.services;
using learn.services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace learn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _userServices.GetAll();
        }
        [HttpGet("{id:int}")]
        public User? GetUser(int id)
        {
            return _userServices.GetByid(id);
        }
        [HttpPost]
        public void addnNewUser([FromBody] User user)
        {
            _userServices.AddNewUser(user);
        }
        [HttpPut("{id:int}")]
        public void UpdateUser(int id,[FromBody] User user)
        {
            _userServices.UpdateUser(id, user);
        }
        [HttpDelete("{id:int}")]
        public void DeleteUser(int id)
        {
            _userServices.DeleteUser(id);
        }




    }
}
