namespace Tours;

[AttributeUsage(AttributeTargets.Method)]

public class LuxuryTaxAttribute : Attribute
{
    public int Limit { get; set;}

    public LuxuryTaxAttribute(int value = 8)
    {
        Limit = value;
    }
}