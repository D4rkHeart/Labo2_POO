class BankAccount
{
    public Customer Owner;
    public float Balance;

    public BankAccount(Customer Owner,float Balance = 0)
    {
        this.Owner = Owner;
        this.Balance = Balance;
    }

    public void Credit(float amount)
    {
        this.Balance += amount;
        Console.WriteLine("le compte de ", Owner.FullName(), " : +", amount);
    }
}