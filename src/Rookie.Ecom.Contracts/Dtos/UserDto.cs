﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
  

    public class UserDto 
    {
        public Guid? Id { get; set; }
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

        //public RoleDto Role { get; set; }
        //public OrderDto Order { get; set; }
        //public RatingDto Rating { get; set; }
        //public CartDto Cart { get; set; }
        //public AddressDto Address { get; set; }

        public ICollection<RoleDto> Role { get; set; }
        public ICollection<RatingDto> Rating { get; set; }
        public ICollection<OrderDto> Order { get; set; }
        public ICollection<CartDto> Cart { get; set; }
        public ICollection<AddressDto> Address { get; set; }



    }
}
