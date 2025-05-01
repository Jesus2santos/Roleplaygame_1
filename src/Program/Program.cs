using Library;

Wizard rodrigo = new Wizard("Rodrigo");
Staff fireStaff = new Staff("Bastón de Fuego", 25, 5);
rodrigo.AddItem(fireStaff);

SpellBook fireBook = new SpellBook("Libro de Fuego");
fireBook.AddSpell(new Spell("Bola de Fuego"));
fireBook.AddSpell(new Spell("Rayo de Fuego"));
rodrigo.AddItem(fireBook);
Console.WriteLine($"El ataque del libro de hechizos de {rodrigo.Name} es: {fireBook.AttackValue}");

Knight leon = new Knight("Leon"); // suponiendo que tenés una clase Knight
Shield ironShield = new Shield("Escudo de Hierro");
leon.AddItem(ironShield);
leon.TotalDefense();
Console.WriteLine($"La defensa de Leon es de : {leon.TotalDefense()} ya que tiene puesto un Escudo de Hierro");


// El mago ataca al caballero con su ataque total
int attackValue = rodrigo.TotalAttack();
leon.ReceiveAttack(attackValue);


Console.WriteLine($"Vida de Leon después del ataque: {leon.CurrentHealth}");
Knight Santiago = new Knight("Santiago");
Sword Katana = new Sword("Katana");
Santiago.AddItem(Katana);
Bow_and_Arrow Arco = new Bow_and_Arrow("Arco");
Santiago.AddItem(Arco);
Santiago.TotalAttack(); 
Console.WriteLine($"El ataque de Santiago es de : {Santiago.TotalAttack()} ya que tiene puesto un Arco y una Katana");

Elve alex = new Elve("alex");
Sword Hacha = new Sword("Hacha");
alex.AddItem(Hacha);
attackValue = Santiago.TotalAttack(); 
alex.ReceiveAttack(attackValue);
Console.WriteLine($"Vida de Alex después del ataque: {alex.CurrentHealth}");

Dwarve Agustin = new Dwarve("Agustin");
LongSword EspadaLarga = new LongSword("EspadaLarga");
Agustin.AddItem(EspadaLarga);

Elve Valentina = new Elve("Valentina");
Sword Sable = new Sword("Sable");
Valentina.AddItem(Sable);
attackValue = Agustin.TotalAttack();
Valentina.ReceiveAttack(attackValue);
Console.WriteLine($"Vida de Valentina después del ataque: {Valentina.CurrentHealth}");
Valentina.Heal(); //curo al personaje
Console.WriteLine($"Vida de Valentina Actual: {Valentina.CurrentHealth}");








