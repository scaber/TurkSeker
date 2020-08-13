using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TurkSeker.Dal.Db;

namespace TurkSeker.Web.Models
{
    public class Modelller
    {
    }

    public class RoleEditModel

    {

        public int Id { get; set; }
        public IdentityRole Role { get; set; }
        public IEnumerable<Kullanici> Members { get; set; }
        public IEnumerable<Kullanici> NonMembers { get; set; }
    }
    public class RoleUpdateModel
    {
        [Required]
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }


    }
}