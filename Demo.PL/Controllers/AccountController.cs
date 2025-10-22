using Demo.DAL.Models.IdentityModels;
using Demo.PL.Utility;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	public class AccountController(UserManager<ApplicationUser> _userManager,SignInManager<ApplicationUser> _signInManager) : Controller
	{
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Register(RegisterVM VM)
		{
			if (!ModelState.IsValid) return View(VM);
			var user = new ApplicationUser
			{
				FirstName = VM.FirstName,
				LastName = VM.LastName,
				UserName = VM.UserName,
				Email = VM.Email,
			};
			var result = _userManager.CreateAsync(user, VM.Password).Result;
			if (result.Succeeded)
			{
				return RedirectToAction("Login", "Account");
			}
			else
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
				return View(VM);
			}

		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(LoginVM VM)
		{
			if(!ModelState.IsValid) return View(VM);
			var user= _userManager.FindByEmailAsync(VM.Email).Result;
			if(user != null)
			{
				var isPasswordValid = _userManager.CheckPasswordAsync(user, VM.Password).Result;
				if(isPasswordValid)
				{
					var res= _signInManager.PasswordSignInAsync(user, VM.Password, VM.RememberMe, false).Result;
					if (res.Succeeded) {
						return RedirectToAction("Index", "Home");
					}
					else
					{
						ModelState.AddModelError(string.Empty, "Invalid Login");
						return View(VM);
					}

				}
			}
			return View(VM);
		}
		[HttpGet]
		public IActionResult Logout()
		{
			_signInManager.SignOutAsync().Wait();
			return RedirectToAction(nameof(Login), "Account");
		}
		[HttpGet]
		public IActionResult Forget() {
			return View();
		}
		[HttpPost]
		public IActionResult SendResetPasswordLink(ForgetPasswordViewModel VM) {
			if (ModelState.IsValid) {
				var user = _userManager.FindByEmailAsync(VM.Email).Result;
				if (user != null) {
					var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
					// Generate Reset Link (for demonstration, using a placeholder link)
					var resetLink = Url.Action("ResetPassword", "Account", new { email = VM.Email, token = token }, Request.Scheme);

					var email = new Email()
					{
						To = VM.Email,
						Subject = "Reset Password",
						Body = "Please reset your password by clicking here: <a href='" + resetLink + "'>Reset Password</a>"
					};
					// Send Email Logic Here
					var res= EmailSettings.SendEmail(email);
					if (res) {
						return View("CheckYourInbox");
					}
					else {
						ModelState.AddModelError(string.Empty, "Error sending email. Please try again later.");
						return View("Forget", VM);
					}


				}
				else {
					ModelState.AddModelError(string.Empty, "Email not found");
					return View("Forget", VM);
				}
			}
			else {
				return View("Forget", VM);
			}
			
		}
		[HttpGet]
		public IActionResult CheckYourInbox() {
			return View();
		}
		[HttpGet]
		public IActionResult ResetPassword(string email, string token) {
			TempData["email"] = email;
			TempData["token"] = token;
			return View();
		}
		[HttpPost]
		public IActionResult ResetPassword(ResetPasswordViewModel VM) {
			if (ModelState.IsValid) {
				var email = TempData["email"]?.ToString();
				var token = TempData["token"]?.ToString();
				var user = _userManager.FindByEmailAsync(email).Result;
				if (user != null) {
					var result = _userManager.ResetPasswordAsync(user, token, VM.password).Result;
					if (result.Succeeded) {
						return RedirectToAction("Login", "Account");
					}
					else {
						foreach (var error in result.Errors) {
							ModelState.AddModelError(string.Empty, error.Description);
						}
						return View(VM);
					}
				}
				else {
					ModelState.AddModelError(string.Empty, "Invalid Request");
					return View(VM);
				}
			}
			else {
				return View(VM);

			}
		}
	}
}
