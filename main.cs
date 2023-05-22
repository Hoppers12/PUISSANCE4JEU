using System;

public class Program
{
    /// <summary>
    /// Classe qui définit une partie de puissance 4
    ///
    /// J1 -> Joueur 1 de type Joueur
    /// J2 -> Joueur 2 de type Joueur
    /// grilleJeu -> Grille du jeu (tableau bidimentionnel d'entiers)
    /// choixGrille -> Entier qui désigne le choix de la grille (1 = grille 1 ; 2 = grille 2 ; 0 = grille aleatoire)
    /// choixMode -> Booléen qui désigne le choix du mode de jeu (true = JVJ; false = JVIA)
    /// gagnant -> Entier qui désigne le joueur gagnant (1 = J1; 2 = J2; 0 = match nul)
    /// joueurSuivant -> Booléen qui désigne le joueur qui jouera le tour suivant (True = J1 ; False = J2/IA)
    /// limiteLigne -> Nombre de lignes de la grille utilisée
    /// limiteColonne -> Nombre de colonnes de la grille utilisée
    ///
    /// </summary>
    public class Puissance4
    {
        Joueur J1;
        Joueur J2;
        int[,] grilleJeu;
        int choixGrille;
        bool choixMode;
        int gagnant;
        bool joueurSuivant;
        int limiteLigne;
        int limiteColonne;

        public int[,] GrilleJeu { get => grilleJeu; set => grilleJeu = value; }
        public int LimiteLigne { get => limiteLigne; }


