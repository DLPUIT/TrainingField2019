using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_management_system.Service
{
    public class Member_management_system_Service
    {
        private DatabaseOperation dbService = new DatabaseOperation();
        public IEnumerable<User> GetAllMember()
        {
            return this.dbService.GetAll();
        }
        public void AddMember(User user)
        {
            this.dbService.Add(user);
        }
        public void Update(User user)
        {
            this.dbService.Update(user);
        }
        public void DeleteMember(string name)
        {
            this.dbService.DeleteMany(J => J.Name == name);
        }
        public IOrderedEnumerable<User> GetRank()
        {
            return this.dbService.GetAll().OrderByDescending(J => J.Credits);
        }
        public User FindMember(string name)
        {
            return this.dbService.Get(J => J.Name == name);
        }

        public object Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}
