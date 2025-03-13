namespace KursKayıtSıstemı.Models 
{
    public class Candidate
    {
       public string? Email { get; set; }= String.Empty;
       public string? FirstName { get; set; }= String.Empty;
       public string? LastName { get; set; }= String.Empty;
       public string?  FullName => $"{FirstName} {LastName?.ToUpper()}";
       public int Age { get; set; }
       public String? SelectedCourse { get; set; }= String.Empty; 
       public DateTime applyAt { get; set; }

       public Candidate()
       {
           applyAt = DateTime.Now;
       }
       
    }
}