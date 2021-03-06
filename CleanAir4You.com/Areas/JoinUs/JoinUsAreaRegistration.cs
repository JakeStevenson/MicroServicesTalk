﻿using System.Web.Mvc;

namespace CleanAir4You.com.Areas.JoinUs
{
    public class JoinUsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "JoinUs";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "JoinUs_default",
                "JoinUs/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}