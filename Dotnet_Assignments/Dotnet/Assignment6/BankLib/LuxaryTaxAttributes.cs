namespace MetTours;

[AttributeUsage(AttributeTargets.Method)]

public class LuxaryTaxAttribute : Attribute
{

    public float Limit {get; set;}

    public LuxaryTaxAttribute(float value = 0.08f)
    {
        Limit = value;
    }
}