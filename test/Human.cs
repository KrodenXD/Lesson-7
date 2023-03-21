using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Human
    {
        public int MyProperty { get; set; }

        public int HumanMonth(int age)
        {
            const int month = 12;
            return age * month;
        }

        readonly int day = 365;

        public int HumanDay(int age)
        {
            return age * day;
        }
    }
}
