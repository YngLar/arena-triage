using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test1.data;

namespace Test1.Pages
{
    public class PrivacyModel : PageModel
    {
        public PrivacyModel()
        {

            PatientsWithDoctors = new List<Patient>
            {
                new Patient("Torgeir", "2", "Svein"),
                new Patient("Yngne", "1", "Kjell"),
                new Patient("Patrick", "4", "Svein"),
                new Patient("Truls", "3", "Svein"),
                new Patient("Marlene", "2", "Svein"),
                new Patient("Ida", "1", "Kjell"),
                new Patient("Turid", "4", "Svein"),
                new Patient("Nils", "3", "Svein"),
                new Patient("Arne", "2", "Svein"),
                new Patient("Åge", "1", "Kjell"),
                new Patient("Jonas", "4", "Svein"),
                new Patient("Truls", "3", "Svein"),
            };

            PatientsWithOutDoctors = new List<Patient>
            {
                new Patient("Atle", "2", ""),
                new Patient("Arne", "1", ""),
                new Patient("Svein", "4", ""),
                new Patient("Pils", "3", ""),
                new Patient("Roar", "2", ""),
            
            };
        }

        public List<Patient> PatientsWithDoctors { get; set; }
        public List<Patient> PatientsWithOutDoctors { get; set; }


        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        
        public void OnGet()
        {
            if(!string.IsNullOrWhiteSpace(Name))
            {
                List<Patient> updatedList = new List<Patient>();
                foreach (var item in PatientsWithDoctors)
                {
                    if (item.Doctor == Name)
                    {
                        updatedList.Add(item);  
                    }
                }

                PatientsWithDoctors = updatedList;
            }
            
        }
    }
}