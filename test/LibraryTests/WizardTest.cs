using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace TestLibrary;
[TestFixture]

public class WizardTests
{
    private Wizard Maria;
    private Staff FireStaff;
    private SpellBook spellBook;
    private Spell IceBall, FireBall;
    [SetUp]
    public void Setup()
    {
        Wizard Maria = new Wizard("Maria");
        Staff FireStaff = new Staff("FireStaff", 25, 5);
        SpellBook spellBook = new SpellBook("spellbook");
        Spell IceBall = new Spell("IceBall", 10, 4);
        Spell FireBall = new Spell("FireBall", 15, 1);

    }

    [Test]
    public void WizardEmpiezaConSuVidaNormal()
    {
        Assert.That(Maria.CurrentHealth, Is.EqualTo(Maria.MaxHealth));
    }
    [Test]
    public void ValorDeAtaqueConUnItem()
    {
        Maria.AddItem(FireStaff);
        Assert.That(Maria.TotalAttack(), Is.EqualTo(25));//Su daño va a ser 25 puntos cuadno tiene el objeto Addeado
    }
    [Test]
    public void WizardConSuSpellBook()
    {
        spellBook.AddSpell(IceBall);
        spellBook.AddSpell(FireBall);
        Maria.AddItem(spellBook);
        Assert.That(Maria.TotalAttack(), Is.EqualTo(25));//Deberia tener aca tambien 25 de daño ya que Iceball tiene 10 puntos de daño y fireball tiene 15


    }

    [Test]
    public void LeBajoPuntosdeVidaYSeLaRestauro()
    {
        //le infligimos daño directo
        Maria.ReceiveAttack(40);
        Assert.That(Maria.CurrentHealth, Is.LessThan(Maria.MaxHealth));

        Maria.Heal();

        Assert.That(Maria.CurrentHealth, Is.EqualTo(Maria.MaxHealth));

    }

}