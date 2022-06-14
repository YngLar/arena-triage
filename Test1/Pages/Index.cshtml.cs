using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test1.data;

namespace Test1.Pages
{

   
    public class IndexModel : PageModel
    {

        public Database Database { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            var name = "Patrick";
            var triageLevel = "1";
            var doctor = "Kjell";

            var patient = new Patient(name, triageLevel, doctor);

            Database.Save(patient);
        }


    }
}