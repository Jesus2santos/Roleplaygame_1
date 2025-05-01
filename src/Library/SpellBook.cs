public class SpellBook : Item
{
    public List<Spell> Spells { get; } = new List<Spell>();

    public SpellBook(string name) : base(name, 0, 0) { }
    
    public void AddSpell(Spell spell)
    {
        Spells.Add(spell);
    }
    public override int AttackValue => Spells.Count;
}
