using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class Dataservices
    {
        private readonly DatabaseOption dbservice = new DatabaseOption();

        public IEnumerable<User> GetAllmenber()
        {
            return this.dbservice.GetAll();
        }

        public void Addmember(User user)
        {
            this.dbservice.Add(user);
        }

        public void Updatamember(User user)
        {
            this.dbservice.Update(user);
        }

        public void DeleteMember(string name)
        {
            this.dbservice.DeleteMany(m => m.Name == name);
        }

        public IOrderedEnumerable<User> GetRank()
        {
            return this.dbservice.GetAll().OrderByDescending(u => u.Credits);
        }

        public User FindMember(string name)
        {
            return this.dbservice.Get(x => x.Name == name);
        }
    }
}
