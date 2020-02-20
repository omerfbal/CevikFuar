﻿using System.Web.Mvc;

namespace CF.Common.Tools
{
    //HTML temalarda hangi linkin aktif olduğunu belirlemek için oluşturulan Helper metodu.
    public static class HtmlUtility
    {
        //Metot kullanımı => class="@Html.IsActive("Index", "Home")" böylece home controllerdan index actionu aktif iken class içerisini dolduracak.
        public static string IsActive(this HtmlHelper html, string action, string control)
        {
            var routeDate = html.ViewContext.RouteData;
            var routeAction = (string)routeDate.Values["action"];
            var routeControl = (string)routeDate.Values["controller"];

            var returnActive = control.ToLower() == routeControl.ToLower() && action.ToLower() == routeAction.ToLower();
            return returnActive ? "active" : "";
        }

        //Metot kullanımı => class="@Html.IsActive("Home")" böylece home controllerdan herhangi bir actionu aktif iken class içerisini dolduracak.
        public static string IsActive(this HtmlHelper html, string control)
        {
            var routeDate = html.ViewContext.RouteData;
            var routeControl = (string)routeDate.Values["controller"];

            return control.ToLower() == routeControl.ToLower() ? "active" : "";
        }
    }
}