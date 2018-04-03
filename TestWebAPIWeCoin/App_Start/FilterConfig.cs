using System.Web;
using System.Web.Mvc;

namespace TestWebAPIWeCoin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
