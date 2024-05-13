using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        [MinLength(3)]
        [MaxLength(50)]
        public required string Username { get; set; }

        [Required]
        [MinLength(4)]
        public required string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<UserTask>? Tasks { get; set; }

        private User()
        {

        }

        public User(string username, string password)
        {
            Username = username;
            Password = password; 
            DateCreated = DateTime.Now;
        }
    }
}
