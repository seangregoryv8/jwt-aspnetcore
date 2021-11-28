using JWTASPNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTASPNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;
        public HomeController(IConfiguration config, ITokenService tokenService, IUserRepository userRepository)
        {
            _config = config;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }
        public IActionResult Index() => View();

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public IActionResult Login(UserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
                return RedirectToAction("Error");

            IActionResult response = Unauthorized();
            var validUser = GetUser(userModel);

            if (validUser != null)
            {
                generatedToken = _tokenService.BuildToken(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), validUser);

                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    return RedirectToAction("MainWindow");
                }
                else return RedirectToAction("Error");
            }
            else return RedirectToAction("Error");
        }
        private UserDTO GetUser(UserModel userModel) => _userRepository.GetUser(userModel);
        private List<UserDTO> GetClerks() => _userRepository.GetUsersByRole("Clerk");

        [HttpGet("ClerkPage")]
        [Authorize(Roles = "Supervisor")]
        public async Task<IActionResult> ManageClerks() => View(GetClerks());

        [Authorize(Roles = "Guest")]
        public IActionResult GuestPage() => View();

        [Authorize(Roles = "Clerk")]
        public IActionResult ClerkPage() => View();

        [Authorize(Roles = "Supervisor")]
        public IActionResult SupervisorPage() => View();

        [Authorize(Roles = "Admin")]
        public IActionResult AdminPage() => View();

        [Authorize]
        [Route("mainwindow")]
        [HttpGet]
        public IActionResult MainWindow()
        {
            string token = HttpContext.Session.GetString("Token");

            if (token == null)
                return RedirectToAction("Index");

            if (!_tokenService.IsTokenValid(_config["Jwt:Key"].ToString(), _config["Jwt:Issuer"].ToString(), token))
                return RedirectToAction("Index");

            ViewBag.Message = BuildMessage(token, 50);
            return View();
        }

        public IActionResult Error()
        {
            ViewBag.Message = "An error occured...";
            return View();
        }
        private string BuildMessage(string stringToSplit, int chunkSize)
        {
            string result = "The generated token is:";

            foreach (string str in Enumerable.Range(0, stringToSplit.Length / chunkSize).Select(i => stringToSplit.Substring(i * chunkSize, chunkSize)))
                result += Environment.NewLine + str;

            return result;
        }
    }
}