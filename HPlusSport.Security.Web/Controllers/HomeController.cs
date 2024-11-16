using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;

/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	Vincent Cloutier-Duval - 2235815
* Date: 		<15> <November> 2024
* Class Name: 	HomeController.cs
* Description: 	This controller class manages the home page of this web application.
*               It return the home view or an error view.
* Time Task B):	2 hours. 
*/

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
