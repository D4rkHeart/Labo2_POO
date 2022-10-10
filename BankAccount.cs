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
        Console.WriteLine("le compte de " + Owner.FullName()+ " : +"+amount);
    }
    public bool Debit(float amount)
    {
        if(this.Balance >= amount)
        {
            this.Balance += amount;
            Console.WriteLine("Compte de " + Owner.FullName()+ " : -" + amount);
        }
        return false;
        /*Elle prend en paramètre un montant.
• Si le solde est suffisant, elle soustrait le montant
au solde et retourne true.
• Si le solde est insuffisant, elle retourne false.
• Elle écrit dans la console l’opération qui a été
effectuée, exemples :
• « Compte de John Doe: -200 »
• « Compte de John Doe: solde insuffisant (-200) »*/
    }
}