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
        private int limiteLigne;
        private int limiteColonne;

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
                limiteLigne=6;
                limiteColonne=7;
                initGrille(grille1);
                
            }
            else if (choixGrille == 2)
            {
                limiteLigne=5;
                limiteColonne=6;
                initGrille(grille2);
            }
            else{
                Random aleatoire = new Random();        
                choixGrille = aleatoire.Next(1,3);
                Console.WriteLine("") ;
                Console.WriteLine("La grille tiree aleatoirement est la grille " + choixGrille + ".") ;
                if (choixGrille==1){
                    limiteLigne=6;
                    limiteColonne=7;
                    this.initGrille(grille1);
                }
                else{
                    limiteLigne=5;
                    limiteColonne=6;
                    this.initGrille(grille2);
                }
            }
        }
        
        public void initGrille(int[,] grilleUtilisee){
            for (int i = 0; i < limiteLigne; i++)
            {
                for (int j = 0; j<limiteColonne ; j++) {
                    grilleUtilisee[i,j] = 0;           //On initalise chaque case à 0 (= case vide)
                }
            }
        }
 
 
        public bool AlignementVertical(int[,] grilleUtilisee,int colonneJoue){
            int cptr=0,ligne=limiteLigne-1,valeur;
            bool quatreAligne=false;
            if (joueurSuivant){
                valeur=2;
            }
            else{
                valeur=1;
            }
            while(grilleUtilisee[ligne,colonneJoue]==0&&ligne>=0){
                ligne--;
            }
            while(grilleUtilisee[ligne,colonneJoue]==valeur&&ligne>=0){
                ligne--;
                cptr++;
            }
            if(cptr==4){
                quatreAligne=true;
                gagnant=valeur;
            }
            return quatreAligne;
        }
        
        public bool GrilleComplete(int[,] grilleUtilisee){
            bool complet=false;
            int caseVide=0;
            for(int j=0;j<limiteColonne;j++){
                if(grilleUtilisee[limiteLigne-1,j]==0){
                    caseVide++;
                }
            }
            if(caseVide==0){
                complet=true;
            }
            gagnant=0;
            return complet;
        }
        
        public bool Victoire(int[,] grilleUtilisee,int colonneJoue){
            bool resultat=false;
            if (/*AlignementHorizontal(colonneJoue)||*/AlignementVertical(grilleUtilisee, colonneJoue)/*||AlignementDiagonalCroissant(colonneJoue)||AlignementDiagonalDecroissant(colonneJoue)*/){
                resultat=true;
                if(gagnant==1){
                    Console.WriteLine(" ") ;
                    Console.WriteLine(J1.pseudo+" a gagne la partie");
                }
                else if(gagnant==2){
                    Console.WriteLine(" ") ;
                    Console.WriteLine(J2.pseudo+" a gagne la partie");
                }
                
            }else if (GrilleComplete(grilleUtilisee)){
                Console.WriteLine(" ") ;
                Console.WriteLine("Match nul");
            }
            return resultat;
        }
 
        // Fonction qui affiche la grille dans la console
        
        public void AfficheGrille (int[,] grilleUtilisee) 
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
        
        public void JouerPionDansGrille(int[,] grilleUtilisee, int indColonneJoue){
            int ligne = 0 ;
            
            if (indColonneJoue < limiteColonne && indColonneJoue >= 0 && grilleUtilisee[0,indColonneJoue] == 0) {
                    while ((ligne+1) < limiteLigne && grilleUtilisee[ligne+1,indColonneJoue] == 0 ) {
                        ligne ++ ;  // On remplie une case si l'une d'elle est disponible ET si celle d'aprés est déjà comblée
                    }
                    if (joueurSuivant==true){
                        grilleUtilisee[ligne,indColonneJoue] = 1 ; //Remplissage de la case pour joueur 1 
                        joueurSuivant=false;    //change le joueur qui joue 
                        this.AfficheGrille(grilleUtilisee);
                        Console.WriteLine("");
                        if(!choixMode){       //si c'est joueurVsIA
                            //pose un pion aleatoirement
                            Random aleatoire = new Random();        
                            int colonneAleatoire = aleatoire.Next(1, limiteColonne+1);
                            this.JouerTour(colonneAleatoire);
                        }
                        //this.Victoire(grilleUtilisee,indColonneJoue);
                    }
                    else{
                        grilleUtilisee[ligne,indColonneJoue] = 2 ;  //Remplissage de la case pour joueur 2
                        joueurSuivant=true;   //change le joueur qui joue 
                        this.AfficheGrille(grilleUtilisee);
                        Console.WriteLine("");
                        //this.Victoire(grilleUtilisee,indColonneJoue);
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
                
                this.JouerPionDansGrille(grille1, colonne);
                
            } else if (choixGrille == 2) {
                
                this.JouerPionDansGrille(grille2, colonne);
                
            }
        }
        
    }
    
    // MAIN
    private static void Main(string[] args)
    {
        Puissance4 jeu = new Puissance4("Joueur 1", "Joueur 2",0,true);
        
        Console.WriteLine(" ") ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
        jeu.JouerTour(5) ;
        jeu.JouerTour(4) ;
    }
}
