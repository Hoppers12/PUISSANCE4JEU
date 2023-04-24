using System;

public class Program
{
    public class Joueur
    {
        public string pseudo;
        public bool couleurPion;       // true=rouge; false= bleu  
        public bool type;      // true=Joueur; false=IA


        public Joueur(string pseudoJoueur, bool couleur, bool typeJoueur)
        {
            pseudo = pseudoJoueur;
            couleurPion = couleur;
            type = typeJoueur;
        }

        public int ChoixColonne(int limiteDeColonne)
        {
            int coupJoué;
            if (type)
            {
                Console.WriteLine("Rentrez la colonne dans la quelle vous voulez jouer.");
                Console.WriteLine("(Veuillez rentrer -1 si abandon)");
                coupJoué = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Random aleatoire = new Random();
                coupJoué = aleatoire.Next(1, limiteDeColonne + 1);
            }
            return coupJoué;
        }
    }



    public class Puissance4
    {
        private Joueur J1;
        private Joueur J2;
        public int[,] grille1 = new int[6, 7];
        public int[,] grille2 = new int[5, 6];
        public int choixGrille; // 1 = grille 1 ; 2 = grille 2 ; 0 = grille aleatoire
        private bool choixMode; // true = JVJ ; false = JVIA ;
        public int gagnant;    // 1 = J1; 2 = J2; 0 = match nul
        private bool joueurSuivant; //True = J1 ; False = J2/IA
        private int limiteLigne;
        private int limiteColonne;

        //On initialise le plateau de jeu dans le constructeur
        public Puissance4(string prenom1, string prenom2, int choixG, bool mode)
        {
            choixGrille = choixG;
            choixMode = mode;
            J1 = new Joueur(prenom1, true, true);
            J2 = new Joueur(prenom2, false, choixMode);
            joueurSuivant = true;
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
            gagnant = -1;
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
            if (colonneJoue != 0)
            {

                for (colonne = colonneJoue - 1; grilleUtilisee[ligne, colonne] == valeur && (colonne - 1) >= 0; colonne--)
                {
                    cptr_pion_aligne++;
                }
                if (colonne == 0 && grilleUtilisee[ligne, colonne] == valeur)
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés vers la droite
            if (colonneJoue != limiteColonne - 1)

            {
                for (colonne = colonneJoue + 1; grilleUtilisee[ligne, colonne] == valeur && (colonne + 1) < limiteColonne; colonne++)
                {
                    cptr_pion_aligne++;
                }
                if (colonne == limiteColonne - 1 && grilleUtilisee[ligne, colonne] == valeur)
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
            if (ligne < limiteLigne - 3)
            {
                for (ligne = ligne + 1; grilleUtilisee[ligne, colonneJoue] == valeur && (ligne + 1) < limiteLigne; ligne++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonneJoue] == valeur && ligne == limiteLigne - 1)
                {
                    cptr_pion_aligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptr_pion_aligne == 4)
            {
                quatreAligne = true;
                gagnant = valeur;
            }

            return quatreAligne;
        }


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
            if (colonneJoue != 0 && ligne != limiteLigne - 1)
            {

                for (ligne = ligne + 1, colonne = colonneJoue - 1; grilleUtilisee[ligne, colonne] == valeur && (colonne - 1) >= 0 && (ligne + 1) < limiteLigne; ligne++, colonne--)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == limiteLigne - 1 || colonne == 0))
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonneJoue != limiteColonne - 1 && stockLigne != 0)

            {
                for (ligne = stockLigne - 1, colonne = colonneJoue + 1; grilleUtilisee[ligne, colonne] == valeur && (colonne + 1) < limiteColonne && (ligne - 1) >= 0; ligne--, colonne++)
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

            if (colonneJoue != 0 && ligne != 0)

            {
                for (ligne = ligne - 1, colonne = colonneJoue - 1; grilleUtilisee[ligne, colonne] == valeur && (colonne - 1) >= 0 && (ligne - 1) >= 0; ligne--, colonne--)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == 0 || colonne == 0))
                {
                    cptr_pion_aligne++;
                }
            }

            // Comptage du nombre de pion du même joueur alignés diagonalement en haut a droite
            if (colonneJoue != limiteColonne - 1 && stockLigne != limiteLigne - 1)
            {
                for (ligne = stockLigne + 1, colonne = colonneJoue + 1; grilleUtilisee[ligne, colonne] == valeur && (colonne + 1) < limiteColonne && (ligne + 1) < limiteLigne; ligne++, colonne++)
                {
                    cptr_pion_aligne++;
                }
                if (grilleUtilisee[ligne, colonne] == valeur && (ligne == limiteLigne - 1 || colonne == limiteColonne - 1))
                {
                    cptr_pion_aligne++;
                }
            }

            // Enregistrement du numéro du gagnant 
            if (cptr_pion_aligne == 4)
            {
                quatreAligne = true;
                gagnant = valeur;
            }

