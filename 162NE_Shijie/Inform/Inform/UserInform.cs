
using System;

namespace Service
{
    [Collection("User")]
    public class UserInform : DomainModel
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Gender { get; set; }
        public string Team { get; set; }
        public string GitHub { get; set; }
    }



    internal class CollectionAttribute : Attribute
    {
        public CollectionAttribute(string v)
        {
        }
    }
}
