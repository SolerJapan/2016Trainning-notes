using System.Web;
using System.Web.Mvc;

namespace prj_CsWebSpa_prc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
