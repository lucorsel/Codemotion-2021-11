﻿
namespace Orders.ViewModels;
public class OrderCreateViewModel
{
    public List<ProductViewModel> Products { get; set; }
}

public class OrderReadViewModel
{
    public List<ProductViewModel> Products { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTimeOffset OrderCreated { get; set; }
}
