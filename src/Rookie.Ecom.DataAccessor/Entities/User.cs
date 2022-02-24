﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("User")]

    public class User : BaseEntity
    {
       
        [StringLength(maximumLength: 50)]
        public string FirstName { get; set; }
       
        [StringLength(maximumLength: 50)]
        public string LastName { get; set; }

        [StringLength(maximumLength: 250)]
        public int Age { get; set; }

        public bool Gender { get; set; }
        
        [Required]
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Username { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Password { get; set; }

        public ICollection<Role> Role { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Address> Address { get; set; }



    }
}
