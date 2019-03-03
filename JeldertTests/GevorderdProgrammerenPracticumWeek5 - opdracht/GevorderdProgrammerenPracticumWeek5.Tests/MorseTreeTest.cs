using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5.Tests
{
    [TestClass]
    public class MorseTreeTest
    {
        #region buildtree
        private MorseTree BuildMorseTree()
        {
            MorseTree tree = new MorseTree();
            tree.AddCharacter('a', ".-").AddCharacter('b', "-...").AddCharacter('c', "-.-.").AddCharacter('d', "-..")
                .AddCharacter('e', ".").AddCharacter('f', "..-.").AddCharacter('g', "--.").AddCharacter('h', "....")
                .AddCharacter('i', "..").AddCharacter('j', ".---").AddCharacter('k', "-.-").AddCharacter('l', ".-..")
                .AddCharacter('m', "--").AddCharacter('n', "-.").AddCharacter('o', "---").AddCharacter('p', ".--.")
                .AddCharacter('q', "--.-").AddCharacter('r', ".-.").AddCharacter('s', "...").AddCharacter('t', "-")
                .AddCharacter('u', "..-").AddCharacter('v', "...-").AddCharacter('w', ".--").AddCharacter('x', "-..-")
                .AddCharacter('y', "-.--").AddCharacter('z', "--..");
            return tree;
        }
        #endregion

        [TestMethod]
        public void Opdracht3a_TestGiveCharacterByMorseCode1()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            char result = tree.GiveCharacterByMorseCode("...-");
            //Assert
            Assert.AreEqual('v', result);
        }

        [TestMethod]
        public void Opdracht3a_TestGiveCharacterByMorseCode2()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            char result = tree.GiveCharacterByMorseCode("-.-.");
            //Assert
            Assert.AreEqual('c', result);
        }

        [TestMethod]
        public void Opdracht3a_TestGiveCharacterByMorseCode3()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            char result = tree.GiveCharacterByMorseCode("-..--");
            //Assert
            Assert.AreEqual('?', result);
        }

        [TestMethod]
        public void Opdracht3a_TestGiveMorsecodeA()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            string result = tree.GiveMorsecode('a');
            //Assert
            Assert.AreEqual(".-", result);
        }

        [TestMethod]
        public void Opdracht3a_TestGiveMorsecodeB()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            string result = tree.GiveMorsecode('B');
            //Assert
            Assert.AreEqual("-...", result);
        }

        [TestMethod]
        public void Opdracht3a_TestGiveMorsecodeF()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            string result = tree.GiveMorsecode('f');
            //Assert
            Assert.AreEqual("..-.", result);
        }

        [TestMethod]
        public void Opdracht3a_TestGiveMorsecode4()
        {
            //Arrange
            MorseTree tree = BuildMorseTree();
            //Act
            string result = tree.GiveMorsecode('4');
            //Assert
            Assert.AreEqual("", result);
        }
    }
}
