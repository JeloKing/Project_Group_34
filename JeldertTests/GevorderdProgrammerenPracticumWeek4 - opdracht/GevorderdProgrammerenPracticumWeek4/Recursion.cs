using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek4
{
    public class Recursion
    {
        /// <summary>
        /// Berekent fibonacci getallen zoals besproken in de les
        /// Fibonacci: 0 1 1 2 3 5 8 13 21 34
        /// </summary>
        /// <param name="n">het hoeveelste fibonacci getal berekent moet worden</param>
        /// <returns>getal n uit de fibonaccie reeks</returns>
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        /// <summary>
        /// calculates the sum of 1/1 + 1/2 + 1/4 + 1/8 + 1/16 + ... + 1/(2^n)
        /// </summary>
        /// <param name="n">defines when the calculation has to stop</param>
        /// <returns>the calculated value</returns>
        public double Row(int n, double getal = 1)
        {

            if (n == 0)
                return getal;
            return getal + Row(n - 1, getal / 2);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates power in a simple way
        /// </summary>
        /// <param name="b">base (grondtal)</param>
        /// <param name="e">exponent (macht)</param>
        /// <returns>result of base^exponent</returns>
        public long SimplePow(int b, int e)
        {
            if (e == 0)
                return 1;
            //if (e % 2 == 0)
            //{
            //    i = SimplePow(b, e / 2);
            //    return i * i;
            //}
            return b * SimplePow(b, e - 1);

            throw new NotImplementedException();
        }



        /// <summary>
        /// Calculates power in a fast way
        /// </summary>
        /// <param name="b">base (grondtal)</param>
        /// <param name="e">exponent (macht)</param>
        /// <returns>result of base^exponent</returns>
        public long FastPow(int b, int e)
        {
            long getal;
            if (e == 0)
            {
                return 1;
            }
            if (e % 2 == 0)
            {
                getal = FastPow(b, e / 2);
                return getal * getal;
            }

            return b * FastPow(b, e - 1);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Detects if given string s is a palindrome
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true if s is a palindrome, false otherwise</returns>
        public bool IsPalindroom(string s)
        {

            if (s.Length <= 1)
            {
                return true;
            }

            char a = s.First();
            char b = s.Last();

            if (s.Length > 1)
            {
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
            }
            return IsPalindroom(s.Substring(1, s.Length - 2));
            //int min = 0;
            //int max = s.Length - 1;
            //while (true)
            //{
            //    if (min > max)
            //    {
            //        return true;
            //    }
            //    char a = s[min];
            //    char b = s[max];
            //    if (char.ToLower(a) != char.ToLower(b))
            //    {
            //        return false;
            //    }
            //    min++;
            //    max--;
            //}

            throw new NotImplementedException();
        }

        /// <summary>
        /// calculates the sum of elements of a list filled with integers
        /// </summary>
        /// <param name="list">the input list</param>
        /// <returns>the sum of elements</returns>
        public int Sum(List<int> list)
        {
            int Result = 0;
            if (list.Count <= 0)
            {
                return Result;
            }
            else
            {
                Result = Result + list.First();
                list.RemoveAt(0);
                return Result + Sum(list);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if a list of integers is sorted ascending
        /// </summary>
        /// <param name="list">list of integers</param>
        /// <returns>true if the list is sorted ascending</returns>
        public bool IsSorted(List<int> list)
        {
            if (true)
            {
                int counter = 1;
                int count = list.Count;
                if (counter >= count)
                {
                    return true;
                }
                int a = list[0];
                int b = list[1];
                if (a > b)
                {
                    return false;
                }

                list.RemoveAt(0);
                return IsSorted(list);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// merges two sorted lists into one sorted list
        /// </summary>
        /// <param name="a">sorted list</param>
        /// <param name="b">sorted list</param>
        /// <returns>sorted list</returns>
        public List<int> Merge(List<int> a, List<int> b)
        {
            List<int> c = new List<int>();
            int amountA = a.Count;
            int amountB = b.Count;
            if (amountA <= 0)
            {
                return b;
            }
            if (amountB <= 0)
            {
                return a;
            }
            if (a[0] < b[0])
            {
                c.Add(a[0]);
                a.Remove(a.First());
            }
            else if (a[0] == b[0])
            {
                c.Add(a[0]);
                c.Add(b[0]);
                a.Remove(a.First());
                b.Remove(b.First());
            }
            else if (a[0] > b[0])
            {
                c.Add(b[0]);
                b.Remove(b.First());
            }
            c.AddRange(Merge(a, b));
            return c;


            //fail
            //int first = a.First();
            //int second = b.First();
            //List<int> c = new List<int>();
            //int amountA = a.Count;
            //int amountB = b.Count;

            //if (amountA >= 0)
            //{
            //    if (a[0] < b[0])
            //    {
            //        {
            //            c.Add(a[0]);
            //            a.Remove(first);
            //        }
            //    }
            //}
            //else
            //    return b;
            //if (amountB >= 0)
            //{
            //    if (a[0] > b[0])
            //    {
            //        {
            //            c.Add(b[0]);
            //            a.Remove(second);
            //        }
            //    }
            //}
            //else
            //    return a;
            //c.AddRange(Merge(a, b));

            //return c;

            //fail
            //int total = 0;
            //total = a.Count + b.Count;    
            //if (IsSorted(a) && IsSorted(b))
            //{
            //if (total <= 0)
            //{
            //    return Merge(a,b);
            //}
            //else
            //{
            //    if (first < second)
            //    {
            //        c.Add(a[0]);
            //        a.Remove(first);
            //    }

            //    if (second < first)
            //    {
            //        c.Add(b[0]);
            //        b.Remove(first);
            //    }
            //}
            //while (c.Count() <= 0)
            //{
            //    a.Add(c[0]);
            //    b.Add(c[0]);
            //    c.Remove(first);
            //}

            //return Merge(a, b);
            //}
            //else
            //{

            //}

            throw new NotImplementedException();

        }

        /// <summary>
        /// Sorts a list of integers by using merge
        /// </summary>
        /// <param name="list">unsorted list</param>
        /// <returns>sorted list</returns>
        public List<int> MergeSort(List<int> list)
        {
            //int j = 0;
            //if (list.Count >= j)
            //{
            //    return list;
            //}
            if (list.Count > 1)
            {
                List<int> left = new List<int>();
                List<int> right = new List<int>();

                for (int i = 0; i < list.Count; i++)
                {
                    if (i % 2 > 0)
                    {
                        left.Add(list[i]);
                    }
                    else
                    {
                        right.Add(list[i]);
                    }
                }
                return Merge(MergeSort(left), MergeSort(right));
            }
            else
            {
                return list;
            }
            
            throw new NotImplementedException();
        }

//        public List<int> Merging(List<int> left, List<int> right)
//        {
//            List<int> merged = new List<int>();

//            while (left.Count > 0 && right.Count > 0)
//            {
//                if (left.First() <= right.First())
//                {
//                    merged.Add(left.First());
//                    left.RemoveAt(0);
//                }
//                else
//                {
//                    merged.Add(right.First());
//                    right.RemoveAt(0);
//                }
//            }
//            return merged;

//        }

    }
}

