using FluentAssertions;
using static RestAssured.Dsl;
    
namespace E2E_Testing;

public class TestHarness
{
    private string? _hostAndPort;

    public TestHarness()
    {
        getHostFromEnvironmentOrDefault();
    }
        
    [Theory]
    [InlineData("night", 23, "2019-02-18", 19)]
    [InlineData("night", 5, "2019-02-18", 0)]
    public void Test1(string type, int age, string date, int expected)
    {

        var url = String.Format("http://{3}/prices?type={0}&age={1}&date={2}",
        type, age, date, _hostAndPort);
        
        var price = Given()
        .When()
            .Get(url)
        .Then()
            .StatusCode(200)
            .And().ContentType("application/json")
            .And().Extract().Body("cost");
        
        price.Should().Be(expected);
    }

    private void getHostFromEnvironmentOrDefault()
    {
        _hostAndPort = System.Environment.GetEnvironmentVariable("APP_HOST_AND_PORT");
        if (string.IsNullOrEmpty(_hostAndPort))
        {
            _hostAndPort = "localhost:8080";
        }
    }
}