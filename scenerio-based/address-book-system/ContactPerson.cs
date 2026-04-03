public class ContactPerson
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string Zip { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Email { get; set; } = "";

    public override string ToString()
    {
        return "Name: "
            + FirstName
            + " "
            + LastName
            + ", Address: "
            + Address
            + ", City: "
            + City
            + ", State: "
            + State
            + ", Zip: "
            + Zip
            + ", Phone: "
            + PhoneNumber
            + ", Email: "
            + Email;
    }
}
