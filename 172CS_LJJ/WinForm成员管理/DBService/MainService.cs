﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBService
{
    public class MainService
    {
        private readonly DatabaseOperation dbService = new DatabaseOperation();

        public IEnumerable<User> GetAllMembers()
        {
            return this.dbService.GetAll();
        }

        public void AddMember(User user)
        {
            //var dataTable = new DataTable();
            this.dbService.Add(user);
        }

        public void UpdateMember(User user)
        {
            this.dbService.Update(user);
        }

        public void DeleteMember(string name)
        {
            this.dbService.DeleteMany(m => m.Name == name);
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
