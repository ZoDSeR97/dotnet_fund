class RangedFighter:Enemy{
    int distance = 5;
    public RangedFighter():base("Ranged Fighter"){
        this.moves = new List<Attack>{
            new Attack("Shoot an Arrow", 20),
            new Attack("Throw a knife", 15)
        };
    }
    public void Dash() => this.distance = 20;
    public override void PerformAttack(Enemy Target, Attack ChosenAttack){
        if(distance>=10)
            base.PerformAttack(Target, ChosenAttack);
        else
            Console.WriteLine($"{ this.name} need to reposition...");
    }
}