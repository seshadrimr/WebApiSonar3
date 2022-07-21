using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using WebApiWithUnitTest_ForSonar.Controllers;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var controller = new ValuesController();
            var result = controller.Get().Result as OkObjectResult;
            var a = result.Value;
            
            Assert.IsTrue(((string[])result.Value).Length > 0);
            //Assert.Pass();
        }
    }
}