class Enemy{
    public string name {get;}
    public int maxHealth {get;} = 100;
    public int health {get; set;} = 100;
    public List<Attack> moves {get; protected set;} = new List<Attack>();
    protected Random rng {get;} = new Random();
    public Enemy(string name){
        this.name = name;
    }
    public Enemy(string name, int health){
        this.name = name;
        this.health = health;
        this.maxHealth = health;
    }
    public Attack RngMove() => this.moves[rng.Next(moves.Count)];
    public void AddMove(Attack m) => this.moves.Add(m);
    // Inside of the Enemy class
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack){
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        if(this.health > 0){
            Target.health-=ChosenAttack.dmg;
            Console.WriteLine($"{this.name} {ChosenAttack.name} {Target.name}, dealing {ChosenAttack.dmg} damage and reducing {Target.name}'s health to {Target.health}!!");
        }else{
            Console.WriteLine($"{this.name} is too busy at being legend in the after life to be bothered...");
        }
    }
}