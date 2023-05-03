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
}