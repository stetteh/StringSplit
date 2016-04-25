using System;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSplit
{
    [TestClass]
    public class UnitTest1
    {
        public string FirstName(string name)
        {
            var words = name.Split(' ').ToList();
            if (words.Count > 2)
            {
                var result = "";
                for (int i = 0; i < words.Count - 1; i++)
                {
                    result += words[i] + " ";
                }

                return result.Trim();
            }

            return words.First(); 
        }

        public string LastName(string name)
        {
            var words = name.Split(' ').ToList();
            return words.Last();

        }


        [TestMethod]
        public void TestFirstName()
        {
            Assert.AreEqual("Daniel", FirstName("Daniel Pollock"));
        }


        [TestMethod]
        public void TestLastName()
        {
            Assert.AreEqual("Pollock", LastName("Daniel Pollock"));
        }

    

        [TestMethod]
        public void TestOneWordName()
        {
            Assert.AreEqual("Moby", FirstName("Moby"));
            Assert.AreEqual("Moby", LastName("Moby"));
        }

        [TestMethod]
        public void TestThreeWordName()
        {
            Assert.AreEqual("John Quincy", FirstName("John Quincy Adams"));
            Assert.AreEqual("Adams", LastName("John Quincy Adams"));
        }

        [TestMethod]
        public void TestNoWordName()
        {
            Assert.AreEqual("", FirstName(""));
            Assert.AreEqual("", LastName(""));
        }
    }

}
