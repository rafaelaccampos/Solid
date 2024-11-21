namespace Solid.Interface_Segregation.Before;

public class FaxMachine : IMultifunctionDevice
{
    public string Print()
    {
        throw new NotSupportedException("Fax can't print");
    }

    public string Scan()
    {
        throw new NotSupportedException("Fax can't scan!");
    }

    public string Fax()
    {
        return "Faxing document";
    }
}
