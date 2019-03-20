using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Method_Array;
namespace Tests_Array
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3 };
            int[] aspettato = { 11, 12, 13 };
            int[] b = Confronto_Array.Confronto(a);
            
            CollectionAssert.AreEqual(aspettato, b);
        }
    }
}
