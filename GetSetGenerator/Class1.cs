using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetSetGenerator
{
    class Class1
    {
        private string Name;

        public string PropName
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}
