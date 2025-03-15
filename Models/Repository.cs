namespace KursKayıtSıstemı.Models
{
    
    public static class Repository
    {   // bu kısımda adayların listesini tutuyoruz
        private static List<Candidate> applications = new();
        // bu kısımda adayların listesini dışarıya açıyoruz
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}