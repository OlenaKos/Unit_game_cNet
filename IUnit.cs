using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitClass
{
    interface IUnit
    {
        void Attack(Unit unit);
        void Talk();
        void Trade();
    }
}
