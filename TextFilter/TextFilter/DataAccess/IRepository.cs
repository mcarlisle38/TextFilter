using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilter.DataAccess
{
    internal interface IRepository
    {
        public string Read();

        public bool Update(string name);
    }
}
