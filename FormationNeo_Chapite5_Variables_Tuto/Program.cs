
/* Bonjour dans votre premier exercice de la formation Néo!
 * Avez vous bien lu le cours? Bien, allons-y!
 * 
 * Avant de réparer le QG des super-héros, il vous faut
 * commencer par la base. Ce projet est lire de haut en bas, comme un livre
 * Les commentaires (en vert, comme celui-çi) sont pour l'instant ce qui est 
 * le plus important à lire et à comprendre !
 * 
 * Pour partir du plus simple, nous avons ici créé une "application console",
 * c'est à dire une application qui n'affiche que du texte à l'écran, mais ne vous 
 * inquiéter pas, vous aurez bientot une application graphique!
 * 
 * Sur la droite de votre écran, vous trouverez un onglet "Explorateur de solution"
 * avec un tas de choses compliqués: Nous y reviendrons plus tard, mais sachez que
 * c'est VisualStudio qui à tout mis en place! Nous n'avons modifié que ce fichier, 
 * et c'est la seule chose dont vous aurez besoin
 * 
 * Nous allons commencer par la brique élémentaire de tout programme informatique,
 * les variables!
 * 
 * Commencer par choisir ce projet au démarrage. Pour ce faire, faites un clic droit 
 * sur "FormationNeo_Chapitre5_Variable_Tuto", et cliquer sur l'icone 
 * de roue dentée "Définir comme projet de démarrage".
*/

// Ces lignes permettent d'appeler des "Bibliothèques Sytèmes"
// Cette instruction permet que l'on utilise des variables par exemple,
// et elle gère pour nous beaucoup plus!
using System;

