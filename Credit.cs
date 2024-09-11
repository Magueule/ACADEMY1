public class Credit : Transaction
{
  public Credit(decimal montant, string description) : base(montant, description)
  {
    Type = "Crédit";
  }
  public void LogCredit()
  {
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Date: {Date}");
    Console.WriteLine($"Montant: {Montant}");
    Console.WriteLine($"Type: {Type}");
    Console.WriteLine($"Description: {Description}");
    Console.WriteLine("--------------------------------");
  }
}