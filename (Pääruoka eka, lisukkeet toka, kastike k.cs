(Pääruoka eka, lisukkeet toka, kastike kolmas) kolmeRuokaAinetta; //= (Pääruoka.nautaa, lisukkeet.pastaa, kastike.curry);
//kolmeRuokaAinetta.eka = Pääruoka.kanaa;

Console.Write($"Pääraaka-aine ({Pääruoka.nautaa}, {Pääruoka.kanaa}, {Pääruoka.kasviksia}): ");
string eka = Console.ReadLine();

Console.Write($"Lisukkeet ({lisukkeet.perunaa}, {lisukkeet.riisia}, {lisukkeet.pastaa}): ");
string toka = Console.ReadLine();

Console.Write($"Kastike ({kastike.curry}, {kastike.hapanimelä}, {kastike.pippuri}, {kastike.chili}): ");
 string kolmas = Console.ReadLine();

Console.WriteLine($"{eka} ja {toka} {kolmas}-kastikkeella");



enum Pääruoka { nautaa, kanaa, kasviksia}
enum lisukkeet { perunaa, riisia, pastaa}

enum kastike { curry, hapanimelä, pippuri, chili}