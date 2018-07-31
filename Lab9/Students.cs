using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Students
    {
        private string name;
        private string hobbie;
        private string origin;
        private string birthday;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Hobbie
        {
            set { hobbie = value; }
            get { return hobbie; }
        }
        public string Origin
        {
            set { origin = value; }
            get { return origin; }
        }
        public string Birthday
        {
            set { birthday = value; }
            get { return birthday; }
        }

    }
}
