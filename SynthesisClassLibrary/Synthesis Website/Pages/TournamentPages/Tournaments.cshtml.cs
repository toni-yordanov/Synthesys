using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisClassLibrary.Classess;
using SynthesisClassLibrary.DAL;
using System.Security.Claims;

namespace Synthesis_Website.Pages.TournamentPages
{
    public class TournamentsModel : PageModel
    {
        public TournamentManager Manager { get; set; }
        private List<Tournament> _tournaments;
        [BindProperty]
        public int TournamentsId { get; set; }
        public void OnGet()
        {
        }

        public TournamentsModel()
        {
            Manager = new TournamentManager(new TournamentDataHelper());
            _tournaments = Manager.GetTournaments();
        }

        public IActionResult OnPost()
        {
            try
            {
                PlayerDataHelper dh = new PlayerDataHelper();
                string pId = User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString();
                dh.AssignPlayerTournament(Convert.ToInt32(pId), TournamentsId);
            }
            catch (Exception ex)
            {

            }
            return Page();
        }
    }
}
