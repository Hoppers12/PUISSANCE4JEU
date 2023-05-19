using System;

public class Program
{
    #region Puissance4
    public class Puissance4
    {
        #region définition des attributs
        private Joueur J1;
        private Joueur J2;
        public int[,] grille1 = new int[6, 7];
        public int[,] grille2 = new int[5, 6];
        public int choixGrille; // 1 = grille 1 ; 2 = grille 2 ; 0 = grille aleatoire
        private bool choixMode; // true = JVJ ; false = JVIA ;
        public int gagnant;    // 1 = J1; 2 = J2; 0 = match nul
        public bool joueurSuivant; //True = J1 ; False = J2/IA
        private int limiteLigne;
        private int limiteColonne;
        #endregion

        #region constructeur
        //On initialise le plateau de jeu dans le constructeur
        public Puissance4(string prenom1, string prenom2, int choixG, bool mode)
        {
            choixGrille = choixG;
            choixMode = mode;
            if (choixGrille == 1)
            {

                limiteLigne = 6;
                limiteColonne = 7;
                initGrille(grille1); // Appel de la méthode qui initGrille qui créee la grille

            }
            else if (choixGrille == 2)
            {
                limiteLigne = 5;
                limiteColonne = 6;
                initGrille(grille2);
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
                    this.initGrille(grille1);
                }
                else
                {
                    limiteLigne = 5;
                    limiteColonne = 6;
                    this.initGrille(grille2);
                }
            }
            J1 = new Joueur(prenom1, true, true,limiteColonne);
            J2 = new Joueur(prenom2, false, choixMode,limiteColonne);
            joueurSuivant = true;
        }
        public void initGrille(int[,] grilleUtilisee)
        {
            for (int i = 0; i < limiteLigne; i++)
            {
                for (int j = 0; j < limiteColonne; j++)
                {
                    grilleUtilisee[i, j] = 0;           //On initalise chaque case à 0 (= case vide)
                }
            }
        }
        #endregion

        #region différents alignements
        
            #region horizontal
        // Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même ligne
        public bool AlignementHorizontal(int[,] grilleUtilisee, int colonneJoue)
        {
            int cptr_pion_aligne = 1, ligne = 0, colonne, valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleUtilisee[ligne, colonneJoue] == 0)
            {
                ligne++;
            }
            
            // Determine la valeur a chercher
            valeur = grilleUtilisee[ligne, colonneJoue];

