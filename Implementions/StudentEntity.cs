namespace practice.Implementions;

public class StudentEntity : PersonEntity
{
    public int StudentID { get; set; }
    public GroupEntity Group { get; set; } // Зв'язок між студентом і групою

    // Метод для виведення інформації про студента
    public string GetStudentInfo()
    {
        return $"Student ID: {StudentID}, Name: {GetFullName()}";
    }
}