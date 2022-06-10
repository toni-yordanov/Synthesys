using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisClassLibrary.Classess;

namespace Synthesis_Website.Pages.TournamentPages
{
    public class TournamentModel : PageModel
    {
        public Tournament Tournament { get; set; }
        public void OnGet(int id)
        {
            TournamentManager tm = new TournamentManager(new SynthesisClassLibrary.DAL.TournamentDataHelper());
            Tournament = tm.GetTournament(id);
        }
    }
}
