namespace ATM;

public class CardHolder
{
    public string? CardNumber {get; set; }
    public string? Password {get; set; }
    public string? FirstName {get; set; }
    public string? LastName {get; set; }
    public double Balance {get; set; }


    public CardHolder(string? cardnumber, string? password, string? firstName, string? lastName, double balance)
    {
        CardNumber = cardnumber;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }
}