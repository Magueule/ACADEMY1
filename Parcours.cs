public class Parcours
{
  Text text = new Text();
  Rules rules = new Rules();

  public void ParcoursIntroduction()
  {
    text.Intro();
  }

  public string ParcoursInitialisation()
  {
    text.CommandeInitiale();
    string? action = Console.ReadLine();
    return action;
  }
  public void ParcoursCredit(TransactionService transactionService)
  {
    text.DemandeCredit();
    string? inputCredit = Console.ReadLine();
    text.Description();
    string? description = Console.ReadLine();
    if (int.TryParse(inputCredit, out int intCredit))
    {
      Credit credit = new Credit(intCredit, description);
      bool isValid = rules.checkCreditRules(transactionService, credit);
      if (isValid)
      {
        decimal newSolde = transactionService.AddSolde(intCredit);
        credit.LogCredit();
        text.LogSolde(newSolde);
      }
      else
      {
        text.Invalide();
      }
    }
    else
    {
      text.Invalide();
    }
  }

  public void ParcoursDebit(TransactionService transactionService)
  {
    text.DemandeDebit();
    string? inputDebit = Console.ReadLine();
    text.Description();
    string? description = Console.ReadLine();
    if (int.TryParse(inputDebit, out int intDebit))
    {
      Debit debit = new Debit(intDebit, description);
      bool isValid = rules.checkDebitRules(transactionService, debit);
      if (isValid)
      {
        decimal newSolde = transactionService.SubtractSolde(intDebit);
        debit.LogDebit();
        text.LogSolde(newSolde);
      }
      else
      {
        text.Invalide();
      }
    }
    else
    {
      text.Invalide();
    }
  }

  public void ParcoursQuitter()
  {
    text.AuRevoir();
  }

  public void ParcoursInvalid()
  {
    text.Invalide();
  }
}
