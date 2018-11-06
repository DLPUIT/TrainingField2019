using SquirrelFramework.Domain.Model;

namespace course4user
{
    internal class User : user
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Geolocation Geolocation { get; set; }
    }
}