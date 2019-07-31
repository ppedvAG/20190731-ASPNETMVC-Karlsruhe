using ASPNET_Karlsruhe_29_07.Models.Todo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Karlsruhe_29_07.Data
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
