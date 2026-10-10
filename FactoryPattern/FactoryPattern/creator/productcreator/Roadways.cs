class Roadways : ILogistics
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}