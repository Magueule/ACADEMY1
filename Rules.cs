public class Rules
{
  public bool checkCreditRules(TransactionService transactionService, Credit credit)
  {
    bool isValid =
      Rule1(credit)
    ;
    return isValid;
  }

  public bool checkDebitRules(TransactionService transactionService, Debit debit)
  {
    bool isValid =
      Rule2(transactionService, debit)
    ;
    return isValid;
  }

  // ----------------------------------------------------
  // List of Rules

  // Le montant de la transaction ne peut pas dépasser 10 000 pour un crédit.
  public bool Rule1(Credit credit)
  {
    if (credit.Montant > 10000)
    {
      Console.WriteLine("Crédit Supérieur à 10000.");
      return false;
    }
    return true;
  }

  // Le solde ne peut pas être inférieur à -5 000 après une transaction de débit.
  public bool Rule2(TransactionService transactionService, Debit debit)
  {
    if (transactionService.GetSolde() - debit.Montant < -5000)
    {
      Console.WriteLine("Solde final sera inférieur à -5000.");
      return false;
    }
    return true;
  }
}