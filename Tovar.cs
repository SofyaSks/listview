using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listview
{
    public class Tovar
    {
        public string name_tovar;
        public int price;
        public int count;

        public Tovar(string n, int p, int c)
        {
            name_tovar = n;
            price = p;
            count = c;
        }
    }
}
