using System;

namespace Studentmanage
{
    internal class collectionAttribute : Attribute
    {
        private string v;

        public collectionAttribute(string v)
        {
            this.v = v;
        }
    }
}