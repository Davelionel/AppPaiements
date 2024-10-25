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

    
    
        Paypal paiement1 = new Paypal(1150, "iphone 16 pro", "fac32@gmail.com");
        Paypal paiement2 = new Paypal(75.50, "chemise", "davlio32@gmail.com");

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();

        
        Utilisateur utilisateur = new Utilisateur("Dave Lionel");

        utilisateur.AjouterPaiement(achat1);
        utilisateur.AjouterPaiement(achat2);
        utilisateur.AjouterPaiement(achat3);
        utilisateur.AjouterPaiement(paiement1);
        utilisateur.AjouterPaiement(paiement2);

        utilisateur.AfficherInfos();
        
    }
}
