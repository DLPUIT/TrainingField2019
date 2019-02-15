using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    public  class Operation
    {

        private Repo handler = new Repo();
        public void AddUser(UserInfoModel user)
        {
            this.handler.Add(user);
        }
        public IEnumerable<UserInfoModel> GetAllUser()
        {
            return this.handler.GetAll();
        }
        public void DeleteUser(string name)
        {
            this.handler.DeleteMany(x => x.Name == name);
        }
        public void UpdateUser(UserInfoModel user)
        {
            this.handler.Update(user);
        }
        public UserInfoModel FindUser(string name)
        {
            return this.handler.Get(x => x.Name == name);
        }
    }
}

