﻿using System.Web;
using System.Web.Mvc;

namespace WebMVC1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());//required to attach Authorize attribute to each and every action method
        }
    }
}
