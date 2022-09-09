namespace Library.Test;
using TestDateFormat;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void CorrectInput()
    {
        string testDate = DateFormatter.ChangeFormat("10/12/1997");

        string expected = "1997-12-10";
        
        Assert.AreEqual(testDate,expected);
    }
    [Test]
    public void WrongInput()
    {
        string expected = "Formato de fecha invalido";

        string emptyExpected = "Debe ingresar una fecha";
        
        string testDate1 = DateFormatter.ChangeFormat("1/12/1997");
        
        string testDate2 = DateFormatter.ChangeFormat("00/11/1997");
        
        string testDate3 = DateFormatter.ChangeFormat("33/15/1997");
        
        string testDate4 = DateFormatter.ChangeFormat("331/15/1997");

        string testDate5 = DateFormatter.ChangeFormat("aa/bb/cd");

        string testDate6 = DateFormatter.ChangeFormat("12-10-1997");
        
        string testDate7 = DateFormatter.ChangeFormat("");

        Assert.AreEqual(testDate1,expected);
        Assert.AreEqual(testDate2,expected);
        Assert.AreEqual(testDate3,expected);
        Assert.AreEqual(testDate4,expected);
        Assert.AreEqual(testDate5,expected);
        Assert.AreEqual(testDate6,expected);
        Assert.AreEqual(testDate7,emptyExpected);

    }
}