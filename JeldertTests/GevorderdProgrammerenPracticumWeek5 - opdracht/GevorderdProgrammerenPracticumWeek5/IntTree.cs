using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class IntTree
    {
        #region Code uit les
        private int item;
        private IntTree left = null;
        private IntTree right = null;

        public IntTree(int item)
        {
            this.item = item;
        }

        public void Add(int item)
        {
            if (item != this.item)
            {
                if (item < this.item)
                    if (left == null)
                        left = new IntTree(item);
                    else
                        left.Add(item);
                else
                    if (right == null)
                    right = new IntTree(item);
                else
                    right.Add(item);
            }
        }

        public bool Search(int item)
        {
            if (item == this.item)
                return true;
            if (item < this.item)
                if (left == null)
                    return false;
                else
                    return left.Search(item);
            else
                if (right == null)
                return false;
            else
                return right.Search(item);
        }
        #endregion

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public string InOrder()
        {
            throw new NotImplementedException();
        }
    }
}
