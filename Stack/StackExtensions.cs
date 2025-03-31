using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal static class StackExtensions
    {
        public static void Merge(this Stack stack1, Stack stack2)
        {
            while (stack2.Size > 0)
            {
                stack1.Add(stack2.Pop());
            }
        }
    }
}
