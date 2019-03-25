using System.Data;

namespace CustomPage.Factories
{
    public interface ISqlEngineSpecifications
    {
        IDbConnection CreateAndOpenConnection();
    }
}