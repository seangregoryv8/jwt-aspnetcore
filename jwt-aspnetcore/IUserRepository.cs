using JWTASPNetCore.Models;
using System.Collections.Generic;

namespace JWTASPNetCore
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserModel userModel);
        List<UserDTO> GetUsersByRole(string role);
    }
}