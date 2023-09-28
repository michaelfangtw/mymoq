# MyMOQ
A sample for mock sample of moq in unit tests

# Quick Sample
sample project:source/mymoq/*
unit test project:source/mymotest/* 
```
 public virtual IEnumerable<User> GetList()
        {
            var users =new List<User>()
            {
                new User{UserID=1,UserName="mike",Email="fij1@funtech.one"},
                new User{UserID=2,UserName="mike",Email="fij2@funtech.one"}
            };
            return users;
        }

        public virtual User GetUserByID(long id)
        {
            var user = new User { UserID = 999, UserName = "mike", Email = "fij1@funtech.one" };
            return user;
        }
```
# MOQ Usage
```

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
        userBLL.Setup<User>(u => u.GetUserByID(It.IsAny<long>())).Returns(mockUser);
        var user = userBLL.Object.GetUserByID(userID);
        return user;
    }
```
