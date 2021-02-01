using Backend_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Backend_Service
{
    [ServiceContract]
    public interface IGroupService
    {
        [OperationContract]
        List<Group> GetGroups(int userId);

        [OperationContract]
        Group AddGroup(Group group);

        [OperationContract]
        Group GetGroup(Group group);

        [OperationContract]
        Group UpdateGroup(Group group);

        [OperationContract]
        Group DeleteGroup(Group group);

        [OperationContract]
        GroupContact AddGroupContract(GroupContact groupContract);

        [OperationContract]
        List<GroupContact> GetGroupContacts(int GroupId);

        [OperationContract]
        GroupContact DeleteGroupContact(GroupContact groupContact);

        [OperationContract]
        GroupContact DeleteGroupContactByContactId(GroupContact groupContact);

    }
}
