using System.Collections.Generic;
using System.Linq;

public abstract class Character
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }
    public List<Item> Items { get; private set; } = new List<Item>();

    public Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public int TotalAttack()
    {
        return Items.Sum(item => item.AttackValue);
    }

    public int TotalDefense()
    {
        return Items.Sum(item => item.DefenseValue);
    }

    public void ReceiveAttack(int damage)
    {
        int effectiveDamage = damage - TotalDefense();
        if (effectiveDamage < 0)
            effectiveDamage = 0;

        CurrentHealth -= effectiveDamage;
        if (CurrentHealth < 0)
            CurrentHealth = 0;
    }

    public void Heal()
    {
        CurrentHealth = MaxHealth;
    }
}