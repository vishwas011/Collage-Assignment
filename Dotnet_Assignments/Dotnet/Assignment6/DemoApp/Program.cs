using MetTours;
using System.Reflection;

using Interest = System.Func<int, int,double>;

class Program
{
    public static double GetTotalTourExpense(double tot, float tax)
    {
        return tot+tot*tax;
    }
    static void Main(string[] args)
    {
        int p = int.Parse(args[0]);
        int q = int.Parse(args[1]);
        Type t = Type.GetType(args[2]);
        MethodInfo scheme = t.GetMethod(args[3]);
        object choice = Activator.CreateInstance(t);
        Interest rate= scheme.CreateDelegate<Interest>(choice);
        LuxaryTaxAttribute md = t.GetCustomAttribute<LuxaryTaxAttribute>();
        var m=md?.Limit ?? 0;
        {
            double a =rate(p,q);
            Console.WriteLine("{0:0.00}",GetTotalTourExpense(a,m));
        }


    }

}