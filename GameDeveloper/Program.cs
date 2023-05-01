// See https://aka.ms/new-console-template for more information
MeleeFighter f = new MeleeFighter();
RangedFighter s = new RangedFighter();
MagicCaster ss = new MagicCaster();
f.PerformAttack(s, f.moves[1]);
f.PerformAttack(ss, f.Rage());
f.moves.ForEach(item=>Console.WriteLine($"{item.name} {item.dmg} dmg"));
s.PerformAttack(f, s.moves[0]);
s.Dash();
s.PerformAttack(f, s.moves[0]);
ss.PerformAttack(f, ss.moves[0]);
ss.Heal(s);
ss.Heal(ss);