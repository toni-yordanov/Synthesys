using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisClassLibrary.Classess;
using SynthesisClassLibrary.DAL;
namespace Synthesis_Website.Pages.Account
{
    public class LogInModel : PageModel
    {
        

        PlayerDataHelper dataHelper;
        private List<Player> accounts;
        
        [Required]
        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public LogInModel()
        {
            dataHelper = new PlayerDataHelper();
            accounts = dataHelper.GetPlayers();
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
               foreach (Player account in accounts)
               {
                    if (account.Email.Equals(Email) && account.Password.Equals(Password))
                    {
                        var claims = new List<Claim> {
                            new Claim(ClaimTypes.Email, account.Email),
                            new Claim(ClaimTypes.Name, account.Name),
                            new Claim(ClaimTypes.NameIdentifier, account.Id.ToString())
                        
                        };
                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                        HttpContext.SignInAsync(claimsPrincipal);

                        return Redirect("/Index");
                    }
                }
                return Page();
            }
            catch(Exception ex)
            {
                return Page();
            }
             
        }
    }
}
