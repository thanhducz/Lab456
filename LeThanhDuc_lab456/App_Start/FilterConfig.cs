﻿using System.Web;
using System.Web.Mvc;

namespace LeThanhDuc_lab456
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
