class BankAccount
{
    public Customer Owner;
    public float Balance;

    public BankAccount(Customer Owner,float Balance = 0)
    {
        this.Owner = Owner;
        this.Balance = Balance;
    }
    //Méthode pour créditer un compte
    public void Credit(float amount)
    {
        this.Balance += amount;
        Console.WriteLine("le compte de " + Owner.FullName()+ " : +"+amount);
    }
    //Méthode pour débiter un compte
    public bool Debit(float amount)
    {
        if(this.Balance >= amount)
        {
            this.Balance -= amount;
            Console.WriteLine("Compte de " + Owner.FullName()+ " : -" + amount);
            return true;
        }
        Console.WriteLine("Compte de " + Owner.FullName()+ " : solde insuffisant (-" + amount + ")");
        return false;
    }
    public bool Transfer(BankAccount beneficiary,float amount)
    {
        if(this.Debit(amount))
        {
            beneficiary.Credit(amount);
            Console.WriteLine("Transfert du compte de " + Owner.FullName()+ " au commpte de " + beneficiary.Owner.FullName() + " réussi : " + amount );
            return true;
        }
        Console.WriteLine("Transfert du compte de " + Owner.FullName()+ " : solde insuffisant ("+ amount + ")");
        return false;
    }
}
