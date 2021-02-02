using Backend_Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Backend_Service
{
    public class GroupService : IGroupService
    {

        SqlConnection conn;
        SqlCommand cmd;

        void dbInit()
        {
            var connectionString = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public Group AddGroup(Group group)
        {
            dbInit();
            cmd.CommandText = "Insert into [Groups] values(@UserId,@Name,@Description)";
            cmd.Parameters.AddWithValue("@UserId", group.UserId);
            cmd.Parameters.AddWithValue("@Name", group.Name);
            cmd.Parameters.AddWithValue("@Description", group.Description);
            conn.Open();
            Group newGroup;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                conn.Close();
                var grp = new Group();
                grp.GroupId = -1;
                return grp;
            }

            newGroup = group;
            conn.Close();
            return newGroup;
        }

        public Group DeleteGroup(Group group)
        {
            dbInit();
            cmd.CommandText = "DELETE FROM [Groups] WHERE GroupId=@GroupId";
            cmd.Parameters.AddWithValue("@GroupId", group.GroupId);
            conn.Open();
            int rowInserted = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowInserted == 0)
                return new Group(); 
            return group;
        }

        public Group GetGroup(Group group)
        {
            dbInit();
            cmd.CommandText = "SELECT * FROM [Groups] WHERE GroupId=@GroupId and UserId=@UserId";
            cmd.Parameters.AddWithValue("@GroupId", group.GroupId);
            cmd.Parameters.AddWithValue("@UserId", group.UserId);
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            Group fetchedGroup = new Group();
            while (sqlDataReader.Read())
            {
                fetchedGroup.GroupId = sqlDataReader.GetInt32(0);
                fetchedGroup.UserId = sqlDataReader.GetInt32(1);
                fetchedGroup.Name = sqlDataReader.GetString(2);
                fetchedGroup.Description = sqlDataReader.GetString(3);
            }
            sqlDataReader.Close();
            conn.Close();
            return fetchedGroup;
        }

        public List<Group> GetGroups(int userId)
        {
            dbInit();
            cmd.CommandText = "SELECT * FROM [Groups] WHERE UserId=@UserId";
            cmd.Parameters.AddWithValue("@UserId", userId);
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<Group> fetchedGroups = new List<Group>();
            while (sqlDataReader.Read())
            {
                Group fetchedGroup = new Group();
                fetchedGroup.GroupId = sqlDataReader.GetInt32(0);
                fetchedGroup.UserId = sqlDataReader.GetInt32(1);
                fetchedGroup.Name = sqlDataReader.GetString(2);
                fetchedGroup.Description = sqlDataReader.GetString(3);
                fetchedGroups.Add(fetchedGroup);
            }
            sqlDataReader.Close();
            conn.Close();
            return fetchedGroups;
        }

        public Group UpdateGroup(Group group)
        {
            dbInit();
            cmd.CommandText = "UPDATE [Groups] SET Name=@Name, Description=@Description WHERE GroupId=@GroupId";
            cmd.Parameters.AddWithValue("@Name", group.Name);
            cmd.Parameters.AddWithValue("@Description", group.Description);
            cmd.Parameters.AddWithValue("@GroupId", group.GroupId);
            
            conn.Open();
            Group updatedGroup=new Group();
            updatedGroup.GroupId = group.GroupId;
            try
            {
                cmd.ExecuteScalar();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                conn.Close();
                return new Group();
            }
            conn.Close();
            return updatedGroup;
        }

        public GroupContact AddGroupContract(GroupContact groupContract)
        {
            dbInit();
            cmd.CommandText = "Insert into [Group_Contacts] values(@GroupId,@ContactId)";
            cmd.Parameters.AddWithValue("@GroupId", groupContract.GroupId);
            cmd.Parameters.AddWithValue("@ContactId", groupContract.ContactId);
            conn.Open();
            GroupContact newGroupContact;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                conn.Close();
                return new GroupContact();
            }

            newGroupContact = groupContract;
            conn.Close();
            return newGroupContact;
        }

        public List<GroupContact> GetGroupContacts(int GroupId)
        {
            dbInit();
            cmd.CommandText = "SELECT * FROM [Group_Contacts] WHERE GroupId=@GroupId";
            cmd.Parameters.AddWithValue("@GroupId", GroupId);
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<GroupContact> fetchedGroupContacts = new List<GroupContact>();
            while (sqlDataReader.Read())
            {
                GroupContact fetchedGroupContact = new GroupContact();
                fetchedGroupContact.Id = sqlDataReader.GetInt32(0);
                fetchedGroupContact.GroupId = sqlDataReader.GetInt32(1);
                fetchedGroupContact.ContactId = sqlDataReader.GetInt32(2);
                fetchedGroupContacts.Add(fetchedGroupContact);
            }
            sqlDataReader.Close();
            conn.Close();
            return fetchedGroupContacts;
        }

        public GroupContact DeleteGroupContact(GroupContact groupContact)
        {
            dbInit();
            cmd.CommandText = "DELETE FROM [Group_Contacts] WHERE Id=@Id";
            cmd.Parameters.AddWithValue("@Id", groupContact.Id);
            conn.Open();
            int rowDeleted = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowDeleted == 0)
                return new GroupContact();
            return groupContact;
        }
        public GroupContact DeleteGroupContactByContactId(GroupContact groupContact)
        {
            dbInit();
            cmd.CommandText = "DELETE FROM [Group_Contacts] WHERE ContactId=@ContactId";
            cmd.Parameters.AddWithValue("@ContactId", groupContact.ContactId);
            conn.Open();
            int rowDeleted = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowDeleted == 0)
                return new GroupContact();
            return groupContact;
        }

        public GroupContact DeleteGroupContactByGroupId(GroupContact groupContact)
        {
            dbInit();
            cmd.CommandText = "DELETE FROM [Group_Contacts] WHERE GroupId=@GroupId";
            cmd.Parameters.AddWithValue("@GroupId", groupContact.GroupId);
            conn.Open();
            int rowDeleted = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowDeleted == 0)
                return new GroupContact();
            return groupContact;
        }
    }
}
