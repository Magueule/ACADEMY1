public class Text
{
  public void Intro()
  {
    Console.Write("Bonjour Mr Bond.\n");
    Console.Write("Pour faire un crédit, tapez 1.\n");
    Console.Write("Pour faire un débit, tapez 2.\n");
    Console.Write("Pour quitter l'application, tapez 0.\n");
  }
  public void CommandeInitiale()
  {
    Console.Write("Veuillez taper votre commande (1,2 ou 0): ");
  }
  public void DemandeCredit()
  {
    Console.Write("Montant du crédit souhaité: ");
  }
  public void DemandeDebit()
  {
    Console.Write("Montant du débit souhaité: ");
  }
  public void Description()
  {
    Console.Write("Ecrire une description: ");
  }
  public void LogSolde(decimal solde)
  {
    Console.Write($"Votre nouveau solde est de: {solde}\n");
    Console.WriteLine("--------------------------------");
  }
  public void Invalide()
  {
    Console.Write("Commande invalide.\n");
  }

  public void AuRevoir()
  {
    Console.Write("La machine va s'auto détruire.\n");
  }
}
