﻿namespace Lesson16WpfDependenctInjection.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString(); 
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Price { get; set; }
}
