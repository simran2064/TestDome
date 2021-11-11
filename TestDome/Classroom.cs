using System;
using System.Collections.Generic;

public class Classroom
{
    public string Students { get; private set; }
    public Classroom(List<string> students)
    {
        Students = students.ToString();
    }
    //Question: The one about the Product
    //Answer: The solution is to use a property with a backing field, you just had 2 fields.
    //It should look something like this.

    private int quantity;
    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value < 1 ? 1 : value;
        }
    }
}
