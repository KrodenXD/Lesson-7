using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
    class Milk
    {
        public int MakeSmetan(int count)
        {
            const int cost = 580;
            return count * cost;
        }

        readonly int cost = 760;
        public int MakeMatzun(int count)
        {
            return count * cost;
        }

        public int MakeTvarog(int count)
        {
            const int cost = 650;
            return count * cost;
        }
    }
}
