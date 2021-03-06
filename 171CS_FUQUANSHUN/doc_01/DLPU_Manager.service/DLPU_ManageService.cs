﻿
// 三层架构中间层，在更换数据库时方便修改代码


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPU_Manager.service
{
    public class DLPU_ManageService
    {
        private readonly DatabaseOperation service = new DatabaseOperation();        
        public IEnumerable<User> GetAllMember()
        {
            return this.service.GetAll();
        }
        public void AddMember(User user)
        {
            this.service.Add(user);
        }
        public void UpdateMember(User user)
        {
            this.service.Update(user);
        }
        public void DeleteMember(string str)
        {
            this.service.DeleteMany(x => x.Name == str || x.Credit == int.Parse(str) || x.Gender == str || x.CSDN == str || x.GitHub == str || x.EnglishName == str);
        }
        public IOrderedEnumerable<User> GetRank()
        {
            return this.service.GetAll().OrderByDescending(x => x.Credit);
        }
        public User FindMember(string str)
        {
            return this.service.Get(x => x.Name == str || x.Credit == int.Parse(str) || x.Gender == str || x.CSDN == str || x.GitHub == str || x.EnglishName == str);
        }
    }
}
