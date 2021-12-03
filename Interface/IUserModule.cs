using Sprint2Project.Models;
using System.Collections.Generic;

namespace Sprint2Project.Interface
{
    public interface IUserModule
    {

        List<UserModule> GetAllUsers();
        UserModule GetUserById(int id);
        UserModule AddUser(UserModule user);
        UserModule UpdateUser(int id, UserModule user);
        void DeleteUser(int id);


    }
}