            // Comptage du nombre de pion du même jouer alignés vers la gauche
            if(colonneJoue!=0)
            {
                for(colonne = colonneJoue-1 ; grilleUtilisee[ligne, colonne] == valeur && (colonne - 1) >= 0 ; colonne--)
                {
                    cptr_pion_aligne++;
                }
                if(colonne == 0 && grilleUtilisee[ligne, colonne] == valeur)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés vers la droite
            if(colonneJoue!=limiteColonne-1)
            {
                for(colonne = colonneJoue+1 ; grilleUtilisee[ligne, colonne] == valeur && (colonne + 1) < limiteColonne ; colonne++)
                {
                    cptr_pion_aligne++;
                }
                if(colonne == limiteColonne -1 && grilleUtilisee[ligne, colonne] == valeur)
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
            #endregion
            
            #region vertical
        // Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même colonne "colonneJoue"
        public bool AlignementVertical(int[,] grilleUtilisee, int colonneJoue)
        {
            int cptr_pion_aligne = 1, ligne = 0, valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleUtilisee[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleUtilisee[ligne, colonneJoue];
            
            // Comptage du nombre de pion du même jouer alignés
            if(ligne < limiteLigne - 3)
            {
                for(ligne = ligne + 1; grilleUtilisee[ligne, colonneJoue] == valeur && (ligne + 1) < limiteLigne ; ligne++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonneJoue] == valeur && ligne == limiteLigne - 1)
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
            #endregion
            
            #region diagonal croissant
        // Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même diagonale
        public bool AlignementDiagonalCroissant(int[,] grilleUtilisee, int colonneJoue)
        {
            int cptr_pion_aligne = 1, stockLigne, ligne = 0, colonne, valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleUtilisee[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleUtilisee[ligne, colonneJoue];
            stockLigne = ligne;
            

            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if(colonneJoue != 0 && ligne != limiteLigne - 1)
            {
                for (ligne = ligne + 1, colonne = colonneJoue - 1 ; grilleUtilisee[ligne, colonne] == valeur && (colonne - 1) >= 0 && (ligne + 1) < limiteLigne ; ligne ++ , colonne --)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == limiteLigne - 1 || colonne == 0))
                {
                    cptr_pion_aligne++;
                }
            }
            
            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if(colonneJoue != limiteColonne - 1 && stockLigne != 0)
            {
                for (ligne = stockLigne - 1, colonne = colonneJoue + 1 ; grilleUtilisee[ligne, colonne] == valeur && (colonne + 1) < limiteColonne && (ligne - 1) >= 0 ; ligne -- , colonne ++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == 0 || colonne == limiteColonne - 1))
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
            #endregion
            
            #region diagonal decroissant
        // Méthode qui vérifie si 4 jetons d'un même joueur sont alignés dans une même diagonale
        public bool AlignementDiagonalDecroissant(int[,] grilleUtilisee, int colonneJoue)
        {
            int cptr_pion_aligne = 1, stockLigne, ligne = 0, colonne = colonneJoue, valeur;
            bool quatreAligne = false;

            // Recherche d'un pion dans la colonne 
            while (grilleUtilisee[ligne, colonneJoue] == 0)
            {
                ligne++;
            }

            // Determine la valeur a chercher
            valeur = grilleUtilisee[ligne, colonneJoue];
            stockLigne = ligne;
            

            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if(colonneJoue != 0 && ligne != 0)
            {
                for (ligne = ligne - 1, colonne = colonneJoue - 1 ; grilleUtilisee[ligne, colonne] == valeur && (colonne - 1) >= 0 && (ligne - 1) >= 0 ; ligne -- , colonne --)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == 0 || colonne == 0))
                {
                    cptr_pion_aligne++;
                }
            }
            
            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if(colonneJoue != limiteColonne - 1 && stockLigne != limiteLigne - 1)
            {
                for (ligne = stockLigne + 1, colonne = colonneJoue + 1 ; grilleUtilisee[ligne, colonne] == valeur && (colonne + 1) < limiteColonne && (ligne + 1) < limiteLigne ; ligne ++ , colonne ++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == limiteLigne - 1 || colonne == limiteColonne - 1))
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
            #endregion
        #endregion

        #region grille complete
        public bool GrilleComplete(int[,] grilleUtilisee)
        {
            bool complet = false;
            int case_ligne1_occupe = 0;

            for (int j = 0; j < limiteColonne; j++)
            {  // On vérifie si toutes les cases de la ligne la + haute son comblées
                if (grilleUtilisee[0, j] != 0)
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
        #endregion

        #region vérification de la victoire
        public bool Victoire(int[,] grilleUtilisee, int colonneJoue)
        {
            bool resultat = false;
            if (AlignementHorizontal(grilleUtilisee, colonneJoue) || AlignementVertical(grilleUtilisee, colonneJoue) || AlignementDiagonalCroissant(grilleUtilisee, colonneJoue) || AlignementDiagonalDecroissant(grilleUtilisee, colonneJoue))
            {
                resultat = true;
                if (gagnant == 1)
                {
                    Console.WriteLine(" ");                         // J1 vainqueur
                    Console.WriteLine(J1.pseudo + " a gagne la partie");
                }
                else if (gagnant == 2)
                {
                    Console.WriteLine(" ");                         // J2/IA vainqueur
                    Console.WriteLine(J2.pseudo + " a gagne la partie");
                }

            }
            else if (GrilleComplete(grilleUtilisee))
            {
                Console.WriteLine(" ");                             // Egalité 
                Console.WriteLine("Match nul (Grille pleine) ");
            }
            return resultat;
        }
        #endregion

        #region affichage de la grille
        // Fonction qui affiche la grille dans la console
        public void AfficheGrille(int[,] grilleUtilisee)
        {
            for (int i = 0; i < limiteLigne; i++) // 0 à 6 lignes (donc 7)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < limiteColonne; j++)
                {
                    Console.Write(grilleUtilisee[i, j] + " ");
                }
            }
        }
        #endregion

        #region jouer un pion
        public void JouerPionDansGrille(int[,] grilleUtilisee, int indColonneJoue)
        {
            int ligne = 0;

            // Si colonne choisie valide (pas pleine + existante)
            if (indColonneJoue < limiteColonne && indColonneJoue >= 0 && grilleUtilisee[0, indColonneJoue] == 0)
            {
                while ((ligne + 1) < limiteLigne && grilleUtilisee[ligne + 1, indColonneJoue] == 0)
                {
                    ligne++;  // On remplie une case si l'une d'elle est disponible ET si celle d'aprés est déjà comblée
                }
                if (joueurSuivant == true)
                {
                    grilleUtilisee[ligne, indColonneJoue] = 1; //Remplissage de la case pour joueur 1 
                    joueurSuivant = false;    //change le joueur qui joue 
                    this.AfficheGrille(grilleUtilisee);
                    Console.WriteLine("");
                }
                else
                {
                    grilleUtilisee[ligne, indColonneJoue] = 2;  //Remplissage de la case pour joueur 2
                    joueurSuivant = true;   //change le joueur qui joue 
                    this.AfficheGrille(grilleUtilisee);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Impossible de placer un pion dans cette colonne");

            }
        }

        // Méthode appelé lorsque un joueur souhaite poser un pion dans une colonne
        public void JouerTour(int colonne)
        {
            colonne = colonne - 1; // On retire 1 car colonne 1 son indice = 0 ...

            if (choixGrille == 1)
            {
                this.JouerPionDansGrille(grille1, colonne);
            }
            else
            {
                this.JouerPionDansGrille(grille2, colonne);
            }
        }
        #endregion 
        
        #region jeu
        // Méthode du déroulement du jeu et qui s'arrête en temps voulu
        public void Jeu()
        {
            int [,] grilleJouee;
            int colonneJouee;
            bool abandon=false;
        
            if (choixGrille == 1)
            {
                grilleJouee=grille1;
            }
            else
            {
                grilleJouee=grille2;
            }
        
            do
            {
                
                if(this.joueurSuivant)
                {
                    Console.WriteLine("Au tour de " + J1.pseudo + '.');
                    colonneJouee = J1.ChoixColonne(this);
                }
                else
                {
                    Console.WriteLine("Au tour de " + J2.pseudo + '.');
                    colonneJouee = J2.ChoixColonne(this);
                }
                if(colonneJouee!=-1)
                {
                    JouerTour(colonneJouee);
                }
                else
                {
                    abandon=true;
                }
                
            }while(!abandon && !this.Victoire(grilleJouee,colonneJouee-1) && !GrilleComplete(grilleJouee));
        }
        #endregion
    }
    #endregion
    
    #region Joueur
    public class Joueur
    {
        #region définition des attributs
        public string pseudo;
        public bool couleurPion;       // true=rouge; false= bleu  
        public bool type;      // true=Joueur; false=IA
        private int nbreColonnes;
        private int nbreLignes;
        private int [] tabPointsCoupIA;
        #endregion

        #region constructeur
        public Joueur(string pseudoJoueur, bool couleur, bool typeJoueur, int nbColonnes)
        {
            pseudo = pseudoJoueur;
            couleurPion = couleur;
            type = typeJoueur;
            nbreColonnes=nbColonnes;
            if (nbreColonnes==7)
                nbreLignes=6;
            else 
                nbreLignes=5;
            tabPointsCoupIA = new int [nbreColonnes];
        }
        #endregion
        
        #region déterminer le coup à faire
            #region pour joueur
        public int ChoixColonne(Puissance4 jeu)
        {
            int coupJoué;
            if (type)
            {
                Console.WriteLine("Rentrez la colonne dans laquelle vous voulez jouer.");
                Console.WriteLine("(Veuillez rentrer -1 si abandon)");
                coupJoué=Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                coupJoué=CoupIA(jeu);
            }
            return coupJoué;
        }
            #endregion
            #region pour IA
                #region attribution des points aux différents coups
                
        public int CoupIA(Puissance4 jeu)
        {
            int i,j,colonneJoueeIA = 1,alignementIA=0;
            int [,] grilleJeu;
            if (jeu.choixGrille==1)
                grilleJeu = jeu.grille1;
            else 
                grilleJeu = jeu.grille2;
            
            for (i=0;i<nbreColonnes;i++)
            {
                for (j = nbreLignes - 1 ; j>=0 && grilleJeu[j,i] != 0 ; j--);
                
                if(grilleJeu[0,i]!=0)
                    tabPointsCoupIA[i]=-200;
                else{
                    alignementIA=determineAlignementsIA(jeu,i,j);
                    switch(alignementIA)
                    {
                    case 4:
                        tabPointsCoupIA[i]=200;
                        break;
                    case -1:
                        tabPointsCoupIA[i]=150;
                        break;
                    case 3:
                        tabPointsCoupIA[i]=100;
                        break;
                    case 2:
                        tabPointsCoupIA[i]=50;
                        break;
                    default:
                        tabPointsCoupIA[i]=0;
                        break;
                    }
                }
                
                Console.WriteLine(' ');
                if(alignementIA<tabPointsCoupIA[i])
                {
                    alignementIA = tabPointsCoupIA[i];
                    colonneJoueeIA = i+1;
                }
                else if (alignementIA == tabPointsCoupIA[i])
                {
                    Random aleatoire = new Random();
                    int coup = aleatoire.Next(1, 3);
                    if(coup == 2)
                    {
                        colonneJoueeIA = i+1;
                    }
                }
            }
            return colonneJoueeIA;
        }
                #endregion
                #region alignements possibles par l'IA 
                
        public int alignementsIAHorizontal(int [,] grilleJeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1,i;

            // Comptage du nombre de pion de l'IA alignés vers la gauche
            if(colonne!=0)
            {
                for(i = colonne-1 ; i >= 0 && grilleJeu[ligne, i] == 2 ; i--)
                {
                    cptr_pion_aligne++;
                }
            }   

            // Comptage du nombre de pion de l'IA alignés vers la droite
            if(colonne!=nbreColonnes-1)
            {
                for(i = colonne+1 ; i < nbreColonnes && grilleJeu[ligne, i] == 2 ; i++)
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }
        
        public int alignementsIAVertical(int [,] grilleJeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1;
            
            // Comptage du nombre de pion du même jouer alignés
            if(ligne < nbreLignes - 3)
            {
                for(ligne = ligne + 1; grilleJeu[ligne, colonne] == 2 && (ligne + 1) < nbreLignes ; ligne++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleJeu[ligne, colonne] == 2 && ligne == nbreLignes - 1)
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }
        
        public int alignementsIADiagonalCroissant(int [,] grilleJeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1, stockLigne, stockColonne;

            stockLigne = ligne;
            

            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if(colonne != 0 && ligne != nbreLignes - 1)
            {
                for (ligne = ligne + 1, stockColonne = colonne - 1 ; grilleJeu[ligne, stockColonne] == 2 && (stockColonne - 1) >= 0 && (ligne + 1) < nbreLignes ; ligne ++ , stockColonne --)
                {
                    cptr_pion_aligne++;
                }
                if (grilleJeu[ligne, stockColonne] == 2 && (ligne == nbreLignes - 1 || stockColonne == 0))
                {
                    cptr_pion_aligne++;
                }
            }
            
            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if(colonne != nbreColonnes - 1 && stockLigne != 0)
            {
                for (ligne = stockLigne - 1, stockColonne = colonne + 1 ; grilleJeu[ligne, stockColonne] == 2 && (stockColonne + 1) < nbreColonnes && (ligne - 1) >= 0 ; ligne -- , stockColonne ++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleJeu[ligne, stockColonne] == 2 && (ligne == 0 || stockColonne == nbreColonnes - 1))
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }
        
        public int alignementsIADiagonalDecroissant(int [,] grilleJeu, int colonne, int ligne)
        {
            int cptr_pion_aligne = 1, stockLigne, stockColonne = colonne;
            
            stockLigne = ligne;
            

            // Comptage du nombre de pion du même jouer alignés diagonalement en bas a gauche
            if(colonne != 0 && ligne != 0)
            {
                for (ligne = ligne - 1, stockColonne = colonne - 1 ; grilleJeu[ligne, stockColonne] == 2 && (stockColonne - 1) >= 0 && (ligne - 1) >= 0 ; ligne -- , stockColonne --)
                {
                    cptr_pion_aligne++;
                }
                if (grilleJeu[ligne, stockColonne] == 2 && (ligne == 0 || stockColonne == 0))
                {
                    cptr_pion_aligne++;
                }
            }
            
            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if(colonne != nbreColonnes - 1 && stockLigne != nbreLignes - 1)
            {
                for (ligne = stockLigne + 1, stockColonne = colonne + 1 ; grilleJeu[ligne, stockColonne] == 2 && (stockColonne + 1) < nbreColonnes && (ligne + 1) < nbreLignes ; ligne ++ , stockColonne ++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleJeu[ligne, stockColonne] == 2 && (ligne == nbreLignes - 1 || stockColonne == nbreColonnes - 1))
                {
                    cptr_pion_aligne++;
                }
            }
            return cptr_pion_aligne;
        }
        
        public int determineAlignementsIA(Puissance4 jeu, int colonne, int ligne)
        {
            int valeur=0;
            int [,] grilleJeu;
            
            if (jeu.choixGrille==1)
                grilleJeu = jeu.grille1;
            else 
                grilleJeu = jeu.grille2;
                
            int maxAlignementIA=Math.Max(alignementsIAHorizontal(grilleJeu,colonne,ligne),Math.Max(alignementsIAVertical(grilleJeu,colonne,ligne),Math.Max(alignementsIADiagonalCroissant(grilleJeu,colonne,ligne),alignementsIADiagonalDecroissant(grilleJeu,colonne,ligne))));
                
            if (maxAlignementIA>=4)
                valeur = 4;
            else
            {
                grilleJeu[ligne,colonne]=1;
                
                if (jeu.Victoire(grilleJeu,colonne))
                    valeur = -1;
                grilleJeu[ligne,colonne]=0;
                if(valeur != -1)
                {
                    valeur = maxAlignementIA;
                }
            }
            return valeur;
        }
            #endregion
            #endregion
        #endregion
    }
    #endregion

    #region Main
    // MAIN
    private static void Main(string[] args)
    {

        Puissance4 jeu = new Puissance4("Joueur 1", "Joueur 2", 1, false);

        Console.WriteLine(" ");
        
        jeu.Jeu();

    }
    #endregion
}







