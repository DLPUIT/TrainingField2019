using System;
using System.Collections.Generic;
using System.Linq;

namespace DlpuManager.Service
{
    public class DlpuManagerService
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
        public void UpdateMember(User user)
        {
            this.dbService.Update(user);
        }
        public void DeleteMember(string name)
        {
            this.dbService.DeleteMany(m => m.Name == name);
            //this.db2Service.delete("delete from User where username = name");
        }
        public IOrderedEnumerable<User> GetRank()
        {
            return this.dbService.GetAll().OrderByDescending(u => u.Credits);
        }
        public User FindMember(string name)
        {
            return this.dbService.Get(x => x.Name == name);
        }
        
    }
}
