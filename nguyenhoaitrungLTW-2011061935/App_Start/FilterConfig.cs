using System.Web;
using System.Web.Mvc;

namespace nguyenhoaitrungLTW_2011061935
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
