using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test1.data;

namespace Test1.Pages
{
    public class PrivacyModel : PageModel
    {
        public PrivacyModel()
        {
            Patients = new List<Patient>
            {
                new Patient("Torgeir", "2", "Svein Åge"),
                new Patient("Yngne", "1", "Kjell Roar"),
                new Patient("Patrick", "4", "Svein Åge"),
                new Patient("Trusl", "3", "Svein Åge"),
                new Patient("Marlene", "2", "Svein Åge"),
                new Patient("Ida", "1", "Kjell Roar"),
                new Patient("Turid", "4", "Svein Åge"),
                new Patient("Nils", "3", "Svein Åge"),
                new Patient("Arne", "2", "Svein Åge"),
                new Patient("Åge", "1", "Kjell Roar"),
                new Patient("Jonas", "4", "Svein Åge"),
                new Patient("Truls", "3", "Svein Åge"),
            };
        }

        public List<Patient> Patients { get; set; }


        public void OnGet()
        {

            Patients = new List<Patient>();
        }
    }
}