using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek4.Tests
{
    [TestClass]
    public class RecursionTest
    {
        [TestMethod]
        public void Example_Fibonacci10Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            int result = recursion.Fib(10);
            //Assert
            Assert.AreEqual(55, result);
        }
                
        [TestMethod]
        public void Example_Fibonacci29Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            int result = recursion.Fib(29);
            //Assert
            Assert.AreEqual(514229, result);
        }

        [TestMethod]
        public void Opdracht02_Row10Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            double result = recursion.Row(10);
            //Assert
            Assert.AreEqual(1.9990234375, result, 0.0000000001);
        }

        [TestMethod]
        public void Opdracht02_Row20Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            double result = recursion.Row(20);
            //Assert
            Assert.AreEqual(1.9999990463, result, 0.0000000001);
        }
        
        [TestMethod]
        public void Opdracht03_SimplePow3to5Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            long result = recursion.SimplePow(3, 5);
            //Assert
            Assert.AreEqual(243, result);
        }

        [TestMethod]
        public void Opdracht03_SimplePow5to15Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            long result = recursion.SimplePow(5, 15);
            //Assert
            Assert.AreEqual(30517578125, result);
        }

        [TestMethod]
        public void Opdracht04_FastPow3to5Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            long result = recursion.FastPow(3, 5);
            //Assert
            Assert.AreEqual(243, result);
        }

        [TestMethod]
        public void Opdracht04_FastPow5to15Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            long result = recursion.FastPow(5, 15);
            //Assert
            Assert.AreEqual(30517578125, result);
        }

        [TestMethod]
        public void Opdracht05_LepelIsPalindroomTest()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            bool result = recursion.IsPalindroom("lepel");
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Opdracht05_ParterretrapIsPalindroomTest()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            bool result = recursion.IsPalindroom("parterretrap");
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Opdracht05_RaceautoIsPalindroomTest()
        {
            //Arrange
            Recursion recursion = new Recursion();
            //Act
            bool result = recursion.IsPalindroom("raceauto");
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Opdracht06_Sum1234Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list = new List<int> { 1, 2, 3, 4 };
            //Act
            int result = recursion.Sum(list);
            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Opdracht06_Sum24681020Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list = new List<int> { 2, 4, 6, 8, 10, 20 };
            //Act
            int result = recursion.Sum(list);
            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Opdracht07_IsSortedTest()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list = new List<int>();
            //Act
            bool result = recursion.IsSorted(list);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Opdracht07_IsSorted1379Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list = new List<int> { 1, 3, 7, 9 };
            //Act
            bool result = recursion.IsSorted(list);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Opdracht07_IsSorted13minus79Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list = new List<int> { 1, 3, -7, 9 };
            //Act
            bool result = recursion.IsSorted(list);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Opdracht08_Merge13791379Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list_a = new List<int> { 1, 3, 7, 9 };
            List<int> list_b = new List<int> { 1, 3, 7, 9 };
            List<int> expectedResult = new List<int> { 1, 1, 3, 3, 7, 7, 9, 9 };
            //Act
            List<int> result = recursion.Merge(list_a, list_b);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Opdracht08_Merge102030100Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list_a = new List<int> { 10, 20, 30 };
            List<int> list_b = new List<int> { 100 };
            List<int> expectedResult = new List<int> { 10, 20, 30, 100 };
            //Act
            List<int> result = recursion.Merge(list_a, list_b);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Opdracht08_Merge1020304025Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> list_a = new List<int> { 10, 20, 30, 40 };
            List<int> list_b = new List<int> { 25 };
            List<int> expectedResult = new List<int> { 10, 20, 25, 30, 40 };
            //Act
            List<int> result = recursion.Merge(list_a, list_b);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Opdracht09_MergeSortTest()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> input = new List<int> { };
            List<int> expectedResult = new List<int> { };
            //Act
            List<int> result = recursion.MergeSort(input);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Opdracht09_MergeSort51829342Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            List<int> input = new List<int> { 5, 1, 8, 2, 9, 3, 4, 2 };
            List<int> expectedResult = new List<int> { 1, 2, 2, 3, 4, 5, 8, 9 };
            //Act
            List<int> result = recursion.MergeSort(input);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Opdracht10_MyListGetLast25Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            MyList<int> list = new MyList<int>(25);
            //Act
            int result = list.GetLast();
            //Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void Opdracht10_MyListGetLast2547135Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            MyList<int> list = new MyList<int>(25);
            list.Add(47);
            list.Add(13);
            list.Add(5);
            //Act
            int result = list.GetLast();
            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Opdracht11_MyListCountAapNootMiesTest()
        {
            //Arrange
            Recursion recursion = new Recursion();
            MyList<string> list = new MyList<string>("aap");
            list.Add("noot");
            list.Add("mies");
            list.Add("geen idee wat daarna komt");
            //Act
            int result = list.Count();
            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Opdracht12_MyListReverse2547135Test()
        {
            //Arrange
            Recursion recursion = new Recursion();
            MyList<int> list = new MyList<int>(25);
            list.Add(47);
            list.Add(13);
            list.Add(5);
            //Act
            int result = list.Reverse().GetLast();
            //Assert
            Assert.AreEqual(25, result);
        }
    }
}
