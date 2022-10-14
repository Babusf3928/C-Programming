namespace TDD;


[TestFixture]
public class Tests
{
    Maths operation = null;

    
    [SetUp]
    public void Setup()
    {
        operation = new Maths();
        
        
    }

    [Test]
    public void Test1()
    {
        int result = operation.Addition(10,11);
        Assert.That(result,Is.EqualTo(21));
    }

    [TestCase(10,20,30)]
    [TestCase(1,2,3)]

    public void AdditionOk(int number1 ,int number2,int result)
    {
        int output = operation.Addition(number1,number2);
        Assert.AreEqual(output,result);
    }

    [TestCase(12,32,44)]
    [TestCase(1.2,3.2,4.4)]
    public void AdditionOk(double number1,double number2,double result)
    {
        double output = operation.Addition(number1,number2);
        Assert.AreEqual(output,result);
    }
}