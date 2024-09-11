public class Exo1
{
  static void Main(string[] args)
  {
    TransactionService transactionService = new TransactionService();
    Parcours parcours = new Parcours();
    parcours.ParcoursIntroduction();
    while (true)
    {
      string action = parcours.ParcoursInitialisation();
      if (action == "1") parcours.ParcoursCredit(transactionService);
      else if (action == "2") parcours.ParcoursDebit(transactionService);
      else if (action == "0")
      {
        parcours.ParcoursQuitter();
        break;
      }
      else parcours.ParcoursInvalid();
    }
  }
}