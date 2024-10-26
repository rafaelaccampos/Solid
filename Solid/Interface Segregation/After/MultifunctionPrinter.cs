namespace Solid.Interface_Segregation.After;

public class MultifunctionPrinter : IPrint, IScan, IFax
{
    public string Fax()
    {
        return "Faxing document!";
    }

    public string Print()
    {
        return "Printing document!";
    }

    public string Scan()
    {
        return "Scanning document!";
    }
}
