using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TMS.ViewModel;

namespace TMS.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> Rolemanager;
        public RoleController(RoleManager<IdentityRole> Rolemanager)
        {
            this.Rolemanager = Rolemanager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRole role)
        {

            var roleExist = await  Rolemanager.RoleExistsAsync(role.RoleName);
            if (!roleExist)
            {
                
                await Rolemanager.CreateAsync(new IdentityRole(role.RoleName));

            }
            return RedirectToAction("Index");
        }
    }
}
