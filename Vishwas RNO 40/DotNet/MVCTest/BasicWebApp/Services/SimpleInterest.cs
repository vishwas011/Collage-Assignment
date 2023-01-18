namespace BasicWebApp.Services;

public class SimpleInterest : ICalculate
{
    public double SiCalculate(double Principal, int Rate, int Years) => (Principal * Rate * Years) / 100;
}