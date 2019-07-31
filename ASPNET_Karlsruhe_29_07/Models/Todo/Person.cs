using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Karlsruhe_29_07.Models.Todo
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }
}
