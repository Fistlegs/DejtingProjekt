using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DejtingProjekt.Models
{
    public class ProfileModel
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        public virtual string UserName { get; set; }

        [Required]
        public virtual string FirstName { get; set; }

        [Required]
        public virtual string LastName { get; set; }

        [Required]
        public virtual DateTime Birthdate { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string Height { get; set; }

        [Required]
        public virtual string Gender { get; set; }

        public virtual string AboutUser { get; set; }

        public virtual ICollection<PostModel> WallPost { get; set; }

        public virtual ICollection<ProfileModel> Friends { get; set; }

        public virtual bool Active { get; set; }

        public ProfileModel()
        {
            // WallPost = new HashSet<PostModel>();
            // Friends = new HashSet<ProfileModel>();


        }
    }
}