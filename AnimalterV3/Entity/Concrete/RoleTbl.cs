﻿using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class RoleTbl :IEntity
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        // Bir rolün birden fazla kullanıcısı olabilir
        public virtual ICollection<UserRoleTbl> UserRoles { get; set; }
    }
}
