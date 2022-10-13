class Bank 
{
    public List<Customer> Customers = new List<Customer>();
    public List<BankAccount> BankAccounts = new List<BankAccount>();

    //Méthode qui enregistre un client 
    public Customer RegisterCustomer (String FirstName, String LastName)
    {
        
        Customer? customer = this.Customers.Find(x => x.FirstName == FirstName && x.LastName == LastName);
        if(customer == null)
        {
            customer = new Customer(FirstName,LastName);
            this.Customers.Add(customer);
        }
        
        return customer;
        
    }
    //Méhode qui crée un compte pour un client
    public BankAccount CreateAccount (String FirstName, String LastName)
    {
        Customer Owner = this.RegisterCustomer(FirstName,LastName);
        BankAccount account = new BankAccount(Owner);
        this.BankAccounts.Add(account);
        return account;
    }

    public BankAccount[] GetCustomerSummary (Customer customer)
    {
        Console.WriteLine("---------------");
        Console.WriteLine(customer.FullName() + " :");
        BankAccount[] CustomerAccounts = new BankAccount[CountBankAcount(customer)];
        int AccountNumber = 0;
        float TotalBalance = 0;
        foreach (var account in this.BankAccounts)
        {
            if(account.Owner == customer)
            {
                CustomerAccounts[AccountNumber] = account;
                AccountNumber += 1;
                Console.WriteLine("- Compte #" + AccountNumber + ": " + account.Balance);
                TotalBalance += account.Balance;
            }
        }
        Console.WriteLine("Fortune totale : " + TotalBalance);
        Console.WriteLine("---------------");
        return CustomerAccounts;
    }

    public int CountBankAcount (Customer customer)
    {
        int CountAccount = 0;
        foreach (var account in this.BankAccounts)
        {
            if(account.Owner == customer)
            {
                CountAccount += 1;
            }
        }
        return CountAccount;
    }
}
