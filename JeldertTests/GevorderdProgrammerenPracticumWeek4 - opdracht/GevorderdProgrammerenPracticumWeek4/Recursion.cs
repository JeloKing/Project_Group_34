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
        public double Row(int n)
        {
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Detects if given string s is a palindrome
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true if s is a palindrome, false otherwise</returns>
        public bool IsPalindroom(string s)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// calculates the sum of elements of a list filled with integers
        /// </summary>
        /// <param name="list">the input list</param>
        /// <returns>the sum of elements</returns>
        public int Sum(List<int> list)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if a list of integers is sorted ascending
        /// </summary>
        /// <param name="list">list of integers</param>
        /// <returns>true if the list is sorted ascending</returns>
        public bool IsSorted(List<int> list)
        {
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sorts a list of integers by using merge
        /// </summary>
        /// <param name="list">unsorted list</param>
        /// <returns>sorted list</returns>
        public List<int> MergeSort(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}
