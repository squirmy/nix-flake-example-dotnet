namespace CepAccounts.Tests;

public class CheckingAccountTests
{
    [Test]
    public void StartingBalance()
    {
        var account = new CheckingAccount(100);
        // Assert.That(account.Balance(), Is.EqualTo(100));
    }
}