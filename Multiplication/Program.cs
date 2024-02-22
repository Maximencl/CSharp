// Boucle for
/*
for (int i = 1; i < 11; i++) {
    Console.WiteLine(i);
}

int i = 0;
while(i < 5) {
    ...
    i++;
}

bool continuer = true;
while(continuer) {
    ...
    continuer=false;
}
*/

Console.WriteLine("Quelle table voulez vous afficher ? (Saisir un nombre)");
string table = Console.ReadLine();
int table2=int.Parse(table);
for (int i = 1; i < 11; i++) {
Console.WriteLine($"{i}x{table2} = {i*table2}");
}