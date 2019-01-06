using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DejtingProjekt.Models
{
    public class PostModel
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual string Content { get; set; }

        public virtual DateTime TimePosted { get; set; }

        public virtual int ProfileId { get; set; } //Våran främmande nyckel som refererrar till den som har skapat posten.
        public virtual ProfileModel ProfileModel { get; set; } // Referrar till våran ProfileModel vilket gör så att man kan se vilken användare som har skrivit vilket post.
    }
}