namespace Solid.Interface_Segregation.After;

public class Printer : IPrint
{
    public string Print()
    {
        return "Printing document!";
    }
}
