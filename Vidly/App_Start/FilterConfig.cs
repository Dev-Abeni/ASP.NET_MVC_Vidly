using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // Allows all controllers in the project
            // to be restricted for unauthorized access
            filters.Add(new AuthorizeAttribute());

            // To ensure the website uses SSL certificate
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
