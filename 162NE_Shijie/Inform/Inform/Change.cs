using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class Manage
    {
        private UserInform handler = new UserInform();
        public void AddUser(UserInform user)
        {
            this.handler.Add(user);
        }
        public IEnumerable<UserInform> GetAllUser()
        {
            return this.handler.GetAll();
        }
        public void DeleteUser(string name)
        {
            this.handler.DeleteMany(x => x.Name == name);
        }
        public void UpdateUser(UserInform user)
        {
            this.handler.Update(user);
        }
        public UserInform FindUser(string name)
        {
            return this.handler.Get(x => x.Name == name);
        }
    }
}
