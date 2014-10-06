using System.Web;
using System.Web.Mvc;

namespace week_6_1_code_challenge
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}