using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Assignment1.Models
{
    //Q8: class constraint example
    class Storage<T> where T : class
    {
        public T Data;
    }
}
