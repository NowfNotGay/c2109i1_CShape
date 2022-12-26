using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop.Entity;
internal class Product
{
    public  String Pro_Id { get; set; }
    public String Pro_Name { get; set;}
    public double Pro_Price { get; set; }
    public int Pro_Quantity { get; set; }
    public DateTime Pro_Date { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Pro_Id)}={Pro_Id}, {nameof(Pro_Name)}={Pro_Name}, {nameof(Pro_Quantity)}={Pro_Quantity.ToString()}, {nameof(Pro_Date)}={Pro_Date.ToString()}}}";
    }
}
