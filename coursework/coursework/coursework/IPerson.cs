using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    internal interface IPerson
    {
        int id { get; set; }
        string name { get; set; }
        string surname { get; set; }
        string email { get; set; }
        string password { get; set; }
        int age { get; set; }
        
    }
}
