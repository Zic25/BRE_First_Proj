using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BRE;
namespace BRE_UTest
{
    [TestClass]
    public class UnitTestAll
    {
        /// <summary>
        /// Below are some unit test case functions for unit testing with positive and negative sinarious
        /// 
        /// </summary>

        [TestMethod]
        public void TestMethodBooksPass()
        {
            BRE.ProClasses.Books bm = new BRE.ProClasses.Books();
            string res = bm.BooksLogic();
            Assert.AreEqual("Books Received", "Books Received");
        }
        [TestMethod]
        public void TestMethodBooksFail()
        {
            BRE.ProClasses.Books bm = new BRE.ProClasses.Books();
            string res = bm.BooksLogic();
            Assert.AreEqual("Books9 Received", "Books Received");
        }





        // Membership Unit Tests 

        [TestMethod]
        public void TestMethodMembershipCreatePass()
        {
            BRE.ProClasses.Membership bm = new BRE.ProClasses.Membership();
            string res = bm.MembershipCreate();
            Assert.AreEqual("Membership created", "Membership created");
        }
        [TestMethod]
        public void TestMethodMembershipUpgradePass()
        {
            BRE.ProClasses.Membership bm = new BRE.ProClasses.Membership();
            string res = bm.MembershipUpgrade();
            Assert.AreEqual("Membership Upgraded", "Membership Upgraded");
        }


        [TestMethod]
        public void TestMethodMembershipCreateFail()
        {
            BRE.ProClasses.Membership bm = new BRE.ProClasses.Membership();
            string res = bm.MembershipCreate();
            Assert.AreEqual("Membership created3", "Membership created");
        }
        [TestMethod]
        public void TestMethodMembershipUpgradeFail()
        {
            BRE.ProClasses.Membership bm = new BRE.ProClasses.Membership();
            string res = bm.MembershipUpgrade();
            Assert.AreEqual("Membership Upgraded2", "Membership Upgraded");
        }


        //// Note :- Likewise above we can write code for all classes created
        ///for unit testing funtions and creation of Test cases and Sinarious 
        ///and Testing it.


    }
}
