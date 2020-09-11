using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOExamples.Cmd.Models;

namespace OOExamples.Cmd.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        private AccountController accountController;
        private Account accountOne;
        private Account accountTwo;

        [TestInitialize]
        public void Prepare()
        {
            accountController = new AccountController();
            accountOne = new Account(1);
            accountTwo = new Account(2);
        }

        [TestMethod()]
        public void TransferToAccountTest()
        {        
            accountOne.Balance = 1000;
            var result = accountController.TransferToAccount(accountOne, accountTwo, 300);

            Assert.IsTrue(result);
            Assert.AreEqual(700, accountOne.Balance);
            Assert.AreEqual(300, accountTwo.Balance);
        }

        [TestMethod()]
        public void TransferToAccountBalanceLowTest()
        {
            accountOne.Balance = 100;
            var result = accountController.TransferToAccount(accountOne, accountTwo, 101);

            Assert.IsFalse(result);
            Assert.AreEqual(100, accountOne.Balance);
            Assert.AreEqual(0, accountTwo.Balance);
        }
    }
}