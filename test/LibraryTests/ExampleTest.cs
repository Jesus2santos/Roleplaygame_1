using NUnit.Framework;
using Library;

namespace LibraryTests
{
    [TestFixture]
    public class CharacterTest
    {
        private Wizard wizard;

        [SetUp]
        public void Setup()
        {
            wizard = new Wizard("Santiago");
        }

        [Test]
        public void Wizard_ShouldStartWithFullHealth()
        {
            Assert.AreEqual(110, wizard.CurrentHealth);
        }

        [Test]
        public void ReceiveAttack_ShouldNotGoBelowZero()
        {
            wizard.ReceiveAttack(999);
            Assert.AreEqual(0, wizard.CurrentHealth);
        }

        [Test]
        public void Heal_ShouldRestoreToFullHealth()
        {
            wizard.ReceiveAttack(80);
            wizard.Heal();
            Assert.AreEqual(110, wizard.CurrentHealth);
        }
    }
}
