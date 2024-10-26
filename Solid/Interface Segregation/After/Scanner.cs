namespace Solid.Interface_Segregation.After;

public class Scanner : IScan
{
    public string Scan()
    {
        return "Scanning document!";
    }
}
