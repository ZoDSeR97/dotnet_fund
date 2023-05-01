class MagicCaster:Enemy{
    public MagicCaster():base("Magic Caster", 80){
        this.moves = new List<Attack>{
            new Attack("Fireball", 25),
            new Attack("Lightning Bolt", 20),
            new Attack("Staff Strike", 20)
        };
    }
    public void Heal(Enemy Target){
        if(Target.health > 0){
            Target.health+=40;
            if(Target.health>Target.maxHealth)
                Target.health = Target.maxHealth;
            Console.WriteLine($"{this.name} heal {Target.name} for 40 hit points and increasing {Target.name}'s health to {Target.health}!!");
        }else
            Console.WriteLine($"{this.name} has not mastered necromancy yet...");
    }
}