using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ListByArray list = new ListByArray(10);
            list.Append(12);
            list.PrintList();
            list.Append(13);
            list.PrintList();
            list.Append(115);
            list.PrintList();
            list.Append(121);
            list.PrintList();
            list.Append(131);
            list.PrintList();
            list.Append(115);
            list.PrintList();
            list.Append(122);
            list.PrintList();
            list.Append(132);
            list.PrintList();
            list.Append(115);
            list.PrintList();
            list.Insert(113, 0);
            list.PrintList();
            list.RemoveAll(115);
            list.PrintList();
            list.Clear();
            list.PrintList();


        }
    }
}
