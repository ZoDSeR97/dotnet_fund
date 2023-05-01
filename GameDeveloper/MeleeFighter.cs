class MeleeFighter:Enemy{
    bool rage = false;
    public MeleeFighter():base("Melee Fighter", 120){
        this.moves = new List<Attack>{
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }
    public Attack Rage(){
        rage = true;
        return this.moves[rng.Next(moves.Count)];
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack){
        if (rage)
            ChosenAttack=new Attack(ChosenAttack.name, ChosenAttack.dmg+10);
        base.PerformAttack(Target, ChosenAttack);
        rage = false;
    }
}