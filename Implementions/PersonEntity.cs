namespace practice.Implementions;

public class PersonEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Метод для повернення повного імені
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}