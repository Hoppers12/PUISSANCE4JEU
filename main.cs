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
                initGrille(grille1,6,7);
            }
            else if (choixGrille == 2)
            {
                initGrille(grille2,5,6);
            }
            else{
                Random aleatoire = new Random();        
                choixGrille = aleatoire.Next(1,3);
                Console.WriteLine("") ;
                Console.WriteLine("La grille tiree aleatoirement est la grille " + choixGrille + ".") ;
                if (choixGrille==1){
                    this.initGrille(grille1,6,7);
                }
                else{
                    this.initGrille(grille2,5,6);
                }
            }
        }
        
        public void initGrille(int[,] grilleUtilisee, int limiteLigne, int limiteColonne){
            for (int i = 0; i < limiteLigne; i++)
            {
                for (int j = 0; j<limiteColonne ; j++) {
                    grilleUtilisee[i,j] = 0;           //On initalise chaque case à 0 (= case vide)
                }
            }
        }
 
        // Fonction qui affiche la grille dans la console
        
        public void AfficheGrille (int[,] grilleUtilisee, int limiteLigne, int limiteColonne) 
        {
            for (int i = 0 ; i<limiteLigne ; i++) // 0 à 6 lignes (donc 7)
            {
                Console.WriteLine(" ") ;
                for (int j = 0 ; j < limiteColonne ; j++) 
                {
                    Console.Write(grilleUtilisee[i,j] + " " );
                }
            }    
        }
        
        public void JouerPionDansGrille(int[,] grilleUtilisee, int limiteLigne, int limiteColonne, int indColonneJoue){
            int ligne = 0 ;
            if (indColonneJoue < limiteColonne && indColonneJoue >= 0 && grilleUtilisee[0,indColonneJoue] == 0) {
                    while (ligne < limiteLigne && grilleUtilisee[ligne,indColonneJoue] == 0 && (ligne+1) < limiteLigne && grilleUtilisee[ligne+1,indColonneJoue] == 0 ) {
                        ligne ++ ;  // On remplie une case si l'une d'elle et disponible ET si celle d'aprés est déjà comblée
                    }
                    if (joueurSuivant==true){
                        grilleUtilisee[ligne,indColonneJoue] = 1 ; //Remplissage de la case pour joueur 1 
                        joueurSuivant=false;    //change le joueur qui joue 
                        this.AfficheGrille(grilleUtilisee,limiteLigne,limiteColonne);
                        Console.WriteLine("");
                        if(!choixMode){       //si c'est joueurVsIA
                            //pose un pion aleatoirement
                            Random aleatoire = new Random();        
                            int colonneAleatoire = aleatoire.Next(1, limiteColonne+1);
                            this.JouerTour(colonneAleatoire);
                        }
                    }
                    else{
                        grilleUtilisee[ligne,indColonneJoue] = 2 ;  //Remplissage de la case pour joueur 2
                        joueurSuivant=true;   //change le joueur qui joue 
                        this.AfficheGrille(grilleUtilisee,limiteLigne,limiteColonne);
                        Console.WriteLine("");
                    }
                    
            } else {
                Console.WriteLine("") ;
                Console.WriteLine("Impossible de placer un pion dans cette colonne") ;
            }
        }
        
        // Méthode appelé lorsque un joueur souhaite poser un pion dans une colonne
        public void JouerTour(int colonne) {
            colonne = colonne - 1 ; // On retire 1 car colonne 1 son indice = 0 ...
            
            if (choixGrille == 1) {
                
                this.JouerPionDansGrille(grille1, 6, 7, colonne);
                
            } else if (choixGrille == 2) {
                
                this.JouerPionDansGrille(grille2, 5, 6, colonne);
                
            }
        }
        
    }
    
    // MAIN
    private static void Main(string[] args)
    {
        Puissance4 jeu = new Puissance4("Joueur 1", "Joueur 2",0,true);
        
        Console.WriteLine(" ") ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(4) ;
        
    }
}

