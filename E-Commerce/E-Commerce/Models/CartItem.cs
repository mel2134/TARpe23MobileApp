﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public partial class CartItem : ObservableObject
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        public int _quantity;
        public decimal Amount => Price * Quantity;
    }
}
