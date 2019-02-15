using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   // 三层架构，中间层
namespace Db
{
   
    public class UserInfoModel: DomainModel
    {
        public string Name { get; set; }

        public string Class { get; set; }

        public string Credit { get; set; }

        public string ID { get; set; }
        
    }
}
