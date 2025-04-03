using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private class StackItem
        {
            public string CurrentItem { get; set; }
            public StackItem? NextItem { get; set; }

            public StackItem(string currentItem) 
            {
                CurrentItem = currentItem;
            }

            public StackItem(string currentItem, StackItem? next)
            {
                CurrentItem = currentItem;
                NextItem = next;
            }
        }

        private StackItem? head;
        private int count;

        public Stack(params string[] stackElements)
        {
            foreach(string stackElement in stackElements)
            {
                Add(stackElement);
            }
        }

        public void Add(string stackElem)
        {
            StackItem newItem = new StackItem(stackElem, head);
            head = newItem;
            count++;
        }

        public string Pop()
        {
            if (head == null)
                throw new Exception("Стек пустой");

            string currentItem = head.CurrentItem;
            head = head.NextItem;
            count--;
            return currentItem;
        }

        public static Stack Concat(params Stack[] stacks)
        {
            Stack result = new Stack();
            foreach (var stack in stacks)
            {
                result.Merge(stack);
            }
            return result;
        }

        public int Size
        {
            get { return count; }
        }

        public string? Top
        {
            get
            {
                return head?.CurrentItem;
            }  
        }
    }
}
