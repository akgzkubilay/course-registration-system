using System.ComponentModel.DataAnnotations;

namespace KursKayıtSıstemı.Models 
{
    public class Candidate
    {
        [Required(ErrorMessage = "Please enter your Email")]
       public string? Email { get; set; }= String.Empty;
         [Required(ErrorMessage = "Please enter your First Name")]
       public string? FirstName { get; set; }= String.Empty;
         [Required(ErrorMessage = "Please enter your Last Name")]
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