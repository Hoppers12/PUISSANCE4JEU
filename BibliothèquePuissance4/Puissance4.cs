namespace BibliothèquePuissance4
{
    /// <summary>
    /// Classe qui définit une partie de puissance 4
    /// </summary>
    public class Puissance4
    {
        /// <summary>
        /// Joueur 1 de type Joueur
        /// </summary>
        Joueur j1;

        /// <summary>
        /// Joueur 2 de type Joueur
        /// </summary>
        Joueur j2;

        /// <summary>
        /// Grille du jeu (tableau bidimentionnel d'entiers)
        /// </summary>
        int[,] grilleJeu;

        /// <summary>
        /// Entier qui désigne le choix de la grille
        /// </summary>
        /// <example>
        /// 1 (grille 1) ou 2 (grille 2) ou 0 (grille aleatoire)
        /// </example>
        int choixGrille;

        /// <summary>
        /// Booléen qui désigne le choix du mode de jeu
        /// </summary>
        /// <example>
        /// true (JVJ) ou false (JVIA)
        /// </example>
        bool choixMode;

        /// <summary>
        /// Entier qui désigne le joueur gagnant
        /// </summary>
        /// <example>
        /// 1 (J1), 2 (J2), 0 (match nul) ou -1 (match toujours en cours)
        /// </example>
        int gagnant;

        /// <summary>
        /// Booléen qui désigne le joueur qui jouera le tour suivant
        /// </summary>
        /// <example>
        /// true (J1) ou false (J2/IA)
        /// </example>
        bool joueurSuivant;

        /// <summary>
        /// Nombre de lignes de la grille utilisée
        /// </summary>
        /// <example>
        /// 6 (si c'est la grille 6 x 7) ou 5 (si c'est la grille 5 x 6)
        /// </example>
        int limiteLigne;

        /// <summary>
        /// Nombre de colonnes de la grille utilisée
        /// </summary>
        /// <example>
        /// 7 (si c'est la grille 6 x 7) ou 6 (si c'est la grille 5 x 6)
        /// </example>
        int limiteColonne;

        public int[,] GrilleJeu { get => grilleJeu; set => grilleJeu = value; }
        public int LimiteLigne { get => limiteLigne; }
        public int ChoixGrille { get => choixGrille;}
        public int Gagnant { get => gagnant; set => gagnant = value; }
        public Joueur J1 { get => j1; }
        public Joueur J2 { get => j2;}
        public bool ChoixMode { get => choixMode; }
        public bool JoueurSuivant { set => joueurSuivant = value; }


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
            // Initialisation de la grille
            InitGrille(); 

            j1 = new Joueur(prenom1, true, true, limiteColonne);
            j2 = new Joueur(prenom2, false, choixMode, limiteColonne);
            gagnant = -1;
            joueurSuivant = true;
        }


        /// <summary>
        /// Méthode qui met toutes les cases de la grille à 0 (donc vide)
        /// </summary>
        public void InitGrille()
        {
            for (int indLigneRemplie = 0; indLigneRemplie < limiteLigne; indLigneRemplie++)
            {
                for (int indColonneRemplie = 0; indColonneRemplie < limiteColonne; indColonneRemplie++)
                {
                    grilleJeu[indLigneRemplie, indColonneRemplie] = 0;           
                }
            }
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même ligne
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        public void AlignementHorizontal(int colonneJoue)
        {
            int cptrPionJoueurAligne = 1;
            int ligneJouee;
            int colonneRecherche;
            int valeur;

            // Recherche d'un pion dans la colonne 
            for (ligneJouee = 0; grilleJeu[ligneJouee, colonneJoue] == 0; ligneJouee++) ;

            // Determine la valeur a chercher
            valeur = grilleJeu[ligneJouee, colonneJoue];

            // Comptage du nombre de pions du même jouer alignés à gauche
            if (colonneJoue != 0)
            {
                for (colonneRecherche = colonneJoue - 1; 
                    colonneRecherche >= 0 && grilleJeu[ligneJouee, colonneRecherche] == valeur;
                    colonneRecherche--)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Comptage du nombre de pions du même joueur alignés à droite
            if (colonneJoue != limiteColonne - 1)
            {
                for (colonneRecherche = colonneJoue + 1;
                    colonneRecherche < limiteColonne && grilleJeu[ligneJouee, colonneRecherche] == valeur;
                    colonneRecherche++)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Enregistrement du numéro du gagnant
            if (cptrPionJoueurAligne >= 4)
            {
                gagnant = valeur;
            }
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même colonne "colonneJoue"
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        public void AlignementVertical(int colonneJoue)
        {
            int cptrPionJoueurAligne = 1;
            int ligneJouee;
            int ligneRecherche;
            int valeur;

            // Recherche d'un pion dans la colonne 
            for (ligneJouee = 0; grilleJeu[ligneJouee, colonneJoue] == 0; ligneJouee++) ;

            // Determine la valeur a chercher
            valeur = grilleJeu[ligneJouee, colonneJoue];

            // Comptage du nombre de pion du même jouer alignés
            if (ligneJouee < limiteLigne - 3)
            {
                for (ligneRecherche = ligneJouee + 1;
                    ligneRecherche < limiteLigne && grilleJeu[ligneRecherche, colonneJoue] == valeur;
                    ligneRecherche++)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptrPionJoueurAligne >= 4)
            {
                gagnant = valeur;
            }
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même diagonale
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        public void AlignementDiagonalCroissant(int colonneJoue)
        {
            int cptrPionJoueurAligne = 1;
            int ligneJouee;
            int ligneRecherche;
            int colonneRecherche;
            int valeur;

            // Recherche d'un pion dans la colonne 
            for(ligneJouee = 0; grilleJeu[ligneJouee, colonneJoue] == 0; ligneJouee++) ;

            // Determine la valeur a chercher
            valeur = grilleJeu[ligneJouee, colonneJoue];


            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (colonneJoue != 0 && ligneJouee != limiteLigne - 1)
            {
                for (ligneRecherche = ligneJouee + 1, colonneRecherche = colonneJoue - 1;
                    colonneRecherche >= 0 && ligneRecherche < limiteLigne 
                    && grilleJeu[ligneRecherche, colonneRecherche] == valeur;
                    ligneRecherche++, colonneRecherche--)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonneJoue != limiteColonne - 1 && ligneJouee != 0)
            {
                for (ligneRecherche = ligneJouee - 1, colonneRecherche = colonneJoue + 1;
                    colonneRecherche < limiteColonne && ligneRecherche >= 0 
                    && grilleJeu[ligneRecherche, colonneRecherche] == valeur;
                    ligneRecherche--, colonneRecherche++)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptrPionJoueurAligne >= 4)
            {
                gagnant = valeur;
            }
        }


        /// <summary>
        /// Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même diagonale
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        public void AlignementDiagonalDecroissant(int colonneJoue)
        {
            int cptrPionJoueurAligne = 1;
            int ligneJouee;
            int ligneRecherche;
            int colonneRecherche;
            int valeur;

            // Recherche d'un pion dans la colonne 
            for (ligneJouee = 0; grilleJeu[ligneJouee, colonneJoue] == 0; ligneJouee++) ;

            // Determine la valeur a chercher
            valeur = grilleJeu[ligneJouee, colonneJoue];


            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if (colonneJoue != 0 && ligneJouee != 0)
            {
                for (ligneRecherche = ligneJouee - 1, colonneRecherche = colonneJoue - 1;
                    colonneRecherche >= 0 && ligneRecherche >= 0 
                    && grilleJeu[ligneRecherche, colonneRecherche] == valeur;
                    ligneRecherche--, colonneRecherche--)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonneJoue != limiteColonne - 1 && ligneJouee != limiteLigne - 1)
            {
                for (ligneRecherche = ligneJouee + 1, colonneRecherche = colonneJoue + 1;
                    colonneRecherche < limiteColonne && ligneRecherche < limiteLigne 
                    && grilleJeu[ligneRecherche, colonneRecherche] == valeur;
                    ligneRecherche++, colonneRecherche++)
                {
                    cptrPionJoueurAligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptrPionJoueurAligne >= 4)
            {
                gagnant = valeur;
            }

        }


        /// <summary>
        /// Méthode qui vérifie si la grille est totalement remplie
        /// </summary>
        public void GrilleComplete()
        {
            int nbColonnesComplete = 0;

            for (int indColonneVerifie = 0; indColonneVerifie < limiteColonne; indColonneVerifie++)
            {  // On vérifie si toutes les cases de la ligne la + haute son comblées
                if (grilleJeu[0, indColonneVerifie] != 0)
                {
                    nbColonnesComplete++;
                }
            }

            if (nbColonnesComplete == limiteColonne && gagnant == -1)
            { // Si c'est le cas et qu'il n'y a pas encore de gagnant, définit un match nul
                gagnant = 0;
            }
        }


        /// <summary>
        /// Méthode qui vérifie si un joueur a gagné
        /// </summary>
        /// <param name="colonneJoue">Colonne où le dernier pion a été posé</param>
        public void Victoire(int colonneJoue)
        {
            //détermine sur tous les axes s'il y a une victoire
             AlignementHorizontal(colonneJoue);
             AlignementVertical(colonneJoue);
             AlignementDiagonalCroissant(colonneJoue);
             AlignementDiagonalDecroissant(colonneJoue);
            //détermine si la grille est complete
             GrilleComplete();
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
        }


        /// <summary>
        /// Méthode du déroulement du jeu et qui s'arrête en temps voulu
        /// </summary>
        public void Jeu(int colonneJouee)
        {
            JouerPionDansGrille(colonneJouee - 1);
            Victoire(colonneJouee - 1);
        }
    }
}