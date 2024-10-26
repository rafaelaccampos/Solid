namespace Solid.Interface_Segregation.Before;

public class FaxMachine : IMultifunctionDevice
{
    public string Print()
    {
        return "Fax can't print!";
    }

    public string Scan()
    {
        return "Fax can't scan!";
    }

    public string Fax()
    {
        return "Faxing document";
    }
}
