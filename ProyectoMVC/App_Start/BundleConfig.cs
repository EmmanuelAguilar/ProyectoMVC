using System.Web.Optimization;

namespace ProyectoMVC.App_Start
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Definir bundles css y js
            bundles.Add(new StyleBundle("~/Content/bootstrapCSS").Include(
                     "~/assets/css/bootstrap.min.css",
                     "~/assets/css/bootstrap-theme.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                                  "~/assets/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapJS").Include(
                      "~/assets/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/validate").Include(
                      "~/assets/js/jquery.validate.min.js",
                      "~/assets/js/jquery.validate.unobtrusive.min.js"));
        }
    }
}