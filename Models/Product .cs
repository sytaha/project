﻿namespace myapp.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
        public int xyz { get; set; } 
        public int CategoryId { get; set; } 

    
        public User? User { get; set; }
        public Category? Category { get; set; }
    }
}
