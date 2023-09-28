using Moq;
using mymoq.BLL;
using mymoq.Model;
using System.Reflection.Metadata.Ecma335;

namespace mymoqtest;
[TestClass]
public class UnitTest1
{
    List<User> testUers;
    [TestInitialize]
    public void Initialize()
    {
        testUers = GetTestUsers();
    }

    List<User> GetTestUsers()
    {
        IEnumerable<User> userList = new List<User>()
        {
            new User(){UserID=111,UserName="mike1"},
            new User(){UserID=112,UserName="mike2"},
            new User(){UserID=113,UserName="mike3"},
            new User(){UserID=114,UserName="mike4"},
            new User(){UserID=115,UserName="mike5"},
        };
        var userBLL = new Mock<UserBLL>();
        userBLL.Setup<IEnumerable<User>>(u => u.GetList()).Returns(userList);
        var list = userBLL.Object.GetList();
        return list.ToList();
    }


    User GetTestUserMock(long userID)
    {
        var mockUser = new User() { UserID = 888, UserName = "mike888" };
        var userBLL = new Mock<UserBLL>();
        //傳888才有值
        userBLL.Setup<User>(u => u.GetUserByID(888)).Returns(mockUser);
        var user = userBLL.Object.GetUserByID(888);
        //任何userID都是一樣
        //userBLL.Setup<User>(u => u.GetUserByID(It.IsAny<long>())).Returns(mockUser);
        //var user = userBLL.Object.GetUserByID(666);
        return user;
    }
    [TestMethod]
    public void TestMethod_GetTestUsers()
    {   
        Assert.IsTrue(testUers.Count() == 5);
    }

    [TestMethod]
    public void TestMethod_GetTestUserMock()
    {
        var testUserID = 888;
        var user = GetTestUserMock(testUserID);
        Assert.IsTrue(user.UserID == testUserID);
    }
}