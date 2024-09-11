public class TransactionService
{
  public decimal solde = 0;

  public decimal GetSolde()
  {
    return solde;
  }
  public decimal AddSolde(int credit)
  {
    solde = solde + credit;
    return solde;
  }

  public decimal SubtractSolde(int debit)
  {
    solde = solde - debit;
    return solde;
  }
}