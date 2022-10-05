class Bank 
{
    public List<Customer> Customers = new List<Customer>();
    public List<BankAccount> BankAccounts= new List<BankAccount>();

    //Méthode qui enregistre un client 
    public Customer RegisterCustomer (String FirstName, String LastName)
    {
        Customer returnedCustomer = new Customer(FirstName,LastName);
        this.Customers.Add(returnedCustomer);
        return returnedCustomer;
        
    }

    public BankAccount CreateAccount (String FirstName, String LastName)
    {
        Customer Owner = this.RegisterCustomer(FirstName,LastName);
        BankAccount account = new BankAccount(Owner);
        this.BankAccounts.Add(account);
        
        return account;
    }

    // private Customer FindOrCreateCustomer (String Firstname, String LastName) 
    // {
    //     bool Found = false;
    //     int NbCustomer = this.Customers.Length;
    //     Customer customer;
    //     for (int i;i=0; i<NbCustomer && !Found; i++)
    //     {
    //         customer = this.Customers[i];
    //         Found = customer.FirstName == FirstName && customer.LastName == LastName; 
    //     }
    // }
    // Customer? returnedCustomer = Customers.Find(CustomerMatcher(FirstName,LastName));
    // private static Predicate<Customer> CustomerMatcher(String FirstName, String LastName) {
    // return x => x.FirstName == FirstName && x.LastName == LastName;}
}
