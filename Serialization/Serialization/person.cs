using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class person
    {
        public string name;
        public int age;
        public string city;
    public person(string name,int age,string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }
    }
}
