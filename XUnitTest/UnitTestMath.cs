using HelloWorld;

namespace XUnitTest;

public class UnitTestMath
{
    [Fact]
    public void TestMath()
    {
        var actual = MyMath.Add(100, 200);
        Assert.Equal(300, actual);
    }
    
    [Fact]
    public void TestMath2()
    {
        var actual = MyMath.Add(20, 200);
        Assert.Equal(220, actual);
    }
}