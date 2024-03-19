using practice.Implementions;

namespace practice.Tests
{
    internal class StudentEntityTests
    {
        [Test]
        public void GetStudentInfo_ReturnsStudentInfo()
        {
            // Arrange
            var student = new StudentEntity { FirstName = "John", LastName = "Doe", StudentID = 123 };

            // Act
            var studentInfo = student.GetStudentInfo();

            // Assert
            Assert.That(studentInfo, Is.EqualTo("Student ID: 123, Name: John Doe"));
        }
    }
}
