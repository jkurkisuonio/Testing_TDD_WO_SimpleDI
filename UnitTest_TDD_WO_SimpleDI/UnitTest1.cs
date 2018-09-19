using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_App;

namespace UnitTest_TDD_WO_SimpleDI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange - järjestetään tilanne testille otolliseksi.
            var user = new User();
            // Act - suoritetaan toimenpiteet, joita halutaan testata.
            var etunimi = user.FirstName;
            // Assert - todennetaan, miten testi meni.
            Assert.IsNotNull(etunimi);

        }
    }
}
