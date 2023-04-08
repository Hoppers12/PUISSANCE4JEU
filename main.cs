using System;

public class Program
{
    class Joueur
    {
        public string pseudo;
        public bool couleurPion;       //true=rouge; false= bleu  
        public bool type;      // true=Joueur; false=IA
        
        public Joueur(string pseudoJoueur, bool couleur, bool typeJoueur)
        {
            pseudo = pseudoJoueur ;
            couleurPion = couleur ;
            type = typeJoueur ; 
        }
    }
    
    
    class Puissance4
    {
        private Joueur J1;
        private Joueur J2;
        private int[,] grille1 = new int[6,7];
        private int[,] grille2 = new int[5,6];
        private int choixGrille; // 1 = grille 1 ; 2 = grille 2 ; 0 = grille aleatoire
        private bool choixMode; // true = JVJ ; false = JVIA ;
        private int gagnant;    // 1 = J1; 2 = J2; 0 = match nul
        private bool joueurSuivant; //True = J1 ; False = J2/IA

        //On initialise le plateau de jeu dans le constructeur
        public Puissance4(string prenom1, string prenom2, int choixG, bool mode)
        {
            choixGrille = choixG ;
            choixMode = mode ;
            J1=new Joueur(prenom1,true,true);
            J2=new Joueur(prenom2,false,choixMode);
            joueurSuivant=true;
            if (choixGrille == 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j<7 ; j++) {
                        grille1[i,j] = 0;           //On initalise chaque case à 0 (= case vide)
                    }

                }
            }
            else if (choixGrille == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j<6 ; j++) {
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
                for (int i = 0 ; i<=5 ; i++) // 0 à 6 lignes (donc 7)
                {
                    Console.WriteLine(" ") ;
                    for (int j = 0 ; j <= 6 ; j++) 
                    {
                        Console.Write(grille1[i,j] + " " );
                    }
                }    
                
        //Affichage grille 6 x 5
            }else if(choixGrille == 2) {
                for (int i = 0 ; i<5 ; i++) 
                {
                    Console.WriteLine(" ") ;
                    for (int j = 0 ; j <6 ; j++) 
                    {
                        Console.Write(grille2[i,j] + " " );
                    }
                }  
            }
        }
        
        public void jouer_pion(int[,] grilleUtilisee, int limiteLigne, int limiteColonne, int indColonneJoue){
            int ligne = 0 ;
            if (indColonneJoue<limiteColonne && indColonneJoue >= 0 && grilleUtilisee[0,indColonneJoue] == 0) {
                    while (ligne <limiteLigne && grilleUtilisee[ligne,indColonneJoue] == 0 && (ligne+1) < limiteLigne && grilleUtilisee[ligne+1,indColonneJoue] == 0 ) {
                        ligne ++ ;  // On remplie une case si l'une d'elle et disponible ET si celle d'aprés est déjà comblée
                    }
                    if (joueurSuivant==true){
                        grilleUtilisee[ligne,indColonneJoue] = 1 ; //Remplissage de la case pour joueur 1 
                        joueurSuivant=false;    //change le joueur qui joue 
                        this.AfficheGrille();
                        Console.WriteLine("");
                        if(!choixMode){       //si c'est joueurVsIA
                            //pose un pion aleatoirement
                            Random aleatoire = new Random();        
                            int colonneAleatoire = aleatoire.Next(1, 7);
                            this.jouer_pion(colonneAleatoire);
                        }
                    }
                    else{
                        grilleUtilisee[ligne,indColonneJoue] = 2 ;  //Remplissage de la case pour joueur 2
                        joueurSuivant=true;   //change le joueur qui joue 
                        this.AfficheGrille();
                        Console.WriteLine("");
                    }
                    
            } else {
                Console.WriteLine("") ;
                Console.WriteLine("Impossible de placer un pion dans cette colonne") ;
            }
        }
        
        // Méthode appelé lorsque un joueur souhaite poser un pion dans une colonne
        public void jouer_pion(int colonne) {
            colonne = colonne - 1 ; // On retire 1 car colonne 1 son indice = 0 ...
            
            if (choixGrille == 1) {
                
                this.jouer_pion(grille1, 6, 7, colonne);
                
            } else if (choixGrille == 2) {
                
                this.jouer_pion(grille2, 5, 6, colonne);
                
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
