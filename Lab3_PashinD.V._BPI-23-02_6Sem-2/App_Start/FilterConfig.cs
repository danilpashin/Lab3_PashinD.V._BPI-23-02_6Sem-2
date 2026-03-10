using System.Web;
using System.Web.Mvc;

namespace Lab3_PashinD.V._BPI_23_02_6Sem_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
