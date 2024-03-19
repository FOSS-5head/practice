namespace practice.Implementions;

public class TeacherEntity : PersonEntity
{
    public string Subject { get; set; }

    // Метод для виведення інформації про вчителя
    public string GetTeacherInfo()
    {
        return $"Teacher: {GetFullName()}, Subject: {Subject}";
    }
}