using BibliothèquePuissance4;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestPuissance4
{
    [TestClass]
    public class TestsAlignements
    {
        /// <summary>
        /// Attribut de la partie qui nous servira pour tous les tests
        /// </summary>
        Puissance4 Partie;

        /// <summary>
        /// Constructeur de la classe de test, elle inialise l'attribut de la partie
        /// </summary>
        public TestsAlignements()
        {
            //Instanciation de la partie
            //grille 1 (6x7)  ; mode : JVJ
            Partie = new Puissance4("J1", "J2", 1, true);
        }





        //////////////////////////////// CAS D'ALIGNEMENTS ///////////////////////////////////////////
        //Tous les asserts doivent être = à 1 pour montrer que 4 pions de J1 sont alignés



        /// <summary>
        /// Méthode de test qui vérifie que l'alignement de 4 pions (colonne 1/2/3/4) du même joueur sur le  côté gauche de chaque ligne
        /// est bien détécté
        /// </summary>
        [TestMethod]
        public void AlignementHorizontalBordureDebut_1_2_3_4_1()
        {
            //ARRANGE
            // On parcourt chaque ligne et les 4 premières  colonnes de ces lignes
            // dans lesquelles on ajoute 4 pions à la valeur 1 (J1)
            for (int indiceLigne = 0; indiceLigne < 6; indiceLigne++)
            {
                for (int indiceColonne = 0; indiceColonne < 4; indiceColonne++)
                {
                    Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }

        /// <summary>
        /// Méthode de test qui permet de tester que les alignements de 4 pions d'un même joueur
        /// au milieu de chaque ligne sont détectés (colonne 2 3 4 5)
        /// </summary>

        [TestMethod]
        public void AlignementHorizontalNonBordure_2_3_4_5_1()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE
            for (int indiceLigne = 0; indiceLigne < 6; indiceLigne++)
            {
                for (int indiceColonne = 2; indiceColonne < 6; indiceColonne++)
                {
                    Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }
        }

        /// <summary>
        /// Méthode de test qui vérifie que l'alignement de 4 pions (colonne 4/5/6/7) du même joueur sur le  côté gauche de chaque ligne
        /// est bien détécté
        /// </summary>

        [TestMethod]
        public void AlignementHorizontalBordureFin_4_5_6_7_1()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE
            for (int indiceLigne = 0; indiceLigne < 6; indiceLigne++)
            {
                for (int indiceColonne = 3; indiceColonne < 7; indiceColonne++)
                {
                    Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }
        }


        /// <summary>
        /// Méthode de test qui vériie si l'alignement de 4 pions d'un meme joueur à la verticale 
        /// collée à la limite basse de la grille est détecté
        /// </summary>
        [TestMethod]
        public void AlignementVerticalBordureBasse_1_2_3_4_1()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE
            for (int indiceColonne = 0; indiceColonne < 7; indiceColonne++)
            {
                for (int indiceLigne = 0; indiceLigne < 4; indiceLigne++)
                {
                    Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }
                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }
        }


        /// <summary>
        /// Méthode de test qui vérifie si l'alignement de 4 pions de la même couleur
        /// au milieu des colonnes est détécté
        /// </summary>
        [TestMethod]
        public void AlignementVerticalMilieu_1_2_3_4_1()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE

            for (int indiceColonne = 0; indiceColonne < 7; indiceColonne++)
            {
                for (int indiceLigne = 1; indiceLigne < 5; indiceLigne++)
                {
                    Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }
        }

        [TestMethod]
        public void AlignementVerticalBordureHaute_3_4_5_6_1()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE
            // On parcourt chaque ligne et les 4  dernières colonnes de ces lignes dans lesquelles on ajoute 4 pions à la valeur 1 (J1)
            for (int indiceColonne = 0; indiceColonne < 7; indiceColonne++)
            {
                for (int indiceLigne = 2; indiceLigne < 6; indiceLigne++)
                {
                    Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }
        }


        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale qui se fini dans
        /// l'angle droit en haut (ascendant) est détecté
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalAscendantAngleDroit_4_5_5_7_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1)
            Partie.GrilleJeu[3, 3] = 1;
            Partie.GrilleJeu[2, 4] = 1;
            Partie.GrilleJeu[1, 5] = 1;
            Partie.GrilleJeu[0, 6] = 1;
            Partie.Victoire(6);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }


        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale qui commence dans 
        /// l'angle en bas à gauche (ascendant) est détécté
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalAscendantDebutAngleBasGauche_0_1_2_3_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[5, 0] = 1;
            Partie.GrilleJeu[4, 1] = 1;
            Partie.GrilleJeu[3, 2] = 1;
            Partie.GrilleJeu[2, 3] = 1;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }


        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale qui commence et 
        /// fini au milieu (aucune bordure)
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalAscendantMilieu_1_2_3_4()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[4, 1] = 1;
            Partie.GrilleJeu[3, 2] = 1;
            Partie.GrilleJeu[2, 3] = 1;
            Partie.GrilleJeu[1, 4] = 1;
            Partie.Victoire(4);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }

        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale qui commence
        /// à la bordure gauche et fini à la bordure haute
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalAscendantBordureHaute_0_1_2_3_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[3, 0] = 1;
            Partie.GrilleJeu[2, 1] = 1;
            Partie.GrilleJeu[1, 2] = 1;
            Partie.GrilleJeu[0, 3] = 1;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }


        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale qui fini dans
        /// l'angle en bas à gauche
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalDescendantAngleBasGauche_3_2_1_0_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[2, 3] = 1;
            Partie.GrilleJeu[3, 2] = 1;
            Partie.GrilleJeu[4, 1] = 1;
            Partie.GrilleJeu[5, 0] = 1;
            Partie.Victoire(0);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }

        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale qui commence
        /// dans l'angle en haut à droite
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalDescendantCommenceHautDroite_6_5_4_3_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[0, 6] = 1;
            Partie.GrilleJeu[1, 5] = 1;
            Partie.GrilleJeu[2, 4] = 1;
            Partie.GrilleJeu[3, 3] = 1;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }


        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale descendante
        /// au milieu de la grille est détécté
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalDescendantMilieu_4_3_2_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[1, 4] = 1;
            Partie.GrilleJeu[2, 3] = 1;
            Partie.GrilleJeu[3, 2] = 1;
            Partie.GrilleJeu[4, 1] = 1;
            Partie.Victoire(1);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }

        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale descendante
        /// qui commence collé à la bordure haute est détecté
        /// </summary>

        [TestMethod]
        public void AlignementDiagonalDescendantCommenceBordureHaute_4_3_2_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[0, 4] = 1;
            Partie.GrilleJeu[1, 3] = 1;
            Partie.GrilleJeu[2, 2] = 1;
            Partie.GrilleJeu[3, 1] = 1;
            Partie.Victoire(1);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }


        /// <summary>
        /// Méthode qui teste si l'alignement de 4 pions d'un meme joueur en diagonale descendante
        /// qui commence collé à la bordure droite est détecté
        /// </summary>
        [TestMethod]
        public void AlignementDiagonalDescendantCommenceBordureDroite_6_5_4_3_1()
        {
            //Arrange On ajoute la valeur 1 à la case pour indiquer qu'il y a un pion du J1
            Partie.GrilleJeu[1, 6] = 1;
            Partie.GrilleJeu[2, 5] = 1;
            Partie.GrilleJeu[3, 4] = 1;
            Partie.GrilleJeu[4, 3] = 1;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(1, numeroGagnant);
        }





        ///////////////////////////CAS DE NON ALIGNEMENT///////////////////////////////
        //Tous les asserts seront égals à -1 ce qui montre qu'il n'y a pas d'alignement



        /// <summary>
        /// Méthode qui teste qu'aucun alignement n'est détecté lorsque il n'y pas 4 pions
        /// du même joueurs alignés horizontalement collé à la bodure gauche
        /// </summary>
        [TestMethod]
        public void NonAlignementHorizontalBordureDebut()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE

            // On parcourt chaque ligne et les 4 premières  colonnes de ces lignes
            // dans lesquelles on alterne les pions J1/J2
            for (int indiceLigne = 0; indiceLigne < 6; indiceLigne++)
            {
                for (int indiceColonne = 0; indiceColonne < 4; indiceColonne++)
                {
                    //On alterne jeton de J1 et de J2
                    if (indiceColonne % 2 == 0)
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    }else
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 2;
                    }
                    
                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(-1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }


        /// <summary>
        /// Méthode qui teste qu'aucun alignement n'est détecté lorsque il n'y pas 4 pions
        /// du même joueurs alignés horizontalement collé à la bodure droite
        /// </summary>
        [TestMethod]
        public void NonAlignementHorizontalBordureFin()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE

            // On parcourt chaque ligne et les 4 dernières  colonnes de ces lignes
            // dans lesquelles on alterne les pions J1/J2
            for (int indiceLigne = 0; indiceLigne < 6; indiceLigne++)
            {
                for (int indiceColonne = 3; indiceColonne < 6; indiceColonne++)
                {
                    //On alterne jeton de J1 et de J2
                    if (indiceColonne % 2 == 0)
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    }
                    else
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 2;
                    }

                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(-1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }


        /// <summary>
        /// Méthode qui teste qu'aucun alignement n'est détecté lorsque il n'y pas 4 pions
        /// du même joueurs alignés horizontalement non collés à une bordure
        /// </summary>
        [TestMethod]
        public void NonAlignementHorizontalNonBordure()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE

            // On parcourt chaque ligne et les 4 colonnes du milieu  de ces lignes
            // dans lesquelles on alterne les pions J1/J2
            for (int indiceLigne = 0; indiceLigne < 6; indiceLigne++)
            {
                for (int indiceColonne = 2; indiceColonne < 5; indiceColonne++)
                {
                    //On alterne jeton de J1 et de J2
                    if (indiceColonne % 2 == 0)
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    }
                    else
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 2;
                    }

                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(-1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }


        /// <summary>
        /// Méthode qui teste qu'aucun alignement n'est détecté lorsque il n'y pas 4 pions
        /// du même joueurs alignés verticalement collés au bas de la grille
        /// </summary>
        [TestMethod]
        public void NonAlignementVerticalBordureBasse()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détectés
            //ARRANGE

            // On parcourt chaque colonne et les 4 lignes du bas de chaque colonne
            // dans lesquelles on alterne les pions J1/J2
            for (int indiceColonne = 0; indiceColonne < 7; indiceColonne++)
            {
                for (int indiceLigne = 0; indiceLigne < 4; indiceLigne++)
                {
                    //On alterne jeton de J1 et de J2
                    if (indiceLigne % 2 == 0)
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    }
                    else
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 2;
                    }

                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(-1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }

        /// <summary>
        /// Méthode qui teste qu'aucun alignement n'est détecté lorsque il n'y pas 4 pions
        /// du même joueurs alignés verticalement collés en haut de la grille
        /// </summary>
        [TestMethod]
        public void NonAlignementVerticalBordureHaute()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE

            // On parcourt chaque colonne et les 4 lignes du haut de chaque colonne
            // dans lesquelles on alterne les pions J1/J2
            for (int indiceColonne = 0; indiceColonne < 7; indiceColonne++)
            {
                for (int indiceLigne = 2; indiceLigne < 6; indiceLigne++)
                {
                    //On alterne jeton de J1 et de J2
                    if (indiceLigne % 2 == 0)
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    }
                    else
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 2;
                    }

                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(-1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }

        /// <summary>
        /// Méthode qui teste qu'aucun alignement n'est détecté lorsque il n'y pas 4 pions
        /// du même joueurs alignés verticalement au milieu de la grille
        /// </summary>
        [TestMethod]
        public void NonAlignementVerticalMilieu()
        {
            // Placement des jetons dans le but de faire gagner le J1
            // et de voir si les alignements sont bien détéctés
            //ARRANGE

            // On parcourt chaque colonne et les 4 lignes du milieu de chaque colonne
            // dans lesquelles on alterne les pions J1/J2
            for (int indiceColonne = 0; indiceColonne < 7; indiceColonne++)
            {
                for (int indiceLigne = 1; indiceLigne < 5; indiceLigne++)
                {
                    //On alterne jeton de J1 et de J2
                    if (indiceLigne % 2 == 0)
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 1;
                    }
                    else
                    {
                        Partie.GrilleJeu[indiceLigne, indiceColonne] = 2;
                    }

                    //Appel de la fonction victoire qui modifiera la valeur de l'attribut gagnant de la Partie si il y en a un
                    Partie.Victoire(indiceColonne);

                }

                //Act
                int numeroGagnant = Partie.Gagnant;
                //Assert
                Assert.AreEqual(-1, numeroGagnant);
                // Permet de réinitialiser la grille pour ne pas être gêné par les anciens tests fait sur les autres lignes
                Partie.InitGrille();
            }



        }

        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal ascendant
        /// qui fini dans l'angle droit
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalAscendantAngleDroit_4_5_5_7_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement ascendant

            Partie.GrilleJeu[3, 3] = 1;
            Partie.GrilleJeu[2, 4] = 2;
            Partie.GrilleJeu[1, 5] = 1;
            Partie.GrilleJeu[0, 6] = 2;
            Partie.Victoire(6);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }


        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal ascendant
        /// qui débute dans l'angle en bas à gauche
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalAscendantDebutAngleBasGauche_0_1_2_3_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement ascendant
            Partie.GrilleJeu[5, 0] = 1;
            Partie.GrilleJeu[4, 1] = 2;
            Partie.GrilleJeu[3, 2] = 1;
            Partie.GrilleJeu[2, 3] = 3;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }


        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal ascendant
        /// au milieu de la grille (non collé à une bordure)
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalAscendantMilieu_1_2_3_4()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement ascendant
            Partie.GrilleJeu[4, 1] = 1;
            Partie.GrilleJeu[3, 2] = 2;
            Partie.GrilleJeu[2, 3] = 1;
            Partie.GrilleJeu[1, 4] = 2;
            Partie.Victoire(4);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }

        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal ascendant
        /// qui fini collé à la bordure haute
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalAscendantBordureHaute_0_1_2_3_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement ascendant
            Partie.GrilleJeu[3, 0] = 1;
            Partie.GrilleJeu[2, 1] = 2;
            Partie.GrilleJeu[1, 2] = 1;
            Partie.GrilleJeu[0, 3] = 2;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }


        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal descendant
        /// qui fini dans l'angle en bas à gauche
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalDescendantAngleBasGauche_3_2_1_0_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement descendant
            Partie.GrilleJeu[2, 3] = 1;
            Partie.GrilleJeu[3, 2] = 2;
            Partie.GrilleJeu[4, 1] = 1;
            Partie.GrilleJeu[5, 0] = 2;
            Partie.Victoire(0);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }

        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal descendant
        /// qui commence en haut à droite
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalDescendantCommenceHautDroite_6_5_4_3_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement descendant
            Partie.GrilleJeu[0, 6] = 1;
            Partie.GrilleJeu[1, 5] = 2;
            Partie.GrilleJeu[2, 4] = 1;
            Partie.GrilleJeu[3, 3] = 2;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }


        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal descendant
        /// qui commence et fini non collé à une bordure
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalDescendantMilieu_4_3_2_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement descendant
            Partie.GrilleJeu[1, 4] = 1;
            Partie.GrilleJeu[2, 3] = 2;
            Partie.GrilleJeu[3, 2] = 1;
            Partie.GrilleJeu[4, 1] = 2;
            Partie.Victoire(1);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }

        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal descendant
        /// qui commence collé à une bordure haute de la grille
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalDescendantCommenceBordureHaute_4_3_2_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement descendant
            Partie.GrilleJeu[0, 4] = 1;
            Partie.GrilleJeu[1, 3] = 2;
            Partie.GrilleJeu[2, 2] = 1;
            Partie.GrilleJeu[3, 1] = 2;
            Partie.Victoire(1);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }


        /// <summary>
        /// Méthode de test qui vérifie si il n'existe pas un faux alignement diagonal descendant
        /// qui commence collé à la bordure droite de la grille
        /// </summary>
        [TestMethod]
        public void NonAlignementDiagonalDescendantCommenceBordureDroite_6_5_4_3_1()
        {
            //Arrange // On Alterne Jeton du J1 / J2 pour créer un non alignement descendant
            Partie.GrilleJeu[1, 6] = 1;
            Partie.GrilleJeu[2, 5] = 2;
            Partie.GrilleJeu[3, 4] = 1;
            Partie.GrilleJeu[4, 3] = 2;
            Partie.Victoire(3);
            //Act
            int numeroGagnant = Partie.Gagnant;
            //Assert 
            Assert.AreEqual(-1, numeroGagnant);
        }

    }
}