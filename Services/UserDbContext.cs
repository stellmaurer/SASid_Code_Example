using Microsoft.EntityFrameworkCore;
using UsersAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace UsersAPI.Services
{
     public class UsersDbContext : DbContext
     {
          public DbSet<User> Users { get; set; }
          public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
          {
               Database.EnsureCreated();
          }
     }
}