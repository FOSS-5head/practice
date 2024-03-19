using System;
using System.Collections.Generic;

namespace practice.Implementions;

public class GroupEntity
{
    public string GroupName { get; set; }
    public List<StudentEntity> Students { get; set; }

    // Метод для додавання студента до групи
    public void AddStudent(StudentEntity student)
    {
        if (Students == null)
            Students = new List<StudentEntity>();

        Students.Add(student);
        student.Group = this; // Встановлення зв'язку між студентом і групою
    }

    // Метод для виведення інформації про групу
    public void PrintGroupInfo()
    {
        Console.WriteLine($"Group: {GroupName}");
        if (Students != null && Students.Count > 0)
        {
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine($"\t{student.GetFullName()}");
            }
        }
        else
        {
            Console.WriteLine("No students in the group.");
        }
    }
}