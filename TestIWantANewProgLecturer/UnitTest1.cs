using prjILieToSiraboutUnitTesting;

namespace TestIWantANewProgLecturer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestName()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String Expected = "Jeff";
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestEmail() 
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getEmail();
            String Expected = "jess@gmail.com";
            Assert.AreEqual(Expected, Actual);

        }
        [TestMethod]
        public void TestAge() 
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getDate();
            String Expected = "2024/04/04";
            Assert.AreEqual(Expected, Actual);
        }
    }
}