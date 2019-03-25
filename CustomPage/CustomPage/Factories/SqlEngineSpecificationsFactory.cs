using System.Configuration;

namespace CustomPage.Factories
{
        public static class SqlEngineSpecificationsFactory
        {
            public static ISqlEngineSpecifications CreateSqlEngineSpecifications()
            {
                return new SqlServerEngineSpecifications(ConfigurationManager.ConnectionStrings["CustomPage2019"].ConnectionString);
            }
        }
}