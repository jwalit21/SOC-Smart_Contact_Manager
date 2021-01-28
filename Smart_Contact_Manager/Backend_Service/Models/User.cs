using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Service.Models
{
    [MessageContract]
    public class User
    {
        public User()
        {

        }

        [MessageHeader]
        public int UserId { get; set; }
        
        [MessageBodyMember]
        public string Name { get; set; }
        
        [MessageBodyMember]
        public string Email { get; set; }
        
        [MessageBodyMember]
        public string Password { get; set; }
        
        [MessageBodyMember]
        public string PhoneNumber { get; set; }
    }
}
