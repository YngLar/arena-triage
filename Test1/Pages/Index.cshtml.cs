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
           
            var name = Request.Form["name"];
            var triageLevel = Request.Form["triagelevel"];
            var doctor = "";

            var patient = new Patient(name, triageLevel, doctor);

            Database.Save(patient);
        }
    }
}