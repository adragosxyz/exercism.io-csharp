using System;
using System.Collections.Generic;
public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private int _Mask;
    public Allergies(int mask)
    {
        this._Mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (((int)Math.Pow(2,(int)allergen)) & this._Mask) != 0;
    }

    public Allergen[] List()
    {
        List<Allergen> allergen_list = new List<Allergen>();
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (this.IsAllergicTo(allergen))
                allergen_list.Add(allergen);
        }
        return allergen_list.ToArray();
    }
}