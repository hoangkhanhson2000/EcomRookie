using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("CartItem")]

    public class CartItem : BaseEntity
    {

        public decimal Quantity { get; set; }


        public IList<Cart> Cart { get; set; }
        public IList<Product> Products { get; set; }
    }
    
}
