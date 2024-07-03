﻿using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ShoppingCart.Model.Dto
{
    public class ProductDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; } 

        public int CategoryId { get; set; }
        public int stockQuantity { get; set; }
        public double price { get; set; }
    }
}