            return quatreAligne;
        }



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

        // Méthode du déroulement du jeu et qui s'arrête en temps voulu
        public void Jeu()
        {
            int[,] grilleJouee;
            int colonneJouee;
            bool abandon = false;

            if (choixGrille == 1)
            {
                grilleJouee = grille1;
            }
            else
            {
                grilleJouee = grille2;
            }

            do
            {

                if (this.joueurSuivant)
                {
                    Console.WriteLine("Au tour de " + J1.pseudo + '.');
                    colonneJouee = J1.ChoixColonne(limiteColonne);
                }
                else
                {
                    Console.WriteLine("Au tour de " + J2.pseudo + '.');
                    colonneJouee = J2.ChoixColonne(limiteColonne);
                }
                if (colonneJouee != -1)
                {
                    JouerTour(colonneJouee);
                }
                else
                {
                    abandon = true;
                }

            } while (!abandon && !this.Victoire(grilleJouee, colonneJouee - 1) && !GrilleComplete(grilleJouee));
        }
    }




    // MAIN
    private static void Main(string[] args)
    {

        Puissance4 jeu = new Puissance4("Joueur 1", "Joueur 2", 1, true);


        jeu.Jeu();
        //test AlignementHorizontal (droite vers gauche) OK
        //jeu.JouerTour(1);jeu.JouerTour(1);jeu.JouerTour(2);jeu.JouerTour(2);jeu.JouerTour(3);jeu.JouerTour(3);jeu.JouerTour(4);jeu.JouerTour(4);

        //Test alignementHorizontal (gauche vers droite PAS COLLE A DROITE) OK
        //jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(3);

        //Test alignement horizontal vers la droite collée à droite OK
        //jeu.JouerTour(7) ;jeu.JouerTour(1) ;jeu.JouerTour(6) ;jeu.JouerTour(6) ;jeu.JouerTour(5) ;jeu.JouerTour(5) ;jeu.JouerTour(4) ;

        //Tester horizontal haut droite OK
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(4); jeu.JouerTour(1); jeu.JouerTour(5); jeu.JouerTour(2); jeu.JouerTour(6); jeu.JouerTour(3); jeu.JouerTour(7);

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Test alignement vertical OK
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(1);

        //Tester vertical milieu OK
        //jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(2);

        //Tester vertical haut droite OK
        //jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(5); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7);//jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(5); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7);

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Diagonale croissante qui commence en haut à droite OK

        //jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(7);
        //jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6);
        //jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(4); jeu.JouerTour(5);
        //jeu.JouerTour(4); jeu.JouerTour(4);

        //test AlignementDiagonalCroissant milieu OK
        //jeu.JouerTour(5);jeu.JouerTour(2);jeu.JouerTour(2);jeu.JouerTour(3);jeu.JouerTour(3);jeu.JouerTour(4);
        //jeu.JouerTour(3);jeu.JouerTour(4);jeu.JouerTour(4);jeu.JouerTour(2);jeu.JouerTour(4);jeu.JouerTour(5);jeu.JouerTour(5);jeu.JouerTour(5);jeu.JouerTour(5);

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Diagonal décroissante qui finie en haut à droite OK
        //jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(4);
        //jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5);
        //jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(1); jeu.JouerTour(6);
        //jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(1);  jeu.JouerTour(7);

        /*test AlignementDiagonalDecroissant en bas milieu*/
        //jeu.JouerTour(5); jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(3); jeu.JouerTour(3); jeu.JouerTour(2);
        //jeu.JouerTour(3); jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(2);





        //Test alignementHorizontal (gauche vers droite PAS COLLE A DROITE) OK
        //jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(3);

        //Test alignement vertical OK
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(1);


        //Test alignement horizontal vers la droite collée à droite OK

        //jeu.JouerTour(7) ;jeu.JouerTour(1) ;jeu.JouerTour(6) ;jeu.JouerTour(6) ;jeu.JouerTour(5) ;jeu.JouerTour(5) ;jeu.JouerTour(4) ;

        // IL RESTE A TESTER LES DIAGONALES

        //Diagonale croissante qui commence en haut à droite OK
        /*
        jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(7);
        jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6);
        jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(4); jeu.JouerTour(5);
        jeu.JouerTour(4); jeu.JouerTour(4); */


        //Diagonal décroissante qui finie en haut à droite OK
        //jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(4);
        //jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5);
        //jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(1); jeu.JouerTour(6);
        //jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(1);  jeu.JouerTour(7);


        //Tester horizontal haut droite OK
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(1); jeu.JouerTour(2); jeu.JouerTour(3); jeu.JouerTour(4); jeu.JouerTour(5); jeu.JouerTour(6); jeu.JouerTour(7);
        //jeu.JouerTour(4); jeu.JouerTour(1); jeu.JouerTour(5); jeu.JouerTour(2); jeu.JouerTour(6); jeu.JouerTour(3); jeu.JouerTour(7);

        //Tester vertical haut droite OK
        //jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(5); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7);
        jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7); jeu.JouerTour(5); jeu.JouerTour(7); jeu.JouerTour(6); jeu.JouerTour(7);
        jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(6); jeu.JouerTour(7);
        jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5); jeu.JouerTour(5);
        jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(4); jeu.JouerTour(5);
        jeu.JouerTour(3); jeu.JouerTour(3); jeu.JouerTour(3); jeu.JouerTour(3); jeu.JouerTour(3); jeu.JouerTour(5); jeu.JouerTour(5);
        jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(2); jeu.JouerTour(5);
        jeu.JouerTour(1); jeu.JouerTour(1); jeu.JouerTour(1); jeu.JouerTour(1); jeu.JouerTour(1); jeu.JouerTour(1); jeu.JouerTour(3);

    }
}



