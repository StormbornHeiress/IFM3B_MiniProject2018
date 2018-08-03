using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MiniProject_WebApplication.Models;
using MiniProject_WebApplication.Models.Account;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniProject_WebApplication.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        private  SignInManager<IdentityUser> SignInManager;
        private  UserManager<IdentityUser> _userManager;
        //private readonly Microsoft.AspNetCore.Mvc.SignInResult _signInResult;

        //IdentityDataContext context;
        //public AccountController()
        //{
        //    context = new IdentityDataContext();
        //}

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            SignInManager = signInManager;
        }

        //public SignInManager SignInManager
        //{
        //    get => _signInManager ?? HttpContext.GetOwinContext().Get<SignInManager>();
        //    private set
        //    {
        //        _signInManager = value;
        //    }
        //}

        //public UserManager UserManager
        //{
        //    get
        //    {
        //        return _userManager ?? HttpContext.GetOwinContext().GetUserManager<UserManager>();
        //    }
        //    private set
        //    {
        //        _userManager = value;
        //    }
        //}

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }





        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl)
        {
            if(!ModelState.IsValid)
            {
                return View();
            
            }

            var result = await SignInManager.PasswordSignInAsync(
                login.EmailAddress, login.Password,
                login.RememberMe, false /*shouldLockout: true*/
                );

            //switch(result)
            //{
            //    //case SignInResult.Success:


            //    //case SignInResult.LockedOut:

            //    //case SignInResult.TwoFactorRequired:


            //    //case SignInResult.Failed:
            //    //default:
            //        return View(login);
                
            //}

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login error!");
                return View();
            }


            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Index", "Home");


            return Redirect(returnUrl);
        }


        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await SignInManager.SignOutAsync();

            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Index", "Home");

            return Redirect(returnUrl);
        }


        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registration)
        {
            if (!ModelState.IsValid)
                return View(registration);

            var newUser = new IdentityUser
            {
                Email = registration.EmailAddress,
                UserName = registration.EmailAddress,
            };

            var result = await _userManager.CreateAsync(newUser, registration.Password);

            if(!result.Succeeded)
            {
                foreach(var error in result.Errors.Select(x => x.Description))
                {
                    ModelState.AddModelError("", error);
                }

                return View();
            }

            return RedirectToAction("Login");
        }

        //// GET: /<controller>/
        //public IActionResult Index()
        //{

        //    return View();
        //}
    }
}