// Le "namespace" est l'endroit où vit votre programme
namespace FormationNeo_Chapite5_Variables_Tuto
{
    // Voici l'endroit où tout ce joue. C'est ici que commence votre premier programme!
    class Program
    {
        /*Le "Main" est la fonction principale de tout programme. C'est par cette fonction
         * que votre programme commencera toujours. Il n'y à qu'une fonction dans ce chapitre,
         * et nous verrons plus en détails les fonctions dans le chapitre 7!
        */
        static void Main(string[] args)
        {
            /* Notre but ici est de tester que l'ordinateur central du QG des héros fonctionne toujours.
             * Nous allons donc tester d'afficher des éléments à l'écran, voir les différent types de 
             * variable et les opérations mathématiques de base!
             * 
             * Ceci est le premier tutoriel, et est juste une démonstration de "comment ça marche"
             * Ici vous n'avez rien à faire, rien à écrire. Lisez juste ce qui ce passe dans ce code.
             * La commande pour compiler et executer ce code est présente à la fin de ce tutoriel.
            */

            // Commençons par les entiers, les int (pour integers en anglais)
            // Déclaration de variables en une seule ligne:
            int variableUne = 5;
            int variableDeux = 3;

            // Déclaration de variable en plusieurs lignes:
            int variableTrois;
            variableTrois = 73;

            // Il est possible de déclarer une variable sans l'affecter
            int resultat;


            // Pour plus de clareté, il est possible de cliquer sur la petite croix à gauche de l'écran, 
            // et ainsi de réduire ou d'agrandir chaque partie de ce tutorial
            #region Debut de tutoriel
            // Cette ligne affiche "Début du tutoriel" à l'écran. 
            // Notez bien: On ne voit pas l'initialisation des variables.
            Console.WriteLine("- - - Début du tutoriel - - -" + Environment.NewLine);

            // On peut afficher une variable via la commande suivante.
            // Elle sera écrite pour vous dans ces exercices
            Console.WriteLine("Valeur de variableUne: " + variableUne);
            Console.WriteLine("Valeur de variableDeux: " + variableDeux);
            Console.WriteLine("Valeur de variableTrois: " + variableTrois);

            // A ce stade, impossible d'afficher la valeur de "resultat", car elle n'est pas 
            // initialisée et resultarai en une erreur de compilation!
            // Décommenter la ligne suivante pour tester par vous même!
            // Console.WriteLine("Valeur de resultat " + resultat);

            // Il est possible d'affecter une valeur à une variable pendant un programme,
            // et ce autant de fois qu'on le veux! Désomais, variableUne vaut 6 (jusqu'à la fin de ce tuto)
            variableUne = 6 ;
            #endregion

            #region Opérations mathématiques
            Console.WriteLine(Environment.NewLine + "- - - Opérations mathématiques - - -" + Environment.NewLine);

            resultat = variableUne + variableDeux; // ici resultat vaut 6 + 3 soit 9.
            Console.WriteLine("Valeur de resultat addition: " + resultat); // Ici, pas d'erreur, car resultat à désormais une valeur.

            // Il est possible de changer plusieur fois la valeur de résultat
            resultat = variableDeux - variableUne; // ici resultat vaut 3 - 6 soit -3. (Un entier peut être négatif!)
            Console.WriteLine("Valeur de resultat soustraction: " + resultat);

            // Une variable peut être utilisé plusieurs fois
            resultat = variableUne * variableUne * 6; // ici resultat vaut 6 * 6 * 6 soit 216. Et pas besoin de passer toujours pas une variable!
            Console.WriteLine("Valeur de resultat multiplication: " + resultat);

            // Il est possible de faire un retour de valeur dans affectation directe dans une variable
            Console.WriteLine("Valeur de resultat division: " + (variableTrois / variableDeux)); // 73 / 3 = 24 (et non pas 24.33333...)

            // ATTENTION  A LA DIVISION PAR ZERO! Elle causera une erreur critique qui ferra quitter votre programme!
            // Décommenter les lignes suivante pour tester (c'est sans danger et c'est instructif!)
            //int zero = 0;
            //Console.WriteLine("Division par zéro! " + 3 / zero);

            // Il est possible d'enchainer les opérations
            resultat = variableUne * variableDeux; // 6 * 3 = 18
            resultat = variableTrois % resultat;  // 73 % 18 = 1
            Console.WriteLine("Valeur de resultat modulo: " + resultat);

            // Il est possible de simplifier les opérations ainsi:
            resultat = 0;
            resultat += variableTrois; // équivalent à resultat = resultat + variableTrois; // 0 + 73  = 73
            resultat -= variableUne; // équivalent à resultat = resultat - variableTrois;   // 73 - 6  = 67
            resultat *= variableDeux; // équivalent à resultat = resultat * variableTrois;  // 67 * 3  = 201
            resultat /= variableUne; // équivalent à resultat = resultat / variableTrois;   // 201 / 6 = 33
            Console.WriteLine("Valeur de resultat final: " + resultat);

            // Enfin, il est possible d'incrémenter et de décrémenter une valeur de 1, simplement:
            variableUne++; // équivalent à variableUne += 1 ou variableUne = variableUne + 1 ou ++variableUne
            Console.WriteLine("Valeur de variableUne incrémenté: " + variableUne); // 6 + 1 = 7;
            variableUne--;
            Console.WriteLine("Valeur de variableUne décrémenté: " + variableUne); // 7 - 1 = 6;
            #endregion

            #region Les autres variables
            Console.WriteLine(Environment.NewLine + "- - - Autres variables - - -" + Environment.NewLine);

            // Le double contient une valeur non entière
            double unDouble = 3.677;

            // Un booléen, contenant la valeur vrai (true) ou fausse (false)
            bool unBool = true;

            // un charactere alphanumérique (Ex: 1, 3, 9, A, z, Y, g, '-', '@', '§', 'ù', '#', '€', ...)
            char unCharC = 'c';

            // Une série de charactere
            string uneString = "Une petite phrase, avec ponctuation et espace...";

            // Une variable indéterminée, dont le type est déterminé à la compilation
            var uneVariableAuTypeIndetermine = 3; // ici 'var' est un 'int'
            var uneVariableAuTypeIndetermine2 = "poney"; // ici 'var' est une 'string'

            Console.WriteLine("Ici, il y a plein de variables!" + Environment.NewLine
                            + "Il y a un double qui vaut " + unDouble + Environment.NewLine
                            + "Il y a un booleen qui vaut " + unBool + Environment.NewLine
                            + "Il y a un charactère qui vaut " + unCharC + Environment.NewLine
                            + "Il y a une string qui vaut '" + uneString + Environment.NewLine
                            + "Et il y a deux variable 'var' qui valent '" + uneVariableAuTypeIndetermine +"' et '" + uneVariableAuTypeIndetermine2 + "'!" + Environment.NewLine);

            // Et le type void? Hé bien il est impossible d'initialiser un type void! Nous en reparlerons plus tard!
            // Noter en attendant que la fonction "Main" est de type... void!
            #endregion

            /* Vous voici à la fin de ce premier tutoriel, vous allez donc pouvoir compiler et lancer l'application!
             * Pour ce faire, utiliser le raccourci Ctrl + F5, ou décommenter la ligne suivante et cliquer sur le bouton
             * "Démarrer" situé en haut de la page, pret de la flèche verte.
             * 
             * Si rien ne s'affiche, vous n'avez pas du définir le bon projet au démarrage!
             * Rappel: pour définir ce projet, faites un clic droit 
             * sur "FormationNeo_Chapitre5_Variable_Tuto", et cliquer sur l'icone 
             * de roue dentée "Définir comme projet de démarrage".
            */
            // Console.ReadKey(); // Si vous décommenter cette ligne, appuyer sur n'importe quelle touche pour quitter
        }
    }
}
