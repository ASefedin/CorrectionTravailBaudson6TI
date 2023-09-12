using System;

namespace ACT00_REVISION
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep = "";

            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            // instanciation de la structure
            MethodesDuProjet MesOutils = new MethodesDuProjet();

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);


                // ordonner les côtés => APPEL ORDONNECOTES
                MesOutils.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                if (MesOutils.Triangle(c1, c2, c3))
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'

                    MesOutils.Affiche(true, "triangle");

                    // vérification équilatéral
                    if (MesOutils.Equi(c1, c2, c3))
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        MesOutils.Affiche(true, "equilateral");

                    }
                    else
                    {
                        // vérification triangle rectangle
                        MesOutils.Affiche(false, "equilateral");
                        if (MesOutils.TriangleRectangle(c1, c2, c3))
                        {
                            MesOutils.Affiche(true, "rectangle");
                        }
                        else
                        {
                            MesOutils.Affiche(false, "rectangle");
                        }
                        if (MesOutils.Isocele(c1, c2, c3))
                        {
                            MesOutils.Affiche(true, "isocele");
                        }
                        else
                        {
                            MesOutils.Affiche(false, "isocele");
                        }


                    }
                }
                else // si ce n'est pas un triangle
                {


                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    MesOutils.Affiche(false, "triangle");

                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
