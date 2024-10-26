namespace Solid.Interface_Segregation.Before;

public class Scanner : IMultifunctionDevice
{
    public string Fax()
    {
        return "Scanner can't fax!";
    }

    public string Print()
    {
        return "Scanner can't print!";
    }

    public string Scan()
    {
        return "Scanning document!";
    }
}
