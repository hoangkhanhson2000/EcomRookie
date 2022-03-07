using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
    

    public class RoleDto 
    {
        public Guid? Id { get; set; }


        [StringLength(maximumLength: 50)]
        public string RoleName { get; set; }

       
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }


        public IList<UserDto> User { get; set; }

    }
}
