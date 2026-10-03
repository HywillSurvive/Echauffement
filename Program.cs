namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
            
        string nomEtPrenom = "Van drepol Thibault";
        string jeuPrefere = "Menace";
        Console.WriteLine("Je m'appel, " + nomEtPrenom +" et mon jeu préféré est " + jeuPrefere + ".");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
           
        Console.WriteLine("quel âge avez-vous ?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Quel est votre prénom ?");
        string prenom = Console.ReadLine();
        Console.WriteLine("Vous avez " + age + " ans et vous vous appelez " + prenom +".");

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        
        if (age >= 18)
        {
            Console.WriteLine("Tu es majeur.");
        }
        else
        {
            Console.WriteLine("Tu es mineur.");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("Combien d'euro avez-vous ?");
        int euro = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vous avez " + euro + " euro.");

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("Le magasin propose :\n 1) Dague : 15 euro. \n 2) Epée : 50 euro. \n 3) Arc : 45 euro. \n 4) Lance : 40 euro.");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Veuillez choisir une arme en indiquant un nombre.");
        int choixArme = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vous avez choisi " + choixArme + ".");

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        int sommeFinal;
        int dague = 15;
        int epee = 50;
        int arc = 45;
        int lance = 40;
        if (age >= 18 && euro >= 15)
        {
            if (choixArme == 1)
            {
                if (euro >= dague)
                {
                    Console.WriteLine("Vous avez acheté une dague.");
                    sommeFinal = euro - dague;
                    Console.WriteLine("Il vous reste " + sommeFinal + " euro.");
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                    
                }
            }
            if (choixArme == 2)
            {
                if (euro >= epee)
                {
                    Console.WriteLine("Vous avez acheté une épée.");
                    sommeFinal = euro - epee;
                    Console.WriteLine("Il vous reste " + sommeFinal + " euro.");
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                }
            }
            if (choixArme == 3)
            {
                if (euro >= arc)
                {
                    Console.WriteLine("Vous avez acheté un arc.");
                    sommeFinal = euro - arc;
                    Console.WriteLine("Il vous reste " + sommeFinal + " euro.");
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                }
            }
            if (choixArme == 4)
            {
                if (euro >= lance)
                {
                    Console.WriteLine("Vous avez acheté une lance.");
                    sommeFinal = euro - lance;
                    Console.WriteLine("Il vous reste " + sommeFinal + " euro.");
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent.");
                }
            }
        }
        else 
        {
            Console.WriteLine("Vous n'avez pas l'âge pour achetez une arme ou vous n'avez pas la somme requise.");
        }
        
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible




        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}