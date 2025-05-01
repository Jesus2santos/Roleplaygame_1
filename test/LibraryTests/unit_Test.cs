using NUnit.Framework;

namespace LibraryTests
{
    // Clases auxiliares para las pruebas
    public class Sword : Item
    {
        public Sword() : base("Sword", 30, 10) { }
    }

    public class Shield : Item
    {
        public Shield() : base("Shield", 0, 25) { }
    }

    public class KnightTests
    {
        private Knight knight;

        [SetUp]
        public void Setup()
        {
            knight = new Knight("Arthur");
        }

        [Test]
        public void Knight_ShouldStartWithFullHealth()
        {
            Assert.AreEqual(150, knight.CurrentHealth);
        }

        [Test]
        public void AddItem_ShouldIncreaseAttackAndDefense()
        {
            knight.AddItem(new Sword());
            knight.AddItem(new Shield());

            Assert.AreEqual(30, knight.TotalAttack());
            Assert.AreEqual(35, knight.TotalDefense());
        }

        [Test]
        public void RemoveItem_ShouldDecreaseStats()
        {
            var sword = new Sword();
            knight.AddItem(sword);
            knight.RemoveItem(sword);

            Assert.AreEqual(0, knight.TotalAttack());
            Assert.AreEqual(0, knight.TotalDefense());
        }

        [Test]
        public void ReceiveAttack_WithHighDefense_ShouldReduceNoHealth()
        {
            knight.AddItem(new Shield()); // +25 defensa
            knight.ReceiveAttack(20);     // Menor que la defensa total

            Assert.AreEqual(150, knight.CurrentHealth);
        }

        [Test]
        public void ReceiveAttack_ShouldReduceHealthCorrectly()
        {
            knight.AddItem(new Shield()); // Defensa: 25
            knight.ReceiveAttack(50);     // Daño efectivo: 25

            Assert.AreEqual(125, knight.CurrentHealth);
        }

        [Test]
        public void ReceiveAttack_ShouldNotGoBelowZero()
        {
            knight.ReceiveAttack(1000);
            Assert.AreEqual(0, knight.CurrentHealth);
        }

        [Test]
        public void Heal_ShouldRestoreToFullHealth()
        {
            knight.ReceiveAttack(100);
            knight.Heal();

            Assert.AreEqual(150, knight.CurrentHealth);
        }
    }
    public class WizardTests
    {
        private Wizard wizard;

        [SetUp]
        public void Setup()
        {
            wizard = new Wizard("Gandalf");
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
