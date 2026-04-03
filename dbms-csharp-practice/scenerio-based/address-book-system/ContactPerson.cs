using System.ComponentModel.DataAnnotations;

public class ContactPerson
{
    [Required(ErrorMessage = "First Name Required")]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Last Name Required")]
    public string LastName { get; set; } = "";

    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string Zip { get; set; } = "";

    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Invalid Phone Number")]
    public string PhoneNumber { get; set; } = "";

    [EmailAddress(ErrorMessage = "Invalid Email Format")]
    public string Email { get; set; } = "";

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {PhoneNumber}, Email: {Email}";
    }
}
