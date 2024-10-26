namespace Solid.Interface_Segregation.After;

public class FaxMachine : IFax
{
    public string Fax()
    {
        return "Faxing document!";
    }
}
