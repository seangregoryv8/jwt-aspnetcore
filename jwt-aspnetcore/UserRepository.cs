using JWTASPNetCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace JWTASPNetCore
{
    public enum Roles
    {
        Manager,
        Developer,
        Tester,
        Admin,
        Supervisor,
        Clerk,
        Guest
    }

    public class UserRepository : IUserRepository
    {
        private readonly List<UserDTO> users = new();
        public UserRepository()
        {
            users.Add(new UserDTO { UserName = "joydipkanjilal",  Password = "joydip123",        Role = Roles.Manager.ToString()    });
            users.Add(new UserDTO { UserName = "michaelsanders",  Password = "michael321",       Role = Roles.Developer.ToString()  });
            users.Add(new UserDTO { UserName = "stephensmith",    Password = "stephen123",       Role = Roles.Tester.ToString()     });
            users.Add(new UserDTO { UserName = "adminGael",       Password = "brokenSword1445",  Role = Roles.Admin.ToString()      });
            users.Add(new UserDTO { UserName = "supervisorMidir", Password = "dragonRulz102!",   Role = Roles.Supervisor.ToString() });
            users.Add(new UserDTO { UserName = "clerkLothric",    Password = "ifYouWill44?",     Role = Roles.Clerk.ToString()      });
            users.Add(new UserDTO { UserName = "clerkGwyn",       Password = "plinplinplon33!",  Role = Roles.Clerk.ToString()      });
            users.Add(new UserDTO { UserName = "clerkVordt",      Password = "memeMusic344321!", Role = Roles.Clerk.ToString()      });
            users.Add(new UserDTO { UserName = "clerkAldrich",    Password = "yummyWummy33?",    Role = Roles.Clerk.ToString()      });
            users.Add(new UserDTO { UserName = "guestGundyr",     Password = "longSpearBoi344!", Role = Roles.Guest.ToString()      });
        }
        public UserDTO GetUser(UserModel userModel) => users.Where(x => x.UserName.ToLower() == userModel.UserName.ToLower() && x.Password == userModel.Password).FirstOrDefault();

        public List<UserDTO> GetUsersByRole(string role) => users.Where(x => x.Role.ToLower() == role.ToLower()).ToList();
    }
}