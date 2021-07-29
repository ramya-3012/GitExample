using NUnit.Framework;
using GitExample;

namespace TestProject1
{
    [TestFixture]
    public class BankTest
    {
        Bank b = new Bank();
        [Test]
        public void Transfer()
        {
            b.Deposit(200);

            b.Withdraw(10);

            Assert.AreEqual(190, b.balance);
        }
    }
}