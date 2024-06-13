using SpaceInvaders.Avalonia.ViewModels;

namespace SpaceInvaders.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var thing = new MainWindowViewModel();
        
        var expectedGreeting = "Welcome to Avalonia!";

        Assert.Equal(expectedGreeting, thing.Greeting);
        
    }
}