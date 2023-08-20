namespace ATM;

public class AtmService
{
    private List<CardHolder> _cards = new List<CardHolder>
    {
        new CardHolder("9860123344443321", "123123", "Michael", "Stark", 350.66),
        new CardHolder("1234567890123456", "123456", "John", "Doe", 150.00),
        new CardHolder("9876543210987654", "765432", "Jane", "Smith", 500.25),
        new CardHolder("5555666677778888", "987654", "Emily", "Johnson", 200.50),
        new CardHolder("4444333322221111", "456789", "David", "Brown", 1000.75),
        new CardHolder("2222111133334444", "234567", "Sarah", "Williams", 750.20),
        new CardHolder("8888999911112222", "876543", "Daniel", "Lee", 300.40),
        new CardHolder("7777666655554444", "654321", "Olivia", "Martin", 600.90),
        new CardHolder("6666555544443333", "345678", "Jessica", "Miller", 450.15),
        new CardHolder("3333222211110000", "567890", "Christopher", "Taylor", 800.30)
    };

    public bool CheckCard(string card)
    {
        return _cards.Any(x => x.CardNumber == card);
    }

    public string? GetFullName(string card)
    {
        return _cards.FirstOrDefault(x => x.CardNumber == card)?.FirstName;
    }
    public bool CheckPass(string card, string pass)
    {
        return _cards.Any(x => x.CardNumber == card && x.Password == pass);
    }

    public void Deposit(string card, double amount)
    {
        var cardHold = _cards.FirstOrDefault(x => x.CardNumber == card);
        if (cardHold != null) cardHold.Balance += amount;
    }
    
    public void Withdraw(string card, double amount)
    {
        var cardHold = _cards.FirstOrDefault(x => x.CardNumber == card);
        if (cardHold!= null) cardHold.Balance -= amount;
    }

    public string GetBalance(string card)
    {
        var cardHold = _cards.FirstOrDefault(x => x.CardNumber == card);
        if (cardHold != null) return cardHold.Balance.ToString();
        return "0";
    }
}