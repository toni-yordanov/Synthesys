using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisClassLibrary.Classess;
using SynthesisClassLibrary.DAL;

namespace Synthesis_Website.Pages.Account
{
    public class PlayersPageModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public List<Player> Players { get; set; }
        public PlayerManager PlayerManager { get; set; }
        public void OnGet()
        {
            PlayerManager = new PlayerManager(new PlayerDataHelper());
            Players = new List<Player>();
            if (String.IsNullOrEmpty(SearchString))
            {
                Players = PlayerManager.GetPlayers();
            }
            else
            {
                foreach(Player player in PlayerManager.GetPlayers())
                {
                    if (player.Name.Contains(SearchString))
                    {
                        Players.Add(player);
                    }
                }
            }
        }

        
    }
}