        /// <summary>
        /// Constructeur qui initialise le jeu
        /// </summary>
        /// <param name="prenom1">Pseudo du joueur 1</param>
        /// <param name="prenom2">Pseudo du joueur 2</param>
        /// <param name="choixG">Grille choisie par les joueurs (soit 1, 2 ou aléatoire)</param>
        /// <param name="mode">Mode de jeu choisit (soit J vs IA soit J vs J)</param>
        public Puissance4(string prenom1, string prenom2, int choixG, bool mode)
        {
            choixGrille = choixG;
            choixMode = mode;
            if (choixGrille == 1)
            {
                limiteLigne = 6;
                limiteColonne = 7;
            }
            else if (choixGrille == 2)
            {
                limiteLigne = 5;
                limiteColonne = 6;
            }
            else
            {
                Random aleatoire = new Random();
                choixGrille = aleatoire.Next(1, 3);
                Console.WriteLine("");
                Console.WriteLine("La grille tiree aleatoirement est la grille " + choixGrille + ".");
                if (choixGrille == 1)
                {
                    limiteLigne = 6;
                    limiteColonne = 7;
                }
                else
                {
                    limiteLigne = 5;
                    limiteColonne = 6;
                }
            }
            grilleJeu = new int[limiteLigne, limiteColonne];
            for (int i = 0; i < limiteLigne; i++)
            {
                for (int j = 0; j < limiteColonne; j++)
                {
                    grilleJeu[i, j] = 0;           //On initalise chaque case à 0 (= case vide)
                }
            }
            J1 = new Joueur(prenom1, true, true, limiteColonne);
            J2 = new Joueur(prenom2, false, choixMode, limiteColonne);
            joueurSuivant = true;
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même ligne
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        /// <returns> Le booléen qui décrit si les 4 pions sont bien alignés</returns>
        public bool AlignementHorizontal(int colonneJoue)
        {
            int cptr_pion_aligne = 1;
            int ligne = 0;
            int colonne;
            int valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleJeu[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleJeu[ligne, colonneJoue];

            // Comptage du nombre de pion du même jouer alignés vers la gauche
            if (colonneJoue != 0)
            {
                for (colonne = colonneJoue - 1; colonne >= 0 && grilleJeu[ligne, colonne] == valeur; colonne--)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés vers la droite
            if (colonneJoue != limiteColonne - 1)
            {
                for (colonne = colonneJoue + 1; colonne < limiteColonne && grilleJeu[ligne, colonne] == valeur; colonne++)
                {
                    cptr_pion_aligne++;
                }
            }

            // Enregistrement du numéro du gagnant
            if (cptr_pion_aligne >= 4)
            {
                quatreAligne = true;
                gagnant = valeur;
            }

            return quatreAligne;
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même colonne "colonneJoue"
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        /// <returns>Le booléen qui décrit si les 4 pions sont bien alignés</returns>
        public bool AlignementVertical(int colonneJoue)
        {
            int cptr_pion_aligne = 1;
            int ligne = 0;
            int valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleJeu[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleJeu[ligne, colonneJoue];

            // Comptage du nombre de pion du même jouer alignés
            if (ligne < limiteLigne - 3)
            {
                for (ligne = ligne + 1; ligne < limiteLigne && grilleJeu[ligne, colonneJoue] == valeur; ligne++)
                {
                    cptr_pion_aligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptr_pion_aligne >= 4)
            {
                quatreAligne = true;
                gagnant = valeur;
            }

            return quatreAligne;
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même diagonale
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        /// <returns>Le booléen qui décrit si les 4 pions sont bien alignés</returns>
        public bool AlignementDiagonalCroissant(int colonneJoue)
        {
            int cptr_pion_aligne = 1;
            int stockLigne;
            int ligne = 0;
            int colonne;
            int valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleJeu[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleJeu[ligne, colonneJoue];
            stockLigne = ligne;


            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (colonneJoue != 0 && ligne != limiteLigne - 1)
            {
                for (ligne = ligne + 1, colonne = colonneJoue - 1; colonne >= 0 && ligne < limiteLigne && grilleJeu[ligne, colonne] == valeur; ligne++, colonne--)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonneJoue != limiteColonne - 1 && stockLigne != 0)
            {
                for (ligne = stockLigne - 1, colonne = colonneJoue + 1; colonne < limiteColonne && ligne >= 0 && grilleJeu[ligne, colonne] == valeur; ligne--, colonne++)
                {
                    cptr_pion_aligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptr_pion_aligne >= 4)
            {
                quatreAligne = true;
                gagnant = valeur;
            }

            return quatreAligne;
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même diagonale
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        /// <returns>Le booléen qui décrit si les 4 pions sont bien alignés</returns>
        public bool AlignementDiagonalDecroissant(int colonneJoue)
        {
            int cptr_pion_aligne = 1;
            int stockLigne;
            int ligne = 0;
            int colonne = colonneJoue;
            int valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleJeu[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleJeu[ligne, colonneJoue];
            stockLigne = ligne;


            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (colonneJoue != 0 && ligne != 0)
            {
                for (ligne = ligne - 1, colonne = colonneJoue - 1; colonne >= 0 && ligne >= 0 && grilleJeu[ligne, colonne] == valeur; ligne--, colonne--)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonneJoue != limiteColonne - 1 && stockLigne != limiteLigne - 1)
            {
                for (ligne = stockLigne + 1, colonne = colonneJoue + 1; colonne < limiteColonne && ligne < limiteLigne && grilleJeu[ligne, colonne] == valeur; ligne++, colonne++)
                {
                    cptr_pion_aligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptr_pion_aligne >= 4)
            {
                quatreAligne = true;
                gagnant = valeur;
            }

            return quatreAligne;
        }


        /// <summary>
        /// Méthode qui vérifie si la grille est totalement remplie
        /// </summary>
        /// <returns>Le booléen qui décrit si la grille est complète</returns>
        public bool GrilleComplete()
        {
            bool complet = false;
            int case_ligne1_occupe = 0;

            for (int j = 0; j < limiteColonne; j++)
            {  // On vérifie si toutes les cases de la ligne la + haute son comblées
                if (grilleJeu[0, j] != 0)
                {
                    case_ligne1_occupe++;
                }
            }
            if (case_ligne1_occupe == limiteColonne)
            { // Si oui alors la grille est complète
                complet = true;
            }
            gagnant = 0;
            return complet;
        }


        /// <summary>
        /// Méthode qui vérifie si un joueur a gagné
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        /// <returns>Le booléen qui décrit s'il y a une victoire</returns>
        public bool Victoire(int colonneJoue)
        {
            bool resultat = false;
            if (AlignementHorizontal(colonneJoue) || AlignementVertical(colonneJoue) || AlignementDiagonalCroissant(colonneJoue) || AlignementDiagonalDecroissant(colonneJoue))
            {
                resultat = true;
                if (gagnant == 1)
                {
                    Console.WriteLine(" ");                         // J1 vainqueur
                    Console.WriteLine(J1.Pseudo + " a gagne la partie");
                }
                else if (gagnant == 2)
                {
                    Console.WriteLine(" ");                         // J2/IA vainqueur
                    Console.WriteLine(J2.Pseudo + " a gagne la partie");
                }

            }
            else if (GrilleComplete())
            {
                Console.WriteLine(" ");                             // Egalité 
                Console.WriteLine("Match nul (Grille pleine) ");
            }
            return resultat;
        }



        /// <summary>
        /// Fonction qui affiche la grille dans la console
        /// </summary>
        public void AfficheGrille()
        {
            for (int i = 0; i < limiteLigne; i++) // 0 à 6 lignes (donc 7)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < limiteColonne; j++)
                {
                    Console.Write(grilleJeu[i, j] + " ");
                }
            }
        }


        /// <summary>
        /// Méthode qui pose un pion dans la grille
        /// </summary>
        /// <param name="indColonneJoue">L'indice de la colonne dans laquelle le pion est placé</param>
        public void JouerPionDansGrille(int indColonneJoue)
        {
            int ligne = 0;

            while ((ligne + 1) < limiteLigne && grilleJeu[ligne + 1, indColonneJoue] == 0)
            {
                ligne++;  // On remplie une case si l'une d'elle est disponible ET si celle d'aprés est déjà comblée
            }
            if (joueurSuivant == true)
            {
                grilleJeu[ligne, indColonneJoue] = 1; //Remplissage de la case pour joueur 1 
                joueurSuivant = false;    //change le joueur qui joue 
            }
            else
            {
                grilleJeu[ligne, indColonneJoue] = 2;  //Remplissage de la case pour joueur 2
                joueurSuivant = true;   //change le joueur qui joue 
            }
            AfficheGrille();
            Console.WriteLine("");
        }


        /// <summary>
        /// Teste pour voir si la pose d'un pion est possible et si c'est possible, il appelle la méthode JouerPionDansGrille
        /// </summary>
        /// <param name="colonne">Numéro de la colonne dans laquelle le joueur veut jouer (avant d'ête changé en indice)</param>
        public void JouerTour(int colonne)
        {
            colonne = colonne - 1; // On retire 1 car colonne 1 son indice = 0 ...

            if (colonne < limiteColonne && colonne >= 0 && grilleJeu[0, colonne] == 0)
            {
                JouerPionDansGrille(colonne);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Impossible de placer un pion dans cette colonne");

            }
        }


        /// <summary>
        /// Méthode du déroulement du jeu et qui s'arrête en temps voulu
        /// </summary>
        public void Jeu()
        {
            int colonneJouee;
            bool abandon = false;
            do
            {
                if (this.joueurSuivant)
                {
                    Console.WriteLine("Au tour de " + J1.Pseudo + '.');
                    colonneJouee = J1.ChoixColonne(this);
                }
                else
                {
                    Console.WriteLine("Au tour de " + J2.Pseudo + '.');
                    colonneJouee = J2.ChoixColonne(this);
                }
                if (colonneJouee != -1)
                {
                    JouerTour(colonneJouee);
                }
                else
                {
                    abandon = true;
                }

            } while (!abandon && !this.Victoire(colonneJouee - 1) && !GrilleComplete());
        }
    }

    /// <summary>
    /// Classe du joueur (IA ou Humain)
    /// </summary>
    public class Joueur
    {

        string pseudo;
        bool couleurPion;       // true=rouge; false= bleu  
        bool type;      // true=Joueur; false=IA
        int nbreColonnes;
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
                if (jeu.AlignementHorizontal(colonne) || jeu.AlignementVertical(colonne) || jeu.AlignementDiagonalCroissant(colonne) || jeu.AlignementDiagonalDecroissant(colonne))
                    valeur = -1;
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


        /// <summary>
        /// Méthode qui permet de choisir la colonne dans laquelle on veut poser un pion
        /// </summary>
        /// <param name="jeu">Puissance 4 dans lequel on joue</param>
        /// <returns>La colonne choisie</returns>
        public int ChoixColonne(Puissance4 jeu)
        {
            int coupJoué;
            if (type)
            {
                Console.WriteLine("Rentrez la colonne dans laquelle vous voulez jouer.");
                Console.WriteLine("(Veuillez rentrer -1 si abandon)");
                coupJoué = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                coupJoué = CoupIA(jeu);
            }
            return coupJoué;
        }
    }


    /// <summary>
    /// Fonction main
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {

        Puissance4 jeu = new Puissance4("Joueur 1", "Joueur 2", 1, false);

        Console.WriteLine(" ");

        jeu.Jeu();

    }

}
