public class Transaction(decimal montant, string description)
{
  public DateTime Date { get; set; } = DateTime.Now;
  public decimal Montant { get; set; } = montant;
  public virtual string Type { get; set; } = "";
  public string Description { get; set; } = description;
}