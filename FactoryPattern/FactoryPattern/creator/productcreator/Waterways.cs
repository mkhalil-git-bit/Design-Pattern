class Waterways : ILogistics
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}