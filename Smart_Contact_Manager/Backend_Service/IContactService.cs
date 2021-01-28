using Backend_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Backend_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        List<Contact> GetContacts(int userId);

        [OperationContract]
        Contact AddContact(Contact contact);

        [OperationContract]
        Contact GetContact(Contact contact);

        [OperationContract]
        Contact UpdateContact(Contact contact);
        
        [OperationContract]
        Contact DeleteContact(Contact contact);
    }
}
