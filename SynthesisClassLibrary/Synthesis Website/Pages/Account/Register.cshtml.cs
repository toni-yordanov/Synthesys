using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisClassLibrary.DAL;
using SynthesisClassLibrary.Classess;

namespace Synthesis_Website.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Address { get;  set; }
        [BindProperty]
        public DateTime BirthDate { get;  set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            PlayerDataHelper dh = new PlayerDataHelper();

            try
            {
                Player a = new Player(Name, Email, Password, Address, BirthDate);
                dh.AddPlayer(a);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
