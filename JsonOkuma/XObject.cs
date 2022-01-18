using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOkuma
{
    public class XObject
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname +" , "+ Email +" , "+ PhoneNumber +" , "+City; 
        }
    }
}
