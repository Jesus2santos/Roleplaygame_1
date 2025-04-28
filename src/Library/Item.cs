public abstract class Item
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }

    public Item(string name, int attackValue, int defenseValue)
    {
        Name = name;
        AttackValue = attackValue;
        DefenseValue = defenseValue;
    }
}