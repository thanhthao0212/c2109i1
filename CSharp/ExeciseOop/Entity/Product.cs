﻿

namespace ExeciseOop.Entity;
internal class Product
{
    public string ProId{ get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int ProQuantity { get; set; }
    public DateTime ProDate { get; set; }
    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId.ToString()},{nameof(ProName)}={ProName},{nameof(ProPrice)}={ProPrice.ToString()},{nameof(ProQuantity)}={ProQuantity.ToString()},{nameof(ProDate)}={ProDate.ToString()}}}";
    }
}

