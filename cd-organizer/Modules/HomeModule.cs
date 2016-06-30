using Nancy;
using System.Collections.Generic;
using CDOrganizer.Objects;

namespace CDOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/cds"] = _ => {
        // Cd cd1 = new Cd("French Suites","JS Bach",4);
        // Cd cd2 = new Cd("English Suites","JS Bach",4);
        var allCds = Cd.GetAllCds();
        return View["Cds.cshtml", allCds];
      };

      Get["cds/new"] = _ => {
        return View["cd_form.cshtml"];
      };

      Post["/cds"] = _ => {
        var newCd = new Cd(Request.Form["cd-name"],Request.Form["cd-artist"],Request.Form["cd-price"]);
        var model = Cd.GetAllCds();
        return View["Cds.cshtml", model];
      };



    }
  }
}
