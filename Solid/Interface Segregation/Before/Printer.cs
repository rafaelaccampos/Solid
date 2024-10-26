namespace Solid.Interface_Segregation.Before;

public class Printer : IMultifunctionDevice
{
    public string Fax()
    {
        return "Printer can't scan!";
    }

    public string Print()
    {
        return "Printing document!";
    }

    public string Scan()
    {
        return "Printer can't scan!";
    }
}
