using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CustomPage.Models;
using CustomPage.Factories;
using CustomPage.Repositories.Contacts.Contacts;

namespace CustomPage.Repositories
{
    public class ContactRepository: IContactRepository
    {
        protected readonly ISqlEngineSpecifications SqlEngineSpecifications;

        public ContactRepository(ISqlEngineSpecifications sqlEngineSpecifications)
        {
            SqlEngineSpecifications = sqlEngineSpecifications;
        }

        public void Create(Contact oContact)
        {
            try
            {
                using (var cn = SqlEngineSpecifications.CreateAndOpenConnection())
                {
                    var sql = "INSERT INTO [Contact] ([Name], [Lastname], [Comment], [Email]) VALUES (@Name, @Lastname, @Comment, @Email)";

                    using (var sqlda = new SqlDataAdapter(sql, cn.ConnectionString))
                    {
                        sqlda.InsertCommand = new SqlCommand(sql, (SqlConnection)cn);
                        sqlda.InsertCommand.Parameters.AddWithValue("@Name", oContact.Name);
                        sqlda.InsertCommand.Parameters.AddWithValue("@Lastname", oContact.Lastname);
                        sqlda.InsertCommand.Parameters.AddWithValue("@Comment", oContact.Comment);
                        sqlda.InsertCommand.Parameters.AddWithValue("@Email", oContact.Email);
                        sqlda.InsertCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                    
                // Error... Error Handler
            }
           
        }

        public IEnumerable<Contact> GetAll()
        {
            return null;
        }
    }
}