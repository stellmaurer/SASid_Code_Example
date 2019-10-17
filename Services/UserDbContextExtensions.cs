using System.Collections.Generic;
using System.Linq;
using UsersAPI.Entities;

namespace UsersAPI.Services
{
     public static class UsersDbContextExtensions
     {
          public static void CreateSeedData(this UsersDbContext context)
          {
               if (context.Users.Any())
               {
                    return;
               }
               var users = new List<User>()
               {
                    new User
                    {
                         FirstName = "Yods",
                         LastName = null,
                         Gender = "Male",
                         DOB = "06/03/1993",
                    },
                    new User
                    {
                         FirstName = "Jess",
                         LastName = null,
                         Gender = "Female",
                         DOB = "10/17/1945",
                    },
                    new User
                    {
                         FirstName = "Tess",
                         LastName = "Gardil",
                         Gender = "Non-Binary",
                         DOB = "10/18/2016",
                    },
                    new User()
                    {
                         FirstName = "Emilio",
                         LastName = "Hartig",
                         Gender = "Male",
                         DOB = "10/19/2019",
                    },
                    new User()
                    {
                         FirstName = "Aaron",
                         LastName = "Bernados",
                         Gender = "Male",
                         DOB = "01/01/2018",
                    },
                    new User()
                    {
                         FirstName = "Gerri",
                         LastName = "Philo",
                         Gender = "Female",
                         DOB = "12/01/1999",
                    },
               };
               context.AddRange(users);
               context.SaveChanges();
          }
     }
}