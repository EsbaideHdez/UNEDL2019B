using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class MasArrays
    {
        public void Sorted()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "Valor 1");
            sl.Add(2, "Valor 2");
            sl.Add(3, "Valor 3");
            ICollection llaves = sl.Keys;
            foreach(var k in llaves)
            {
                Console.WriteLine("llaves:" + k + "valor " + sl[k]);
            }
        }
    }
}
