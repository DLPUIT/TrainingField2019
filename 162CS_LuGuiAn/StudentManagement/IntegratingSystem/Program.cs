using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class DatabaseOperation : RepositoryBase<User>
    {

    }
    [Collection("person")]
    public class User : DomainModel
    {
    }
}
