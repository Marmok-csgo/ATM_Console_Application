namespace ATM;

class Program
{
    static void Main(string[] args)
    {
        var check = false;
        var service = new AtmService();
        Console.Write("Enter Your Card Number: ");
        card:
        string? cardNumber = Console.ReadLine();
        if (cardNumber != null && service.CheckCard(cardNumber))
        {
            Console.Write("Enter Your Card Password: ");
            password:
            var cardPassword = Console.ReadLine();
            if (service.CheckPass(cardNumber, cardPassword))
            {
                Console.Clear();
                Console.WriteLine($"Hello {service.GetFullName(cardNumber)}");
                check = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your Pin in incorrect! Try Again.");
                goto password;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Your Card Not Found! Try Again.");
            goto card;
        }

        Console.WriteLine("Welcome ATM service.");
        while (check)
        {
            Console.WriteLine("1. Deposit.\n" +
                              "2. Withdraw.\n" +
                              "3. Balance.\n" +
                              "4. Exit.");
            Console.Write("Enter Your Choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                
                case "1":
                    Console.Clear();
                    Console.Write("Enter Amount: ");
                    var amount = Console.ReadLine();
                    service.Deposit(cardNumber, Convert.ToDouble(amount));
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Enter Amount: ");
                    var amount2 = Console.ReadLine();
                    service.Withdraw(cardNumber, Convert.ToDouble(amount2));
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(service.GetBalance(cardNumber));
                    break;
                case "4":
                    Console.Clear();
                    check = false;
                    break;
                default:
                    Console.Clear();
                    break;
            }
            
            
        }
        
    }
}