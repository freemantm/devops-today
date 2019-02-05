using DevOpsToday.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }

    [TestMethod]
    public void Test_PrivacyAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Privacy());
    }

    [TestMethod]
    public void Test_ErrorAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Error());
    }
  }
}
