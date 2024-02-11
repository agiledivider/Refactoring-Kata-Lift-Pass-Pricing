using FluentAssertions;
using static RestAssured.Dsl;
    
namespace E2E_Testing;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var price = Given()
        .When()
            .Get("http://localhost:8080/prices?type=night&age=23&date=2019-02-18")
        .Then()
            .StatusCode(200)
            .And().ContentType("application/json")
            .And().Extract().Body("cost");
        
        price.Should().Be(19);
    }
}