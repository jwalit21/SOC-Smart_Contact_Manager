using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Service.Models
{
    [MessageContract]
    public class GroupContact
    {
        public GroupContact()
        {
        }

        [MessageHeader]
        public int Id { get; set; }

        [MessageHeader]
        public int ContactId { get; set; }

        [MessageHeader]
        public int GroupId { get; set; }
    }
}
