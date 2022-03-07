using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{


    public class CartDto 
    {
        public Guid? Id { get; set; }

        [StringLength(maximumLength: 50)]
        public string CartName { get; set; }

        public ICollection<UserDto> User { get; set; }


    }
}
