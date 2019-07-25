using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCprogram
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // 除外するルート
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 処理するルート
            // ルートは記述した順序で、一致するか判定が行われるので、具体的なものから記述するなど記述順の注意が必要
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // {}(プレースホルダ)の値が指定されたなかった場合のデフォルト値
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
