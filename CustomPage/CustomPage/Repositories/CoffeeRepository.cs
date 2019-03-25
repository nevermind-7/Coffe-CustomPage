using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CustomPage.Repositories.Contacts.Coffee;
using CustomPage.Models;
using CustomPage.Factories;

namespace CustomPage.Repositories
{
    public class CoffeeRepository: ICoffeeRepository
    {
        protected readonly ISqlEngineSpecifications SqlEngineSpecifications;

        public CoffeeRepository(ISqlEngineSpecifications sqlEngineSpecifications)
        {
            SqlEngineSpecifications = sqlEngineSpecifications;
        }

        public void Create(Coffee oCoffe)
        {
            //Empty
        }

        public IEnumerable<Coffee> GetAll()
        {
            IEnumerable<Coffee> coffes = null;

            try
            {
                using (var cn = SqlEngineSpecifications.CreateAndOpenConnection())
                {
                    var sql = "SELECT * FROM [Coffee]";

                    using (var sqlda = new SqlDataAdapter(sql, cn.ConnectionString))
                    {
                        DataSet ds = new DataSet();

                        sqlda.Fill(ds);
                        if (ds.Tables.Count != 0)
                        {
                            coffes = ds.Tables[0].AsEnumerable().Select(
                                datarow => new Coffee()
                                {
                                    Id = datarow.Field<long>("Id"),
                                    Description = datarow.Field<string>("Description"),
                                    Name = datarow.Field<string>("Name")
                                }).ToList().OrderBy(s => s.Name);
                        }
                    }
                }
            }
            catch (Exception)
            {
                    
              // Error... Error Handler
            }
           
            return coffes;
        }
    }
}