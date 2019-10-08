using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAndBinaryTree
{
    class ListItem
    {
        public int value;
        public ListItem before;
        public ListItem after;

        public ListItem(int value, ListItem before, ListItem after)
        {
            this.value = value;
            this.before = before;
            this.after = after;
        }
    }
    class LinkedList
    {
        int length;
        ListItem first;
        ListItem last;

        public LinkedList()
        {
            length = 0;
        }

        /// <summary>
        ///Add num to the front of the list
        /// </summary>
        /// <param name="num"></param>
        public void PushFront(int num)
        {
            if (length == 0)
            {
                first = new ListItem(num,null,null);
                last = first;
                length++;
            }
            else
            {
                ListItem elem = new ListItem(num,null,first);
                first.before = elem;
                first = elem;
                length++;
            }
        }

        /// <summary>
        /// Add num to the back of the list
        /// </summary>
        /// <param name="num"></param>
        public void PushBack(int num)
        {
            if (length==0)
            {
                last = new ListItem(num,null,null);
                first = last;
                length++;
            }
            else
            {
                ListItem elem = new ListItem(num,last,null);
                last.after = elem;
                last = elem;
                length++;
            }
        }

        /// <summary>
        /// Deletes the first item in the list
        /// </summary>
        public void PopFront()
        {
            if (length > 1)
            {
                first = first.after;
                first.before = null;
                length--;
            }
            else if (length == 1)
            {
                first = null;
                last = null;
                length--;
            }
        }

        /// <summary>
        /// Deletes the last item in the list
        /// </summary>
        public void PopBack()
        {
            if (length > 1)
            {
                last = last.before;
                last.after = null;
                length--;
            }
            else if (length == 1)
            {
                first = null;
                last = null;
                length--;
            }
        }

        /// <summary>
        /// Prints out the items that are in the list (in order)
        /// </summary>
        public void Print()
        {
            ListItem index = first;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(index.value);
                index = index.after;
            }
        }
    }
}