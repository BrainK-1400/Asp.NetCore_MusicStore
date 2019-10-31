using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;
using MusicStore.ViewModels;

namespace MusicStore.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationUserRole> _roleManager;

        public RoleController(UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationUserRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        // TO-DO
        public async Task<IActionResult> AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleAddViewModel roleAddViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(roleAddViewModel);
            }
            var role = new ApplicationUserRole
            {
                Name = roleAddViewModel.RoleName
            };
            var resule = await _roleManager.CreateAsync(role);
            if (resule.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View(roleAddViewModel);
        }

        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return RedirectToAction("Index");
            }

            var roleEditViewModel = new RoleEditViewModel
            {
                Id = id,
                RoleName = role.Name,
                Users = new List<string>()
            };

            var users = await _userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    roleEditViewModel.Users.Add(user.UserName);
                }
            }

            return View(roleEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(RoleEditViewModel roleEditViewModel)
        {
            var role = await _roleManager.FindByIdAsync(roleEditViewModel.Id);

            if (role != null)
            {
                role.Name = roleEditViewModel.RoleName;

                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError(string.Empty, "更新角色时出错");

                return View(roleEditViewModel);
            }

            return RedirectToAction("Index");
        }

        // TO-DO
        // Delete role [HttpPost]
        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role!=null)
            {
                var deleteRole = await _roleManager.DeleteAsync(role);
                if (deleteRole.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            return View();
        }

        public async Task<IActionResult> AddUserToRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role==null)
            {
                return RedirectToAction("Index");
            }
            var vm = new UserRoleViewModel
            {
                RoleId = role.Id.ToString()
            };

            var users = await _userManager.Users.ToListAsync();

            foreach (var user in users)
            {
                if (!await _userManager.IsInRoleAsync(user,role.Name))
                {
                    vm.Users.Add(user);
                }
            }
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRoleViewModel userRoleViewModel)
        {
            var roleId = userRoleViewModel.RoleId.ToString();
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            if (user!=null&&role!=null)
            {
                var result = await _userManager.AddToRoleAsync(user, role.Name);

                if (result.Succeeded)
                {
                    return RedirectToAction("EditRole",new {id= roleId });
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(userRoleViewModel);
        }

        // DeleteUserFromRole
        public async Task<IActionResult> DeleteUserFromRole(string roleId)
        {
            var role=await _roleManager.FindByIdAsync(roleId);
            var vm = new UserRoleViewModel
            {
                RoleId = role.Id.ToString()
            };
            if (role!=null)
            {
                var users = await _userManager.GetUsersInRoleAsync(role.Name.ToString());

                foreach (var user in users)
                {
                    vm.Users.Add(user);
                }
            }
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUserFromRole(UserRoleViewModel userRoleViewModel)
        {
            var roleId = userRoleViewModel.RoleId.ToString();
            var user = await _userManager.FindByIdAsync(userRoleViewModel.UserId);
            var role = await _roleManager.FindByIdAsync(userRoleViewModel.RoleId);

            if (user!=null&&role!=null)
            {
                var result = await _userManager.RemoveFromRoleAsync(user, role.Name.ToString());
                if (result.Succeeded)
                {
                    return RedirectToAction("EditRole", new { id = roleId });
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(userRoleViewModel);
        }
    }
}