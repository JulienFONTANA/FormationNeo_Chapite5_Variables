
/* Vous revoila! Si vous n'avez pas encore lu "FormationNeo_Chapitre5_Variable_Tuto", alors 
 * je vous conseille fortement d'y jeter un oeil! Si ce n'est pas fait, cliquer dans l'onglet 
 * de droite "Explorateur de solution" sur le projet qui s'appel "FormationNeo_Chapitre5_Variable_Tuto".
 * Dans le menu déroulant qui s'affiche, et double cliquer sur le fichier "Program.cs" pour commencer 
 * votre formation.
 * 
 * Si vous êtes toujours la (ou de retour), alors c'est que vous avez comprit la notion de variable,
 * et que vous voulez à votre tour essayer de déclarer, d'affecter de d'afficher la valeur des variables.
 * 
 * Nous allons commencer par les valeurs numériques
 * Les notions dont vous avez besoin sont:
 *      --> Les variables numériques (int, double...)
 *      --> Les opération mathématiques de base
 * 
 * Commencer par choisir ce projet au démarrage. pour ce faire, faites un clic droit sur "FormationNeo_Chapitre5_Variable_Exo1",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
 * Si vous le faites sans avoir modifié ce code, il est sensé ne rien apparaitre!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite5_Variables_Exo1
{
    class Exo1Ch5Solution
    {
        static void Main(string[] args)
        {
            // Petite présentation des variables, déclarés toutes en une seule ligne!
            // a, b et c sont 3 int non initialisé. C'est à vous de les remplir correctement,
            // ou d'effectuer la bonne opération mathématique pour afficher le bon résultat
            int a, b, c;

            // Affecter la valeur 3 à 'a', de 7 à 'b' et de -2 à 'c'
            a = 3;
            b = 7;
            c = -2;

            // Déclarer la variable 'résultat' dans laquel vous stockerer la variable de la multiplication de 'a' par 'b' par 'c'
            int resultat = a * b * c;

            // Afficher la valeur de 'résultat' à l'écran pour vérifier
            Console.WriteLine(resultat);

            // Multiplier la variable 'résultat' pour la rendre positive sans utiliser de variable. Utiliser un nombre entier...
            resultat = resultat * -1; // ou resultat *= -1;

            // Afficher la valeur de 'résultat' à l'écran pour vérifier
            Console.WriteLine(resultat);

            // Affecter la valeur de 'b' à 'c' 
            c = b;

            // Affecter la valeur de 'a' plus 'c' à 'a'
            a = a + c; // ou a += c;

            // Afficher les valeurs de 'a', de 'b', et de 'c'
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Afficher la somme de 'a', 'b' et 'c' de la manière de votre choix 
            //(bonus: possible en une seule ligne sans affectation)
            resultat = a + b + c;
            Console.WriteLine(resultat);
            // bonus : Console.WriteLine(a + b + c);

            // Créer 2 variables, 'd', et 'e' capable de stocker des nombre décimaux (à virgule)
            // Affecter leur les valeurs 3.14 et 5.33 lors de leur déclaration
            double d = 3.14;
            double e = 5.33;

            // Afficher le résultat d'une muliplication entre 'd' et 'e' sans créer de nouvelles variables
            Console.WriteLine(d * e);

            // Afficher le résultat d'une division entre 'e' et 'd' sans créer de nouvelles variables 
            Console.WriteLine(e / d);

            // Essayer d'expliquer ce résultat!

            /* Affichage attendu:
             * -42
             * 42
             * 10
             * 7
             * 7
             * 24
             * 16,7362
             * 1,69745222929936
             * Ce résultat est le résultat de la division de nombre à virgules, il est donc à virgules lui aussi!
             * La division 7 / 2 = 3 n'as pas de virgules car ce sont des nombres entiers
            */
        }
    }
}
