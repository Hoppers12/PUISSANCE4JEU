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
        /// <param name="colonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="ligne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés horizontalement</returns>
        public int alignementsIAHorizontal(Puissance4 jeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1;
            int i;

            // Comptage du nombre de pion de l'IA alignés vers la gauche
            if (colonne != 0)
            {
                for (i = colonne - 1; i >= 0 && jeu.GrilleJeu[ligne, i] == 2; i--)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion de l'IA alignés vers la droite
            if (colonne != nbreColonnes - 1)
            {
                for (i = colonne + 1; i < nbreColonnes && jeu.GrilleJeu[ligne, i] == 2; i++)
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }



        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés verticalement s'il posait son pion aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="colonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="ligne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés verticalement</returns>
        public int alignementsIAVertical(Puissance4 jeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1;

            // Comptage du nombre de pion du même jouer alignés
            if (ligne < jeu.LimiteLigne - 3)
            {
                for (ligne = ligne + 1; ligne < jeu.LimiteLigne && jeu.GrilleJeu[ligne, colonne] == 2; ligne++)
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }



        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés sur la diagonale croissante s'il posait son pion aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="colonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="ligne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés sur la diagonale croissante</returns>
        public int alignementsIADiagonalCroissant(Puissance4 jeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1;
            int stockLigne = ligne;
            int stockColonne;



            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (colonne != 0 && ligne != jeu.LimiteLigne - 1)
            {
                for (ligne = ligne + 1, stockColonne = colonne - 1; stockColonne >= 0 && ligne < jeu.LimiteLigne && jeu.GrilleJeu[ligne, stockColonne] == 2; ligne++, stockColonne--)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonne != nbreColonnes - 1 && stockLigne != 0)
            {
                for (ligne = stockLigne - 1, stockColonne = colonne + 1; stockColonne < nbreColonnes && ligne >= 0 && jeu.GrilleJeu[ligne, stockColonne] == 2; ligne--, stockColonne++)
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }




        /// <summary>
        /// Méthode qui détermine combien de pions de l'IA seraient alignés sur la diagonale décroissante s'il le posait aux coordonnées rentrées en paramètre 
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="colonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="ligne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés sur la diagonale décroissante</returns>
        public int alignementsIADiagonalDecroissant(Puissance4 jeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1;
            int stockLigne = ligne;
            int stockColonne = colonne;


            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (colonne != 0 && ligne != 0)
            {
                for (ligne = ligne - 1, stockColonne = colonne - 1; stockColonne >= 0 && ligne >= 0 && jeu.GrilleJeu[ligne, stockColonne] == 2; ligne--, stockColonne--)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonne != nbreColonnes - 1 && stockLigne != jeu.LimiteLigne - 1)
            {
                for (ligne = stockLigne + 1, stockColonne = colonne + 1; stockColonne < nbreColonnes && ligne < jeu.LimiteLigne && jeu.GrilleJeu[ligne, stockColonne] == 2; ligne++, stockColonne++)
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }


        /// <summary>
        /// Détermine et retourne le nombre de pions maximum alignés si l’IA choisit de poser le pion aux coordonnées entrées en paramètre
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <param name="colonne">Colonne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <param name="ligne">Ligne pour laquelle l'IA cherche à determiner le nombre de pions alignés</param>
        /// <returns>Le nombre de pions alignés de l’IA dans la colonne dans laquelle l’IA va potentiellement jouer ou si le coup permettrait d'empêcher le joueur de gagner</returns>
        public int determineAlignementsIA(Puissance4 jeu, int colonne, int ligne)
        {
            int valeur = 0;

            int maxAlignementIA = Math.Max(alignementsIAHorizontal(jeu, colonne, ligne), Math.Max(alignementsIAVertical(jeu, colonne, ligne), Math.Max(alignementsIADiagonalCroissant(jeu, colonne, ligne), alignementsIADiagonalDecroissant(jeu, colonne, ligne))));

            if (maxAlignementIA >= 4)
                valeur = 4;
            else
            {
                jeu.GrilleJeu[ligne, colonne] = 1;
                jeu.AlignementHorizontal(colonne);
                jeu.AlignementVertical(colonne);
                jeu.AlignementDiagonalCroissant(colonne);
                jeu.AlignementDiagonalDecroissant(colonne);
                if (jeu.Gagnant == 1)
                {
                    valeur = -1;
                    jeu.Gagnant = -1;
                }             
                else
                    valeur = maxAlignementIA;
                jeu.GrilleJeu[ligne, colonne] = 0;

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
            int i;
            int j;
            int colonneJoueeIA = 1;
            int maxPoints = 0;
            int alignementIA = 0;
            for (i = 0; i < nbreColonnes; i++)
            {
                for (j = jeu.LimiteLigne - 1; j >= 0 && jeu.GrilleJeu[j, i] != 0; j--) ;

                if (jeu.GrilleJeu[0, i] != 0)
                    tabPointsCoupIA[i] = -200;
                else
                {
                    alignementIA = determineAlignementsIA(jeu, i, j);
                    switch (alignementIA)
                    {
                        case 4:
                            tabPointsCoupIA[i] = 200;
                            break;
                        case -1:
                            Random aleatoire = new Random();
                            int contrer = aleatoire.Next(1, 3);
                            if (contrer == 1)
                                tabPointsCoupIA[i] = 150;
                            else
                                tabPointsCoupIA[i] = 0;
                            break;
                        case 3:
                            tabPointsCoupIA[i] = 100;
                            break;
                        case 2:
                            tabPointsCoupIA[i] = 50;
                            break;
                        default:
                            tabPointsCoupIA[i] = 0;
                            break;
                    }
                }
                if (maxPoints < tabPointsCoupIA[i])
                {
                    maxPoints = tabPointsCoupIA[i];
                    colonneJoueeIA = i + 1;
                }
                else if (maxPoints == tabPointsCoupIA[i])
                {
                    Random aleatoire = new Random();
                    int coup = aleatoire.Next(1, 3);
                    if (coup == 2)
                    {
                        colonneJoueeIA = i + 1;
                    }
                }
            }
            return colonneJoueeIA;
        }
 
    }
}
