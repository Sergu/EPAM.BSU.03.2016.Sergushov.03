using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1Tests
{
    [TestClass]
    public class PolinomTests
    {
        [TestMethod]
        [ExpectedException (typeof(NullReferenceException))]
        public void Polinom_nullArrayInit_throwsException()
        {
            Polinom polinom = new Polinom(null);
        }
        [TestMethod]
        public void PolinomAdd()
        {
            Polinom expectedResult = new Polinom(15, -1, 111, 3699, 27, 23);
            Polinom polinom1 = new Polinom(3, 4, 123, 3464, 12);
            Polinom polinom2 = new Polinom(12, -5, -12, 235, 15, 23);
            Polinom result = polinom1 + polinom2;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PolinomSub()
        {
            Polinom expectedResult = new Polinom(3, 9, 1225, 3230, -3, 101, 12);
            Polinom polinom1 = new Polinom(15, 4, 1213, 3465, 12, 124, 12);
            Polinom polinom2 = new Polinom(12, -5, -12, 235, 15, 23);
            Polinom result = polinom1 - polinom2;
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void PolinomMul()
        {
            Polinom expectedResult = new Polinom(6, -20, -13, 170, 150);
            Polinom polinom1 = new Polinom(3, 4, 13, 34, 10);
            Polinom polinom2 = new Polinom(2, -5, -1, 5, 15, 23);
            Polinom result = polinom1 * polinom2;
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PolinomEquals_nullReference_returnsNotEquals()
        {
            Polinom polinom = new Polinom(4, 5);
            Assert.IsFalse(polinom.Equals(null));
        }
        [TestMethod]
        public void PolinomEquals_sameReferences_returnEquals()
        {
            Polinom polinom = new Polinom(4, 5, 7 , 9);
            Assert.IsFalse(polinom.Equals(null));
        }
        [TestMethod]
        public void PolinomEquals_sameObjects_returnEquals()
        {
            Polinom polinom1 = new Polinom(1,56,34,123,34);
            Polinom polinom2 = new Polinom(1,56,34,123,34);
            Assert.IsTrue(polinom1.Equals(polinom2));
        }
        [TestMethod]
        public void PolinomEquals_differentObjects_returnEquals()
        {
            Polinom polinom1 = new Polinom(1, 56, 34, 123, 34);
            Polinom polinom2 = new Polinom(1, 56, 34, 1232, 34,123,56,21);
            Assert.IsFalse(polinom1.Equals(polinom2));
        }
        [TestMethod]
        public void PolinomGetHashCode_compareHashCodesOfDifferentObjects__returnsNotEquals()
        {
            Polinom polinom1 = new Polinom(1, 56, 34, 123, 34);
            Polinom polinom2 = new Polinom(1, 56, 34, 1232, 34, 123, 56, 21);
            Assert.IsTrue(polinom1.GetHashCode() != polinom2.GetHashCode());
        }
        [TestMethod]
        public void PolinomGetHashCode_compareHashCodesOfsameObjects__returnsEquals()
        {
            Polinom polinom1 = new Polinom(1, 56, 34, 123, 341,42);
            Polinom polinom2 = new Polinom(1, 56, 34, 123, 341, 42);
            Assert.IsTrue(polinom1.GetHashCode() == polinom2.GetHashCode());
        }
    }
}
