//Console est un objet du Framework .NET
//WriteLine est une méthode de l'objet Console qui permet d'afficher du texte dans la console
//La méthode WrtiteLine prend en paramètre une chaîne de caractères
Console.WriteLine("Bonjour à tous !");

// = commentaires C# sur une ligne
/*
    commentaires C# sur plusieurs lignes
*/

// Déclaration d'une variable de type entier (int) nommée age
int age;
// Affectation de la valeur 40 à la variable age
age=40;

Console.WriteLine(age);
// Affectation de la valeur 40 à la variable age

// Déclaration d'une variable de type entier (int) nommé taille et affectation de la valeur 180
int taille = 180; // Déclaration et affectation en une seule ligne

// Affichage des variables age et taille
Console.WriteLine(age);
Console.WriteLine(taille);

// ATTENTION : Affichage du mot taille
Console.WriteLine("taille");

string prenom = "Jean";
Console.WriteLine(prenom); // Affiche Jean
string nom = "Dupont";
Console.WriteLine(nom); // Affiche Dupont

// Concaténation de deux chaînes de caractères
Console.WriteLine(prenom + " " + nom); // Affiche Jean Dupont

Console.WriteLine("Bonjour " + prenom + " " + nom + ", vous avez " + age + " ans et vous mesurez " + taille + " cm");

// Variante 1 avec les placeholders
Console.WriteLine("Bonjour {0} {1}, vous avez {2} ans et vous mesurez {3} cm", prenom, nom, age, taille);

// Variante 2 avec les placeholders et le signe dollar (Interpolation de chaînes de caractères)
Console.WriteLine($"Bonjour {prenom} {nom}, vous avez {age} ans et vous mesurez {taille} cm");

// Déclaration d'une variable de type booléen (bool) nommée estMariee et affectation de la valeur true
bool estMariee = true;
estMariee = false; // Modification de la valeur de la variable estMariee (réaffectation)
Console.WriteLine(estMariee); // Affiche True

// Déclaration d'une variable de type décimal (decimal) nommée salaire et affectation de la valeur 1500.50
decimal salaire = 1500.50M; // Le suffixe m'indique la valeur est de type décimal
Console.WriteLine(salaire); // Affiche 1500.50

// Lecture de données saisies au clavier
// La méthode ReadLine de l'objet Console permet de lire une chaîne de caractèrres saisue au clavier
string chaine = Console.ReadLine(); // Erreur de compilation car la méthode ReadLine retourne une chaîne de caractères
Console.WriteLine($"Vous avez saisi : {chaine}");

Console.Write("Texte1");
Console.Write("Texte2");