using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.RomanovS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RomanovS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Слава";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Слава", res);
        }
    }
}
