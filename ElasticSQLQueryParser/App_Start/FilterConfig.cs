using System.Web;
using System.Web.Mvc;

namespace ElasticSQLQueryParser
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}