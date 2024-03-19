using practice.Implementions;

namespace practice.Tests
{
    internal class PersonEntityTests
    {
        [Test]
        public void GetFullName_ReturnsFullName()
        {
            // Arrange
            var person = new PersonEntity { FirstName = "Jane", LastName = "Doe" };

            // Act
            var fullName = person.GetFullName();

            // Assert
            Assert.That(fullName, Is.EqualTo("Jane Doe"));
        }
    }
}
