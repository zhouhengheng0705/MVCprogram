using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCprogram
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //エリア(区分)を登録する
            //エリアは、コントローラーをグループ化する機能
            AreaRegistration.RegisterAllAreas();
            //WebAPIに対する設定を行う
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //全コントローラーに適用するFilterを登録
            //Filterによって、コントローラーの各種処理の前後に割り込めるようになる
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //コントローラーのルートを登録する
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //JavaScript、Cssのミニファイ、結合を行うための設定
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // 独自処理追加
            Application["ACTIVE_SESSION_CNT"] = 0;
            //Application["LOGIN_USER_DIC"] = new Dictionary<string, UserClass>();
        }

        // 独自処理追加
        public void Session_OnStart()
        {
            Application.Lock();
            Application["ACTIVE_SESSION_CNT"] = (int)Application["ACTIVE_SESSION_CNT"] + 1;
            Application.UnLock();
        }

        //public void Session_OnEnd()
        //{
        //    // 本イベントはInProcモードのみ有効 ※StateServerモードで運用時は動作しない。
        //    Application.Lock();
        //    if (Session[ConstManager.SESSION_KEY_LOGIN_USER] != null)
        //    {
        //        Dictionary<string, UserClass> loginUserDic = (Dictionary<string, UserClass>)Application["LOGIN_USER_DIC"];
        //        if (loginUserDic.ContainsKey(Session.SessionID))
        //        {
        //            loginUserDic.Remove(Session.SessionID);
        //            Application["LOGIN_USER_DIC"] = loginUserDic;
        //        }
        //        Session.Remove(ConstManager.SESSION_KEY_LOGIN_USER);
        //    }
        //    if ((int)Application["ACTIVE_SESSION_CNT"] >= 1)
        //    {
        //        Application["ACTIVE_SESSION_CNT"] = (int)Application["ACTIVE_SESSION_CNT"] - 1;
        //    }
        //    Application.UnLock();
        //}
    }
}
