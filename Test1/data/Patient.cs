namespace Test1.data
{
    public class Patient
    {
        public string Name { get; set; }
        public string Triage { get; set; }
        public string Doctor { get; set; }

        public Patient(string name, string triage, string doctor)
        {
            Name = name;
            Triage = triage;
            Doctor = doctor;
        }
    }
}
