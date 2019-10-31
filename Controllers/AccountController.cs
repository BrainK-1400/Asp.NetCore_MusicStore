using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.ViewModels;

namespace MusicStore.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;//创建用户的
        private SignInManager<ApplicationUser> _signInManager;//用来登录的

        //内部跳转
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {//如果是本地
                return Redirect(returnUrl);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        //添加验证错误
        private void AddError(IdentityResult result)
        {
            //遍历所有的验证错误
            foreach (var error in result.Errors)
            {
                //返回error到model
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        //依赖注入 DI
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                ViewData["ReturnUrl"] = returnUrl;
                var identityUser = new ApplicationUser
                {
                    
                    UserName = registerViewModel.UserName,
                    NormalizedUserName = registerViewModel.UserName
                };
                var identityResult = await _userManager.CreateAsync(identityUser, registerViewModel.Password);
                if (identityResult.Succeeded)
                {
                    //注册完成登录生成cookies信息
                    await _signInManager.SignInAsync(identityUser, new AuthenticationProperties { IsPersistent = true });

                    //return RedirectToAction("Index", "Home");
                    return RedirectToLocal(returnUrl);//跳转到注册之前的Url
                }
                else//注册失败
                {
                    //添加验证错误
                    AddError(identityResult);
                }
            }

            return View();
        }

        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user!=null) //
            {
                var result = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if (result != true) // 密码不匹配时
                {
                    return View(loginViewModel);
                }
                else
                {
                    await _signInManager.SignInAsync(user, new AuthenticationProperties { IsPersistent = true });
                }
            }
            else
            {

                return View(loginViewModel); // 查询不到用户名时
            }
            return RedirectToAction("Index", "Home");
        }
       

        //登出
        public async Task<IActionResult> Logout()
        {
            //HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //return Ok();

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}