using SampleAppWithNugetDependency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    
    
    /// <summary>
    ///This is a test class for ProfileServiceTest and is intended
    ///to contain all ProfileServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProfileServiceTest
    {
        /// <summary>
        ///A test for Profile
        ///</summary>
        [TestMethod()]
        public void ProfileTest()
        {
            var target = new ProfileService();

            var actual = target.Profile(2);

            Assert.AreEqual(4, actual);

        }
    }
}
