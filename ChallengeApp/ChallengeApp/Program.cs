User user1 = new User("Ania", "sasdf");
User user2 = new User("Marek", "sasdf");

user1.AddScore(5);
user1.AddScore(2);
user2.AddScore(3);
user2.AddScore(6);
var result1 = user1.Result;
var result2 = user2.Result;
Console.WriteLine("Wynik dla user1: " + result1);
Console.WriteLine("Wynik dla user2: " + result2);
var name = User.GameName;
Console.WriteLine(name);
class User
{
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}