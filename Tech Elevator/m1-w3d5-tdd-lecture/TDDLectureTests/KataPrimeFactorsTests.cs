using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLecture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLecture.Tests
{

    //1 is always omitted from the result set.
    //2 -> returns[2]
    //3 -> returns[3]
    //4 -> returns[2, 2]
    //6 -> returns[2, 3]
    //7 -> returns[7]
    //8 -> returns[2, 2, 2]
    //9 -> returns[3, 3]
    //10 -> returns[2, 5]
    //24 -> returns [2, 2, 2, 3]

    [TestClass()]
    public class KataPrimeFactorsTests
    {
        [TestMethod]

        public void FactorizeTest()
        {
            KataPrimeFactors testObjectOne = new KataPrimeFactors();
            CollectionAssert.AreEquivalent(new int[] {2}, testObjectOne.Factorize(2));
        }
    }
}