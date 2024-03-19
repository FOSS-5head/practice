using practice.Implementions;

namespace practice.Tests
{
    internal class GroupEntityTests
    {
        [Test]
        public void AddStudentToGroup_StudentsListNotEmpty()
        {
            // Arrange
            var group = new GroupEntity();
            var student = new StudentEntity { FirstName = "John", LastName = "Doe", StudentID = 123 };

            // Act
            group.AddStudent(student);

            // Assert
            Assert.That(group.Students, Is.Not.Null);
            Assert.That(group.Students.Count, Is.EqualTo(1));
        }
    }
}
