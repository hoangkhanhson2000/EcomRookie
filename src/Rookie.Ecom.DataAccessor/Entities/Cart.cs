using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Cart")]

    public class Cart : BaseEntity
    {
        [StringLength(maximumLength: 50)]
        public string CartName { get; set; }

        public ICollection<User> User { get; set; }

        public CartItem CartItem { get; set; }
    }
}
