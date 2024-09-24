using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Module02
{
    [TestClass]
    public class UnitestBai03
    {
        [TestMethod]
        public void TestValidPartition01()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

            int num = 7;
            Boolean actualResult = method.primeCheck(num);
            Boolean expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestValidPartition02()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

            int num = 18;
            Boolean actualResult = method.primeCheck(num);
            Boolean expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestInvalidPartition01()
        {
            Exception e = null;

            try
            {
                MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

                int num = -8;
                Boolean actualResult = method.primeCheck(num);
            }
            catch (Exception ex)
            {
                e = ex;
            }

            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void TestInvalidPartition02()
        {
            Exception e = null;
            
            try
            {
                MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

                int num = 1321;
                Boolean actualResult = method.primeCheck(num);
            }
            catch(Exception ex)
            {
                e = ex;
            }

            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void TestValidBoundary01()
        {
                MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

                int num = 0;
                Boolean actualResult = method.primeCheck(num);
                Boolean expectedResult = false;

                Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestValidBoundary02()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

            int num = 1000;
            Boolean actualResult = method.primeCheck(num);
            Boolean expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestValidBoundary03()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

            int num = 1;
            Boolean actualResult = method.primeCheck(num);
            Boolean expectedResult = false;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestValidBoundary04()
        {
            MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

            int num = 2;
            Boolean actualResult = method.primeCheck(num);
            Boolean expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestInvalidBoundary01()
        {
            Exception e = null;

            try
            {
                MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

                int num = -1;
                Boolean actualResult = method.primeCheck(num);
            }
            catch (Exception ex)
            {
                e = ex;
            }

            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void TestInvalidBoundary02()
        {
            Exception e = null;

            try
            {
                MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

                int num = 1001;
                Boolean actualResult = method.primeCheck(num);
            }
            catch (Exception ex)
            {
                e = ex;
            }

            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void TestInval()
        {
            Exception e = null;

            try
            {
                MethodLibrary.MethodLibrary method = new MethodLibrary.MethodLibrary();

                int num = 1570;
                Boolean actualResult = method.IsLeapYear(num);
                Console.WriteLine(actualResult);
            }
            catch (Exception ex)
            {
                e = ex;
            }

            // Assert.IsNotNull(e);
        }
    }
}
