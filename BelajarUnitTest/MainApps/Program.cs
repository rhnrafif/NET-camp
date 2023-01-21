class Program
{
    static void Main(string[] args)
    {
        var kalkulator = Kalkulator.Substract;
    }
}

public static class Kalkulator
{
    public static int Add(int a, int b)
    {
        return (a + b);
    } 
    public static int Substract(int a, int b)
    {
        return (a - b);
    }
    public static int Multiply(int a, int b)
    {
        return (a * b);
    }
    public static int Divide(int a, int b)
    {
        return (a / b);
    }
}

public record User(string FisrtName, string LastName)
{
    public int Id { get; init; }
    public DateTime CreateDate { get; init; } = DateTime.Now;
    public string Phone { get; set; }
    public bool VerifiedEmail { get; set; }

}
public class UserManagement
{
    private readonly List<User> _user = new();
    private int idCounter = 1;

    public IEnumerable<User> AllUser => _user;

    public void CreateUser(User user)
    {
        _user.Add(user with {Id = idCounter++ });
    }

    public void UpdatePhone(User user)
    {
        var update = _user.First(w => w.Id == user.Id);

        update.Phone = user.Phone;
    }

    public void VerifyEmail(int id)
    {
        var verEmail = _user.First(w => w.Id == id);

        verEmail.VerifiedEmail = true;
    }
}