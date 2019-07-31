using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Karlsruhe_29_07.Models.Todo
{
    public class Todo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public Person Owner { get; set; }
    }
}
