public class Debit : Transaction
{
  public Debit(decimal montant, string description) : base(montant, description)
  {
    Type = "Débit";
  }
  public void LogDebit()
  {
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Date: {Date}");
    Console.WriteLine($"Montant: {Montant}");
    Console.WriteLine($"Type: {Type}");
    Console.WriteLine($"Description: {Description}");
    Console.WriteLine("--------------------------------");
  }
}