using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController    valuecon=new ValuesController();  //Arrange
    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void GetReturnedCollectNumber()
    {
          
//Given
 var getValue= valuecon.Get(1);   //Act
//When
    Assert.Equal("Sangeeta",getValue);  //Assert

//Then

    }
}