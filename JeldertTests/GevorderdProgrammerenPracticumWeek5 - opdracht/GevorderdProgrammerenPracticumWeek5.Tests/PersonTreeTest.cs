using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5.Tests
{
    [TestClass]
    public class PersonTreeTest
    {
        [TestMethod]
        public void Opdracht4a_AddTest1()
        {
            //Arrange
            PersonTree tree = new PersonTree(new Person("Jos", 100));
            //Act
            tree.Add(new Person("Bruce"));
            string result = tree.GetMostEvilPerson();
            //Assert
            Assert.AreEqual("Jos", result);
        }

        [TestMethod]
        public void Opdracht4a_AddTest2()
        {
            //Arrange
            PersonTree tree = new PersonTree(new Person("Bruce"));
            //Act
            tree.Add(new Person("Jos", 100));
            string result = tree.GetMostEvilPerson();
            //Assert
            Assert.AreEqual("Jos", result);
        }

        [TestMethod]
        public void Opdracht4a_AddTest3()
        {
            //Arrange
            PersonTree tree = new PersonTree(new Person("Bruce"));
            //Act
            tree.Add(new Person("Jan", 0));
            string result = tree.GetMostEvilPerson();
            //Assert
            Assert.AreEqual("Bruce", result);
        }

        [TestMethod]
        public void Opdracht4b_GetAllNamesSorted()
        {
            //Arrange
            PersonTree tree = new PersonTree(new Person("Bruce"));
            tree.Add(new Person("Jan", 0));
            tree.Add(new Person("Jos", 100));
            tree.Add(new Person("Melinda", 90));
            tree.Add(new Person("Wouter", 10));
            //Act
            string result = tree.GetAllNamesSorted();
            //Assert
            Assert.AreEqual("Jan - Wouter - Bruce - Melinda - Jos", result);
        }
    }
}
