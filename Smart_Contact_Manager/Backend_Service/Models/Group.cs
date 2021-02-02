using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Service.Models
{
    [MessageContract]
    public class Group
    {
        public Group()
        {
        }

        [MessageHeader]
        public int GroupId { get; set; }
        
        [MessageHeader]
        public int UserId { get; set; }
        
        [MessageBodyMember]
        public string Name { get; set; }
        
        [MessageBodyMember]
        public string Description { get; set; }
    }
}
