using practice.Implementions;

namespace practice.Tests
{
    internal class TeacherEntityTests
    {
        [Test]
        public void GetTeacherInfo_ReturnsTeacherInfo()
        {
            // Arrange
            var teacher = new TeacherEntity { FirstName = "Jane", LastName = "Smith", Subject = "Math" };

            // Act
            var teacherInfo = teacher.GetTeacherInfo();

            // Assert
            Assert.That(teacherInfo, Is.EqualTo("Teacher: Jane Smith, Subject: Math"));
        }
    }
}
