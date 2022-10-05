class Customer
{
    public String FirstName;
    public String LastName;
    public Customer(String firstname, String lastname) 
    {
        this.FirstName = firstname;
        this.LastName = lastname;
    }
    public String FullName()
    {
        return this.FirstName + " " + this.LastName;
    }
}