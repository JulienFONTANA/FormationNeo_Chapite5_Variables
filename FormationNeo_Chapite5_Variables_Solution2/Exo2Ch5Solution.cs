﻿
/* Avez vous réussi l'exercice N°1 ? Vos valeurs étaient elle toutes correctes?
 * Dans ce cas bravo! Vous avez donc réussi à travailler sur des valeurs numériques!
 * Et si on passait au chaines de charactères???
 * 
 * Les notions dont vous avez besoin sont:
 *      --> Les variables non numériques (string, bool...)
 *      --> et c'est tout ;)
 * 
 * Commencer par choisir ce projet au démarrage. pour ce faire, faites un clic droit sur "FormationNeo_Chapitre5_Variable_Exo2",
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

namespace FormationNeo_Chapite5_Variables_Exo2
{
    class Exo2Ch5Solution
    {
        static void Main(string[] args)
        {
            // Déclarer une variable capable de contenir un charactère, la lettre t
            // Attention à la syntaxe !
            char t = 't';

            // Déclarer une variable capable de contenir un charactère, le chiffre 8 (oui, un chiffre sous forme de charactère)
            // Attention à la syntaxe !
            char huit = '8';

            // Déclarer une variable capable de contenir une chaine de charactère.
            // Initialiser la avec une phrase simple sur le temps qu'il fait!
            // Attention à la syntaxe !
            string str = "Il fait beau aujourd'hui";

            // Afficher la valeur de ces trois variables à l'écran
            Console.WriteLine(t);
            Console.WriteLine(huit);
            Console.WriteLine(str);

            /* Affichage attendu:
             * t
             * 8
             * Il fait beau aujourd'hui 
            */
        }
    }
}