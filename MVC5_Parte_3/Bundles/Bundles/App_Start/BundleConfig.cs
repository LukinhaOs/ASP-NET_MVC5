using System.Web;
using System.Web.Optimization;

namespace Bundles
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Otimiza e compacta arquivos da solução
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/comum").IncludeDirectory("~/Scripts/comum", "*.js", true));

            var ordem = new BundleFileSetOrdering("meuScript");
            ordem.Files.Add("TesteOtimi.js");
            ordem.Files.Add("Display.js");
            bundles.FileSetOrderList.Insert(0, ordem);

            // Otimização de arquivos com a sub-extensão e melhora responsividade de arquivos
            bundles.IgnoreList.Ignore("*.dbg.js");
            // "dbg" é uma sub-extensão ficticia (todo arquivo com a sux- extensão dbo será ignorado na execução com o JS)

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
