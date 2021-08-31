using System.Web;
using System.Web.Mvc;

namespace registros_de_notas_laboratorio
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
