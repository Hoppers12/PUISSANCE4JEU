using System;

public class Program
{
    class Puissance4
    {
        private string pseudo1;
        private string pseudo2;
        private int[,] grille1 = new int[7,6];
        private int[,] grille2 = new int[6,5];
        private int choixGrille; // 1 = grille 1 ; 2 = grille 2
        private bool choixMode; // true = JVJ ; false = JVIA ;
        private int gagnant;

        //On initialise le plateau de jeu dans le constructeur
        public Puissance4(string prenom1, string prenom2, int choixG, bool Mode)
        {
            pseudo1 = prenom1 ;
            pseudo2 = prenom2 ; 
            choixGrille = choixG ;
            choixMode = Mode ;

            if (choixGrille == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j<6 ; j++) {
                        grille1[i,j] = 0;           //On initalise chaque case à 0 (= case vide)
                    }

                }
            }
            else if (choixGrille == 2)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j<5 ; j++) {
                        grille2[i,j] = 0;           //On initalise chaque case à 0 (= case vide)
                    }

                }
            }
        }
 
        // Fonction qui affiche la grille dans la console
        
        //Affichage grille 7 x 6 (1 = PION J1 ; 0 = CASE VIDE ; 2 = PION J2)
        
        public void AfficheGrille () 
        {
            if(choixGrille == 1) 
            {
                for (int i = 0 ; i<=6 ; i++) // 0 à 6 lignes (donc 7)
                {
                    Console.WriteLine(" ") ;
                    for (int j = 0 ; j <= 5 ; j++) 
                    {
                        Console.Write(grille1[i,j] + " " );
                    }
                }    
                
        //Affichage grille 6 x 5
            }else if(choixGrille == 2) {
                for (int i = 0 ; i<=5 ; i++) 
                {
                    Console.WriteLine(" ") ;
                    for (int j = 0 ; j <= 4 ; j++) 
                    {
                        Console.Write(grille2[i,j] + " " );
                    }
                }  
            }
        }
        
        
        // Méthode appelé lorsque un joueur souhaite poser un pion dans une colonne
        public void jouer_pion(int colonne) {
            colonne = colonne - 1 ; // On retire 1 car colonne 1 son indice = 0 ...
            
            if (choixGrille == 1) {
                
                //Si le joueur a choisie une colonne qui existe (d'indices [0][0] à [6][5] max)
                if (colonne<= 5 && colonne >= 0 && grille1[0,colonne] == 0) {

                    int ligne = 0 ;
                    
                    while (ligne <= 6 && grille1[ligne,colonne] == 0 && (ligne+1) <= 6 && grille1[ligne+1,colonne] == 0 ) {
                        ligne ++ ;  // On remplie une case si l'une d'elle et disponible ET si celle d'aprés est déjà comblée
                    }
                    
                    grille1[ligne,colonne] = 1 ; //Remplissage de la case
                    this.AfficheGrille() ;
                    Console.WriteLine("");
                
                    
                } else {
                    Console.WriteLine("") ;
                    Console.WriteLine("Impossible de placer un pion dans cette colonne") ;
                }
                
            } else if (choixGrille == 2) {
                
                //Si le joueur a choisie une colonne qui existe (d'indices [0][0] à [5][4] max)
                if (colonne<= 4 && colonne >= 0 && grille2[0,colonne] == 0) {

                    int ligne = 0 ;
                    
                    while (ligne <= 5 && grille2[ligne,colonne] == 0 && (ligne+1) <= 5 && grille2[ligne+1,colonne] == 0 ) {
                        ligne ++ ;  // On remplie une case si l'une d'elle et disponible ET si celle d'aprés est déjà comblée
                    }
                    
                    grille2[ligne,colonne] = 2 ; //Remplissage de la case
                    this.AfficheGrille() ;
                    Console.WriteLine("") ;
                
                    
                } else {
                    Console.WriteLine("") ;
                    Console.WriteLine("Impossible de placer un pion dans cette colonne") ;
                }
            }
        }
        
        
        
        
    }
    
    // MAIN
    private static void Main(string[] args)
    {
        Puissance4 jeu = new Puissance4("Joueur 1", "Joueur 2", 2, true);
        
        jeu.AfficheGrille();
        Console.WriteLine(" ") ;
        jeu.jouer_pion(4) ;
        jeu.jouer_pion(4) ;
        jeu.jouer_pion(4) ;
        jeu.jouer_pion(4) ;

        
    }
}

