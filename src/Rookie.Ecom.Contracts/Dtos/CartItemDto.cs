using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.Contracts.Dtos
{
    

    public class CartItemDto 
    {
        public Guid? Id { get; set; }
        
        public decimal Quantity { get; set; }


        public IList<CartDto> Cart { get; set; }
        public IList<ProductDto> Products { get; set; }
    }
    
}
