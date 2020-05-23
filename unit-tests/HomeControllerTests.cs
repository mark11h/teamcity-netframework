using NUnit.Framework;
using System.Web.Mvc;
using teamcity_netframework.Controllers;

namespace unit_tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_loads_expected_view()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }
    }
}