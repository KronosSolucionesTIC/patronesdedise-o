using System;

public class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public object Clone()
    {
        // Aquí usamos MemberwiseClone para realizar una copia superficial
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
