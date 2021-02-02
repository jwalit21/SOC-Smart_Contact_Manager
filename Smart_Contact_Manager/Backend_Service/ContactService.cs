using Backend_Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Backend_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    
    //NOTE: Every parameter in the operation must be Message Contract memeber if one of them of request or return parameter is so then,

    public class ContactService : IContactService
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

        public List<Contact> GetContacts(int userId)
        {
            dbInit();
            cmd.CommandText = "SELECT * FROM [Contacts] WHERE UserId=@UserId";
            cmd.Parameters.AddWithValue("@UserId", userId);
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<Contact> fetchedContacts = new List<Contact>();
            while (sqlDataReader.Read())
            {
                Contact fetchedContact = new Contact();
                fetchedContact.ContactId = sqlDataReader.GetInt32(0);
                fetchedContact.UserId = sqlDataReader.GetInt32(1);
                fetchedContact.Name = sqlDataReader.GetString(2);
                fetchedContact.Email = sqlDataReader.GetString(3);
                fetchedContact.PhoneNumber = sqlDataReader.GetString(4);
                fetchedContact.Description = sqlDataReader.GetString(5);
                fetchedContact.PhotoPath = sqlDataReader.GetString(6);
                fetchedContacts.Add(fetchedContact);
            }
            sqlDataReader.Close();
            conn.Close();
            return fetchedContacts;
        }

        public Contact AddContact(Contact contact)
        {
            dbInit();
            cmd.CommandText = "Insert into [Contacts] values(@UserId,@Name,@Email,@PhoneNumber,@Description,@PhotoPath)";
            cmd.Parameters.AddWithValue("@UserId", contact.UserId);
            cmd.Parameters.AddWithValue("@Name", contact.Name);
            cmd.Parameters.AddWithValue("@Email", contact.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
            cmd.Parameters.AddWithValue("@Description", contact.Description);
            cmd.Parameters.AddWithValue("@PhotoPath", contact.PhotoPath);

            conn.Open();
            Contact newContact;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e) // If phonenumber is already exists then
            {
                conn.Close();
                return new Contact(); //in message contract null value cant returned
            }

            newContact = contact;
            conn.Close();
            return newContact;
        }

        public Contact DeleteContact(Contact contact)
        {
            dbInit();
            cmd.CommandText = "DELETE FROM [Contacts] WHERE ContactId=@ContactId";
            SqlParameter param1 = new SqlParameter("@ContactId", contact.ContactId);
            cmd.Parameters.Add(param1);
            conn.Open();
            int rowEffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowEffected == 0)     // contacId is not valid, ( Contact not exists of provided id)
                return new Contact(); //in message contract, null value cant be returned
            return contact;
        }

        //Here it is assumed that id provided in the input param is valid(Contact exists of that id).
        public Contact GetContact(Contact contact)
        {
            dbInit();
            cmd.CommandText = "SELECT * FROM [Contacts] WHERE ContactId=@ContactId";
            SqlParameter param1 = new SqlParameter("@ContactId", contact.ContactId);
            cmd.Parameters.Add(param1);
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            Contact fetchedContact = new Contact();
            while (sqlDataReader.Read())
            {
                fetchedContact.ContactId = sqlDataReader.GetInt32(0);
                fetchedContact.UserId = sqlDataReader.GetInt32(1);
                fetchedContact.Name = sqlDataReader.GetString(2);
                fetchedContact.Email = sqlDataReader.GetString(3);
                fetchedContact.PhoneNumber = sqlDataReader.GetString(4);
                fetchedContact.Description = sqlDataReader.GetString(5);
                fetchedContact.PhotoPath = sqlDataReader.GetString(6);
            }
            sqlDataReader.Close();
            conn.Close();
            return fetchedContact;
        }

        public Contact UpdateContact(Contact contact)
        {
            dbInit();
            cmd.CommandText = "UPDATE [Contacts] SET Name=@Name, Email=@Email, PhoneNumber=@PhoneNumber, Description=@Description, PhotoPath=@PhotoPath WHERE ContactId=@ContactId";
            cmd.Parameters.AddWithValue("@ContactId", contact.ContactId);
            cmd.Parameters.AddWithValue("@Name", contact.Name);
            cmd.Parameters.AddWithValue("@Email", contact.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
            cmd.Parameters.AddWithValue("@Description", contact.Description);
            cmd.Parameters.AddWithValue("@PhotoPath", contact.PhotoPath);

            conn.Open();
            Contact newContact;
            try
            {
                cmd.ExecuteNonQuery();
                newContact = contact;
            }
            catch (System.Data.SqlClient.SqlException e) //If updated contact no is already exists then
            {
                conn.Close();
                return new Contact(); //in message contract null value cant returned
            }
            conn.Close();
            return newContact; // If Id is not valid then empty object is returned
        }

        public bool UploadToTempFolder(byte[] pFileBytes, string pFileName)
        {
            bool isSuccess = false;
            FileStream fileStream = null;
            //Get the file upload path store in web services web.config file.  
            string strTempFolderPath = System.Configuration.ConfigurationManager.AppSettings.Get("FileUploadPath");
            try
            {

                if (!string.IsNullOrEmpty(strTempFolderPath))
                {
                    if (!string.IsNullOrEmpty(pFileName))
                    {
                        string strFileFullPath = strTempFolderPath + pFileName;
                        fileStream = new FileStream(strFileFullPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        // write file stream into the specified file  
                        using (System.IO.FileStream fs = fileStream)
                        {
                            fs.Write(pFileBytes, 0, pFileBytes.Length);
                            isSuccess = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isSuccess;
        }

        public byte[] GetFileFromFolder(string filename)
        {
            byte[] filedetails = new byte[0];
            string strTempFolderPath = System.Configuration.ConfigurationManager.AppSettings.Get("FileUploadPath");
            if (File.Exists(strTempFolderPath + filename))
            {
                return File.ReadAllBytes(strTempFolderPath + filename);
            }
            else return filedetails;
        }
    }
}
