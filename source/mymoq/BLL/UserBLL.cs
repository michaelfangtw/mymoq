using mymoq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mymoq.BLL
{
    public  class UserBLL
    {
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
    }
}
