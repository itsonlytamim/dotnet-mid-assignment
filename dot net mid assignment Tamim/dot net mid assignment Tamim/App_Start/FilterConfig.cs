using System.Web;
using System.Web.Mvc;

namespace dot_net_mid_assignment_Tamim
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
