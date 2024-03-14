namespace EntityFrameworkTutorial2.Models;

public partial class Costumer
{
    public string FirstLast { get => $"{FirstName} {LastName}"; }
    }
}
