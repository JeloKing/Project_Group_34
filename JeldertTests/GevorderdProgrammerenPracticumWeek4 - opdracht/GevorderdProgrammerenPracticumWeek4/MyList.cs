using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek4
{
    public class MyList<T>
    {
        private T item;
        private MyList<T> next;

        public MyList(T item)
        {
            this.item = item;
        }

        public T GetItem(int index)
        {
            if (index == 0)
                return item;
            else
                return next.GetItem(index - 1);
        }

        public void Add(T item)
        {
            if (next == null)
                next = new MyList<T>(item);
            else
                next.Add(item);
        }

        public T GetLast()
        {
            if (next == null)
                return item;

            return next.GetLast();

            throw new NotImplementedException();
        }

        static int elementen = 0;
        public int Count()
        {
            elementen++;
            if (next == null)
            {
                return elementen;
            }
            else
                return next.Count();
            throw new NotImplementedException();
        }

        public MyList<T> Reverse()
        {
            MyList<T> reversed;
            if (next != null)
            {
                reversed = next.Reverse();
                reversed.Add(item);
                return reversed;

            }
            else
            {
                reversed = new MyList<T>(item);
                return reversed;
            } 
            throw new NotImplementedException();
        }
    }
}