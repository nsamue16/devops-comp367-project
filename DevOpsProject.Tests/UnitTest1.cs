using Xunit;

namespace DevOpsProject.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void String_NotNullOrEmpty_ReturnsTrue()
        {
            // Arrange
            string value = "DevOps Project";

            // Assert
            Assert.False(string.IsNullOrEmpty(value));
        }
    }
}