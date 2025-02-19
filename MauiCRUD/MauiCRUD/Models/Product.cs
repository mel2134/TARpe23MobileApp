using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product Clone()
        {
            return MemberwiseClone() as Product;
        }

        public (bool IsValid, string? ErrorMessage) Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return (false, $"{nameof(Name)} is required.");
            }
            if (Price <= 0)
            {
                return (false, $"{nameof(Price)} has to be greater than 0");
            }
            return (true, null);
        }
    }
}
