namespace Delegates
{
    internal class Program
    {
        public delegate void ShowMoney(int valeur);

        public static void DisplayDollarMoney(int valeur)
        {
            Console.WriteLine(valeur + " $");

        }
        public static void DisplayEuroMoney(int valeur)
        {
            Console.WriteLine(valeur + " €");

        }

        static void Main(string[] args)
        {
            int somme = 2;
            ShowMoney affichageEnDollar = DisplayDollarMoney;  
            Console.WriteLine("Affichage de la somme en dollar : ");
            affichageEnDollar(somme);
            
            Console.WriteLine();
            
            Console.WriteLine("Affichage de la somme en euro :");
            ShowMoney affichageEnEuro = DisplayEuroMoney;  
            affichageEnEuro(somme);   


        }
    }
}
