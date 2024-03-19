namespace practice.Implementions;

public class SubjectEntity
{
    public string SubjectName { get; set; }

    // Метод для встановлення назви предмету
    public void SetSubjectName(string name)
    {
        SubjectName = name;
    }
}