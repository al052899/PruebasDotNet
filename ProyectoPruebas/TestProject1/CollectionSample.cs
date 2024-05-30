using System;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
public class CollectionSample
{
    public static Customer GetCustomer(Customer[] customer, int index)
    {
        return customer[index];
    }
}

