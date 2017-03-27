using Microsoft.VisualStudio.TestTools.UnitTesting;
using myBMethodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBMethodes.Tests
{
    [TestClass()]
    public class randommizerTests
    {
        [TestMethod()]
        public void getPositiveIntergerTest()
        {

        }

        [TestMethod()]
        public void getIntergerTest()
        {
            Console.WriteLine(randommizer.getInterger());
        }

        [TestMethod()]
        public void dobbelTest()
        {
            Console.WriteLine(randommizer.dobbel());
        }

        [TestMethod()]
        public void namesTest()
        { 
            Console.WriteLine(randommizer.names());
        }
    }
}