using AppPaiements;

internal class Program
{
    public static void Main(string[] args)
    {
        
        CarteCredit achat1 = new CarteCredit(100.50, "epicerie", 1232545154);
        CarteCredit achat2 = new CarteCredit(200.75, "shopping", 234567890);
        CarteCredit achat3 = new CarteCredit(50.25, "medicament", 345678901);

        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();
        
    }
}