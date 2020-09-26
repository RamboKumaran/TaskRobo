using System.Threading.Tasks;
using System.Web.Mvc;
using TaskRobo.Business;

namespace TaskRobo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDetails _userDetails;
        public HomeController()
        {
            _userDetails = new UserDetails();
        }
        public async Task<ActionResult> Index()
        {
            var users =  await _userDetails.GetUsersAsync();

            return Json(users, JsonRequestBehavior.AllowGet);

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}