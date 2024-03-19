using practice.Implementions;

namespace practice.Tests
{
    internal class GroupManagerEntityTests
    {
        [Test]
        public void CreateGroup_NewGroupCreated()
        {
            // Arrange
            var groupManager = new GroupManagerEntity();

            // Act
            var group = groupManager.CreateGroup("TestGroup");

            // Assert
            Assert.IsNotNull(group);
            Assert.That(group.GroupName, Is.EqualTo("TestGroup"));
        }
    }
}
