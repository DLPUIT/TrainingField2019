using Repo;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class  Program
    {
        private RepositoryBase handler = new RepositoryBase();
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

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    internal class RepositoryBase
    {
        internal void Add(UserInform user)
        {
            throw new NotImplementedException();
        }

        internal void DeleteMany(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal UserInform Get(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<UserInform> GetAll()
        {
            throw new NotImplementedException();
        }

        internal void Update(UserInform user)
        {
            throw new NotImplementedException();
        }
    }
}
