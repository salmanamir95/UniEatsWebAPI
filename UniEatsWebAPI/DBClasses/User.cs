using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniEatsWebAPI.DBClasses
{
    public class User
    {
        public string Name { get; set; } = string.Empty;

        public UInt16 id { get; set; }

        public UInt16 age { get; set; }

        public char designation { get; set; }

    }
}