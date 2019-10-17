using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersAPI.Entities
{
     public class User
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int UserID { get; set; }

          [Required]
          [MaxLength(75)]
          public string FirstName { get; set; }

          [MaxLength(75)]
          public string LastName { get; set; }

          // Gender is a string here because a person may not identify as a man or woman
          [Required]
          [MaxLength(20)]
          public string Gender { get; set; }

          // Gender is a string here because a person may not identify as a man or woman
          [Required]
          [MaxLength(20)]
          public string DOB { get; set; }
     }
}