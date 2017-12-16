using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciClient;
using FibonacciClient.MyService;


namespace WebSiteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            FibonacciSoapClient proxy = new FibonacciSoapClient();

            int fromCall;


            //Act
            fromCall = proxy.FibonacciSeries(5);


            //Assert
            Assert.AreEqual(5,fromCall);
        }
    }
}
