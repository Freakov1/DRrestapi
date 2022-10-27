using DRrestapi.Controllers;
using DRrestapi.Models;

namespace RecordsTest
{
    [TestClass]
    public class RecordControllerTest
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var controller = new RecordsController();
            List<Record> testList = controller.GetAll();

            Assert.AreEqual(testList.Count, 4);

            Assert.IsNotNull(testList);

            Assert.AreEqual(typeof(List<Record>), testList.GetType());
        }
    }
}