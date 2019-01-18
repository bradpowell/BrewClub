using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Brad.BrewClub.WebUI.Pages
{
    public class ClubInfoModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Put in description of the club.";
        }
    }
}
