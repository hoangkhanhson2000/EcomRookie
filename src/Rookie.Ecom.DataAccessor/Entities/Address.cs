using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Address")]
    public class Address : BaseEntity
    {
       
        [StringLength(maximumLength: 50)]
        public string AddressName { get; set; }

        [StringLength(maximumLength: 100)]
        public string City { get; set; }

        [StringLength(maximumLength: 250)]
        public string Country { get; set; }

    }
}
