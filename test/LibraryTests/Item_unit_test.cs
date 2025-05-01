public class Sword : Item
    {
        public Sword() : base("Sword", 30, 10) { }
    }

    public class LongSword : Item
    {
        public LongSword() : base("Long Sword", 50, 5) { }
    }

    public class Shield : Item
    {
        public Shield() : base("Shield", 0, 25) { }
    }

    public class Staff : Item
    {
        public Staff() : base("Staff", 20, 10) { }
    }

    public class BowAndArrow : Item
    {
        public BowAndArrow() : base("Bow and Arrow", 35, 5) { }
    }

    public class Axe : Item
    {
        public Axe() : base("Axe", 40, 8) { }
    }

    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void Sword_ShouldHaveCorrectStats()
        {
            var item = new Sword();
            Assert.AreEqual("Sword", item.Name);
            Assert.AreEqual(30, item.AttackValue);
            Assert.AreEqual(10, item.DefenseValue);
        }

        [Test]
        public void LongSword_ShouldHaveCorrectStats()
        {
            var item = new LongSword();
            Assert.AreEqual("Long Sword", item.Name);
            Assert.AreEqual(50, item.AttackValue);
            Assert.AreEqual(5, item.DefenseValue);
        }

        [Test]
        public void Shield_ShouldHaveCorrectStats()
        {
            var item = new Shield();
            Assert.AreEqual("Shield", item.Name);
            Assert.AreEqual(0, item.AttackValue);
            Assert.AreEqual(25, item.DefenseValue);
        }

        [Test]
        public void Staff_ShouldHaveCorrectStats()
        {
            var item = new Staff();
            Assert.AreEqual("Staff", item.Name);
            Assert.AreEqual(20, item.AttackValue);
            Assert.AreEqual(10, item.DefenseValue);
        }

        [Test]
        public void BowAndArrow_ShouldHaveCorrectStats()
        {
            var item = new BowAndArrow();
            Assert.AreEqual("Bow and Arrow", item.Name);
            Assert.AreEqual(35, item.AttackValue);
            Assert.AreEqual(5, item.DefenseValue);
        }

        [Test]
        public void Axe_ShouldHaveCorrectStats()
        {
            var item = new Axe();
            Assert.AreEqual("Axe", item.Name);
            Assert.AreEqual(40, item.AttackValue);
            Assert.AreEqual(8, item.DefenseValue);
        }
    }