using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPU.Service
{
    

    public class DLPUService
    {
        private readonly Databaseoperation dbService = new Databaseoperation();
        public IEnumerable<User> GetAllmember()
        {
            return this.dbService.GetAll();
        }
        public void Addnewmember(User user)
        {
            this.dbService.Add(user);
        }
        public void Updatemember(User user)
        {
            this.dbService.Update(user);
        }
        public void Delmember(string name)
        {
           this.dbService.DeleteMany(x => x.Name == name);
        }
        public IOrderedEnumerable<User> Getrank()
        {
             return this.dbService.GetAll().OrderByDescending(x => x.Gredits);
        }
        public User Findmember(string name)
        {
            return this.dbService.Get(x => x.Name == name);
        }

        
    }
}
