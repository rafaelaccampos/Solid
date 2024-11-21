namespace Solid.Interface_Segregation.After;

public interface IMultifunctionPrinter : IPrint, IScan, IFax;
public class MultifunctionPrinter : IMultifunctionPrinter
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
