using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothèquePuissance4
{
    /// <summary>
    /// Classe du joueur (IA ou Humain)
    /// </summary>
    public class Joueur
    {
        /// <summary>
        /// Pseudo du joueur
        /// </summary>
        /// <example>
        /// "Luffy", "Raph" etc.
        /// </example>
        string pseudo;

        /// <summary>
        /// Couleur du pion du joueur
        /// </summary>
        /// <example>
        /// true (rouge) ou false (jaune)  
        /// </example>
        bool couleurPion;

        /// <summary>
        /// Type de joueur
        /// </summary>
        /// <example>
        /// true (Joueur) ou false (IA)
        /// </example>
        bool type;

        /// <summary>
        /// Le nombre de colonnes de la grille de jeu
        /// </summary>
        /// <example>
        /// 7 (si c'est la grille 6 x 7) ou 6 (si c'est la grille 5 x 6)
        /// </example>
        int nbreColonnes;

        /// <summary>
        /// Tableau où sont stockés les points correspondants aux coups de l'IA 
        /// </summary>
        /// <example>
        /// [200;50;150;0;0;50]
        /// </example>
        int[] tabPointsCoupIA;

        public string Pseudo { get => pseudo; }


        /// <summary>
        /// Constructeur qui initialise le jeu
        /// </summary>
        /// <param name="pseudoJoueur">Pseudo du joueur</param>
        /// <param name="couleur">Couleur du pion du joueur</param>
        /// <param name="typeJoueur">Type du jouer (IA ou humain)</param>
        /// <param name="nbColonnes">Nombre de colonnes dans la grille de jeu (pour créer le tableau de points de l'IA)</param>
        public Joueur(string pseudoJoueur, bool couleur, bool typeJoueur, int nbColonnes)
        {
            pseudo = pseudoJoueur;
            couleurPion = couleur;
            type = typeJoueur;
            nbreColonnes = nbColonnes;
            tabPointsCoupIA = new int[nbreColonnes];
        }



        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés horizontalement s'il posait son pion aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="indColonne">Indice de la colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="indLigne">Indice de la ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés horizontalement</returns>
        public int alignementsIAHorizontal(Puissance4 jeu, int indColonne, int indLigne)
        {
            int indColonneVisitee;
            int valeurPionIA = 2;
            int cptrPionsIaAlignes = 1;

            // Comptage du nombre de pion de l'IA alignés vers la gauche
            if (indColonne != 0)
            {
                for (indColonneVisitee = indColonne - 1; indColonneVisitee >= 0 
                    && jeu.GrilleJeu[indLigne, indColonneVisitee] == valeurPionIA; indColonneVisitee--)
                {
                    cptrPionsIaAlignes++;
                }
            }

            // Comptage du nombre de pion de l'IA alignés vers la droite
            if (indColonne != nbreColonnes - 1)
            {
                for (indColonneVisitee = indColonne + 1; indColonneVisitee < nbreColonnes 
                    && jeu.GrilleJeu[indLigne, indColonneVisitee] == valeurPionIA; indColonneVisitee++)
                {
                    cptrPionsIaAlignes++;
                }
            }

            return cptrPionsIaAlignes;
        }



        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés verticalement s'il posait son pion aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="colonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="ligne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés verticalement</returns>
        public int alignementsIAVertical(Puissance4 jeu, int indColonne, int indLigne)
        {
            int indLigneVisitee;
            int valeurPionIA = 2;
            int cptrPionsIaAlignes = 1;

            // Comptage du nombre de pion alignés verticalement que l'IA pourrait faire
            if (indLigne < jeu.LimiteLigne - 3)
            {
                for (indLigneVisitee = indLigne + 1; indLigneVisitee < jeu.LimiteLigne 
                    && jeu.GrilleJeu[indLigneVisitee, indColonne] == valeurPionIA; indLigneVisitee++)
                {
                    cptrPionsIaAlignes++;
                }
            }

            return cptrPionsIaAlignes;
        }



        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés sur la diagonale croissante s'il posait son pion aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="indColonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="indLigne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés sur la diagonale croissante</returns>
        public int alignementsIADiagonalCroissant(Puissance4 jeu, int indColonne, int indLigne)
        {
            int indLigneVisitee;
            int indColonneVisitee;
            int cptrPionsIaAlignes = 1;
            int valeurPionIA = 2;

            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (indColonne != 0 && indLigne != jeu.LimiteLigne - 1)
            {
                for (indLigneVisitee = indLigne + 1, indColonneVisitee = indColonne - 1;
                    indColonneVisitee >= 0 && indLigneVisitee < jeu.LimiteLigne 
                    && jeu.GrilleJeu[indLigneVisitee, indColonneVisitee] == valeurPionIA;
                    indLigneVisitee++, indColonneVisitee--)
                {
                    cptrPionsIaAlignes++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (indColonne != nbreColonnes - 1 && indLigne != 0)
            {
                for (indLigneVisitee = indLigne - 1, indColonneVisitee = indColonne + 1;
                    indColonneVisitee < nbreColonnes && indLigneVisitee >= 0
                    && jeu.GrilleJeu[indLigneVisitee, indColonneVisitee] == valeurPionIA;
                    indLigneVisitee--, indColonneVisitee++)
                {
                    cptrPionsIaAlignes++;
                }
            }

            return cptrPionsIaAlignes;
        }




        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés sur la diagonale décroissante s'il le posait aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="indColonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="indLigne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés sur la diagonale décroissante</returns>
        public int alignementsIADiagonalDecroissant(Puissance4 jeu, int indColonne, int indLigne)
        {
            int indLigneVisitee;
            int indColonneVisitee;
            int cptrPionsIaAlignes = 1;
            int valeurPionIA = 2;

            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (indColonne != 0 && indLigne != 0)
            {
                for (indLigneVisitee = indLigne - 1, indColonneVisitee = indColonne - 1;
                    indColonneVisitee >= 0 && indLigneVisitee >= 0 
                    && jeu.GrilleJeu[indLigneVisitee, indColonneVisitee] == valeurPionIA;
                    indLigneVisitee--, indColonneVisitee--)
                {
                    cptrPionsIaAlignes++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (indColonne != nbreColonnes - 1 && indLigne != jeu.LimiteLigne - 1)
            {
                for (indLigneVisitee = indLigne + 1, indColonneVisitee = indColonne + 1;
                    indColonneVisitee < nbreColonnes && indLigneVisitee < jeu.LimiteLigne 
                    && jeu.GrilleJeu[indLigneVisitee, indColonneVisitee] == valeurPionIA;
                    indLigneVisitee++, indColonneVisitee++)
                {
                    cptrPionsIaAlignes++;
                }
            }

            return cptrPionsIaAlignes;
        }


        /// <summary>
        /// Détermine et retourne le type de coup que l'IA va faire 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="indColonne">Indice de la colonne pour laquelle l'IA cherche à determiner le type de coup</param>
        /// <param name="indLigne">Indice de la ligne pour laquelle l'IA cherche à determiner le type de coup</param>
        /// <returns>LA valeur significative pour identifier le type de coup</returns>
        public int determineAlignementsIA(Puissance4 jeu, int indColonne, int indLigne)
        {
            int valeur = 0;

            //calcule l'alignement maximal que l'IA peut faire
            int maxAlignementIA = Math.Max(alignementsIAHorizontal(jeu, indColonne, indLigne), 
                Math.Max(alignementsIAVertical(jeu, indColonne, indLigne), 
                Math.Max(alignementsIADiagonalCroissant(jeu, indColonne, indLigne), 
                alignementsIADiagonalDecroissant(jeu, indColonne, indLigne))));

            //si l'IA peut gagner avec ce coup, on affecte à "valeur" 4
            if (maxAlignementIA >= 4)
                valeur = 4;
            //sinon
            else
            {
                //simule le joueur qui pose son pion ici et si c'est un coup gagnant, on affecte à "valeur" -1
                //sinon on le met à la valeur de l'alignement maximal
                jeu.GrilleJeu[indLigne, indColonne] = 1;
                jeu.AlignementHorizontal(indColonne);
                jeu.AlignementVertical(indColonne);
                jeu.AlignementDiagonalCroissant(indColonne);
                jeu.AlignementDiagonalDecroissant(indColonne);
                jeu.GrilleJeu[indLigne, indColonne] = 0;

                if (jeu.Gagnant == 1)
                {
                    valeur = -1;
                    jeu.Gagnant = -1;
                }
                else
                {
                    valeur = maxAlignementIA;
                }
            }

            return valeur;
        }



        /// <summary>
        /// Méthode qui détermine le coup que l'IA va faire
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <returns>La colonne dans laquelle l'IA va jouer</returns>
        public int CoupIA(Puissance4 jeu)
        {
            Random aleatoire = new Random();
            int indLigneCoupPossible;
            int colonneJoueeIA = 1;
            int maxPoints = -200;
            int alignementIA;
            int contrerVictoireJoueur;
            int choixCoupMemeScore;

            for (int indColonneScore = 0; indColonneScore < nbreColonnes; indColonneScore++)
            {
                //vérifie que la colonne n'est pas pleine mais si c'est le cas, met le score le plus bas
                if (jeu.GrilleJeu[0, indColonneScore] != 0)
                {
                    tabPointsCoupIA[indColonneScore] = -200;
                }
                //sinon il regarde quel type de coup c'est
                else
                {
                    //détermine la première ligne de la colonne de libre pour poser son pion 
                    for (indLigneCoupPossible = jeu.LimiteLigne - 1;
                    indLigneCoupPossible >= 0 && jeu.GrilleJeu[indLigneCoupPossible, indColonneScore] != 0;
                    indLigneCoupPossible--) ;

                    alignementIA = determineAlignementsIA(jeu, indColonneScore, indLigneCoupPossible);

                    //en fonction de la valeur retournée par la fonction "determineAlignementsIA",
                    //on définit le score
                    switch (alignementIA)
                    {
                        case 4:
                            tabPointsCoupIA[indColonneScore] = 200;
                            break;

                        case -1:
                            //L'IA va laisser le joueur jouer le coup gagnant 1 fois sur 5
                            contrerVictoireJoueur = aleatoire.Next(1, 6);

                            if (contrerVictoireJoueur != 1)
                                tabPointsCoupIA[indColonneScore] = 150;
                            else
                                tabPointsCoupIA[indColonneScore] = 0;

                            break;

                        case 3:
                            tabPointsCoupIA[indColonneScore] = 100;
                            break;

                        case 2:
                            tabPointsCoupIA[indColonneScore] = 50;
                            break;

                        default:
                            tabPointsCoupIA[indColonneScore] = 0;
                            break;  
                    }
                }

                //Va prendre le score le plus élevé qu'il rencontre et changer l'indice
                //de la colonne dans laquelle l'IA va jouer en accord
                if (maxPoints < tabPointsCoupIA[indColonneScore])
                {
                    maxPoints = tabPointsCoupIA[indColonneScore];
                    colonneJoueeIA = indColonneScore + 1;
                }
                //Mais si le score retenu et celui affecté pour cette case sont égales,
                //il tire au sort pour savoir laquelle des deux jouer
                else if (maxPoints == tabPointsCoupIA[indColonneScore])
                {
                    choixCoupMemeScore = aleatoire.Next(1, 3);

                    if (choixCoupMemeScore == 2)
                    {
                        colonneJoueeIA = indColonneScore + 1;
                    }
                }

            }

            return colonneJoueeIA;
        }
 
    }
}
