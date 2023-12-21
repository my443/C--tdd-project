using csharp_tdd;

namespace chsharp_tdd_tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 2, 0.001, "Account not debited correctly");
        }
    }
}

//https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
// Assertions
//https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?view=visualstudiosdk-2022