using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5.Tests
{
    [TestClass]
    public class IntTreeTest
    {
        #region build trees
        private IntTree BuildTree1to10()
        {
            IntTree tree = new IntTree(5);
            tree.Add(6);
            tree.Add(9);
            tree.Add(1);
            tree.Add(3);
            tree.Add(4);
            tree.Add(8);
            tree.Add(2);
            tree.Add(10);
            tree.Add(5);
            tree.Add(7);
            return tree;
        }

        private IntTree BuildTreeminus50to50()
        {
            IntTree tree = new IntTree(0);
            tree.Add(-30);
            tree.Add(40);
            tree.Add(-40);
            tree.Add(10);
            tree.Add(40);
            tree.Add(-50);
            tree.Add(-10);
            tree.Add(20);
            tree.Add(50);
            tree.Add(-20);
            tree.Add(30);
            return tree;
        }
        #endregion

        [TestMethod]
        public void Opdracht2a_TestMin1()
        {
            //Arrange
            IntTree tree = BuildTree1to10();
            //Act
            int result = tree.Min();
            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Opdracht2a_TestMin2()
        {
            //Arrange
            IntTree tree = BuildTreeminus50to50();
            //Act
            int result = tree.Min();
            //Assert
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Opdracht2b_TestMax1()
        {
            //Arrange
            IntTree tree = BuildTree1to10();
            //Act
            int result = tree.Max();
            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Opdracht2b_TestMax2()
        {
            //Arrange
            IntTree tree = BuildTreeminus50to50();
            //Act
            int result = tree.Max();
            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Opdracht2c_TestCount1()
        {
            //Arrange
            IntTree tree = BuildTree1to10();
            //Act
            int result = tree.Count();
            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Opdracht2c_TestCount2()
        {
            //Arrange
            IntTree tree = BuildTreeminus50to50();
            //Act
            int result = tree.Count();
            //Assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void Opdracht2d_TestInOrder1()
        {
            //Arrange
            IntTree tree = BuildTree1to10();
            //Act
            string result = tree.InOrder();
            //Assert
            Assert.AreEqual("1 2 3 4 5 6 7 8 9 10", result);
        }

        [TestMethod]
        public void Opdracht2d_TestInOrder2()
        {
            //Arrange
            IntTree tree = BuildTreeminus50to50();
            //Act
            string result = tree.InOrder();
            //Assert
            Assert.AreEqual("-50 -40 -30 -20 -10 0 10 20 30 40 50", result);
        }
    }
}
