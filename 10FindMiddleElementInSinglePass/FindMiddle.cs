using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10FindMiddleElementInSinglePass
{
    class FindMiddle
    {
        LinkedList<object> list = new LinkedList<object>();
        public FindMiddle(string[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                list.AddLast(Convert.ToInt32(p[i]));
            }
        }

       public string getMiddle()
        {
           LinkedListNode<object> current = list.First;
           LinkedListNode<object> everyother = list.First;
           //have every other go twice as fast as current
           everyother = everyother.Next;
           int count = 0;
           while (everyother != null)
           {
               count++;
               current = current.Next;
               everyother = everyother.Next;
               if (everyother != null)
               {
                   everyother = everyother.Next;
               }
               }
           return current.Value.ToString();
        }
     }
}
