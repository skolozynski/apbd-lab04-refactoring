namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_Returns_False_When_FirstName_Is_Empty()
    {
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            "",
            "Kowalski",
            "costam@email.com",
            DateTime.Parse("2000-01-01"),
            1
            );

        // Assert
        Assert.False(result);
    }
}