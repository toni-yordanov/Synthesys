using SynthesisClassLibrary.DAL;
using SynthesisClassLibrary.Classess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Synthesis_Website.Pages.Account
{
    public class AccountPageModel : PageModel
    {
        [BindProperty]
        public Player Acc { get; set; }
        private PlayerDataHelper _dataHelper;

        
        
        public void OnGet(int id)
        {

            _dataHelper = new PlayerDataHelper();
            List<Player> acc = _dataHelper.GetPlayers();
            try
            {
                foreach (Player account in acc)
                {
                    if (account.Id == id)
                    {
                        Acc = account;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public IActionResult OnPost()
        {
            try
            {
                _dataHelper.EditPlayer(Acc);
            }
            catch (Exception ex)
            {

            }
            return Redirect("/User/AccountPage");
        }
    }
}
